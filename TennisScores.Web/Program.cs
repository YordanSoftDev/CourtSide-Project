using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TennisScores.Data.Persistance;
using TennisScores.Services.Core.Contracts;
using TennisScores.Services.Core.Services;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

string? connectionString = builder.Environment.IsDevelopment()
    ? builder.Configuration.GetConnectionString("SqlServerDev")
    : builder.Configuration.GetConnectionString("DefaultConnection");

if (string.IsNullOrWhiteSpace(connectionString))
{
    throw new InvalidOperationException("Connection string " +
        "'SqlServerDev' was not found or is empty " +
        "in configuration.");
}

builder.Services.AddDbContext<TennisScoresDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
})
.AddEntityFrameworkStores<TennisScoresDbContext>();

builder.Services.AddAutoMapper(cfg =>
    cfg.AddMaps(typeof(SQLMatchService).Assembly));

builder.Services.AddScoped<IMatchService, SQLMatchService>();
builder.Services.AddScoped<IPlayerService, SQLPlayerService>();
builder.Services.AddScoped<ITournamentService, SQLTournamentService>();

WebApplication? app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapRazorPages();

try
{
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

        string roleName = "Admin";
        if (!await roleManager.RoleExistsAsync(roleName))
        {
            await roleManager.CreateAsync(new IdentityRole(roleName));
            Console.WriteLine("[SEEDS] Created 'Admin' role successfully.");
        }

        var adminUser = await userManager.FindByEmailAsync("admin@tennisscores.com");
        if (adminUser != null && !await userManager.IsInRoleAsync(adminUser, roleName))
        {
            await userManager.AddToRoleAsync(adminUser, roleName);
        }
    }
}
catch (Exception ex)
{
    var logger = app.Services.GetRequiredService<ILogger<Program>>();
    logger.LogError(ex, "An error occurred while seeding the database with the admin role.");
}

app.Run();
