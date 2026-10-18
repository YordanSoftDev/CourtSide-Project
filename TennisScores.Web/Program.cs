using Microsoft.EntityFrameworkCore;
using TennisScores.Data.Persistance;
using TennisScores.Services.Core.Contracts;
using TennisScores.Services.Core.Services;
using Microsoft.AspNetCore.Identity;
using TennisScores.Web.Data;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string? connectionString = builder.Configuration
    .GetConnectionString("DefaultConnection");

if (string.IsNullOrWhiteSpace(connectionString))
{
    throw new InvalidOperationException("Connection string " +
        "'DefaultConnection' was not found or is empty " +
        "in configuration.");
}

builder.Services.AddDbContext<TennisScoresDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<TennisScoresDbContext>();

builder.Services.AddAutoMapper(cfg =>
    cfg.AddMaps(typeof(SQLMatchService).Assembly));

builder.Services.AddScoped<IMatchService, SQLMatchService>();
builder.Services.AddScoped<IPlayerService, SQLPlayerService>();
builder.Services.AddScoped<ITournamentService, SQLTournamentService>();

WebApplication? app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
