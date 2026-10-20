using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TennisScores.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tournaments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TournamentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CourtSurface = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CourtEnvironment = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Venues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Height = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Birthplace = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TournamentVenues",
                columns: table => new
                {
                    TournamentId = table.Column<int>(type: "int", nullable: false),
                    VenueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentVenues", x => new { x.TournamentId, x.VenueId });
                    table.ForeignKey(
                        name: "FK_TournamentVenues_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TournamentVenues_Venues_VenueId",
                        column: x => x.VenueId,
                        principalTable: "Venues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Coaches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coaches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coaches_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstPlayerId = table.Column<int>(type: "int", nullable: false),
                    SecondPlayerId = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MatchStatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MatchRound = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CourtSurface = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CourtName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CourtEnvironment = table.Column<int>(type: "int", maxLength: 20, nullable: true),
                    VenueId = table.Column<int>(type: "int", nullable: false),
                    TournamentId = table.Column<int>(type: "int", nullable: false),
                    ScoreResult = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    WinnerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matches_Players_FirstPlayerId",
                        column: x => x.FirstPlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Players_SecondPlayerId",
                        column: x => x.SecondPlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Players_WinnerId",
                        column: x => x.WinnerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Venues_VenueId",
                        column: x => x.VenueId,
                        principalTable: "Venues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Afghanistan" },
                    { 2, "Albania" },
                    { 3, "Algeria" },
                    { 4, "Andorra" },
                    { 5, "Angola" },
                    { 6, "Antigua and Barbuda" },
                    { 7, "Argentina" },
                    { 8, "Armenia" },
                    { 9, "Australia" },
                    { 10, "Austria" },
                    { 11, "Azerbaijan" },
                    { 12, "Bahamas" },
                    { 13, "Bahrain" },
                    { 14, "Bangladesh" },
                    { 15, "Barbados" },
                    { 16, "Belarus" },
                    { 17, "Belgium" },
                    { 18, "Belize" },
                    { 19, "Benin" },
                    { 20, "Bhutan" },
                    { 21, "Bolivia" },
                    { 22, "Bosnia and Herzegovina" },
                    { 23, "Botswana" },
                    { 24, "Brazil" },
                    { 25, "Brunei" },
                    { 26, "Bulgaria" },
                    { 27, "Burkina Faso" },
                    { 28, "Burundi" },
                    { 29, "Cabo Verde" },
                    { 30, "Cambodia" },
                    { 31, "Cameroon" },
                    { 32, "Canada" },
                    { 33, "Central African Republic" },
                    { 34, "Chad" },
                    { 35, "Chile" },
                    { 36, "China" },
                    { 37, "Colombia" },
                    { 38, "Comoros" },
                    { 39, "Congo (Brazzaville)" },
                    { 40, "Costa Rica" },
                    { 41, "Côte d'Ivoire" },
                    { 42, "Croatia" },
                    { 43, "Cuba" },
                    { 44, "Cyprus" },
                    { 45, "Czechia (Czech Republic)" },
                    { 46, "Democratic Republic of the Congo" },
                    { 47, "Denmark" },
                    { 48, "Djibouti" },
                    { 49, "Dominica" },
                    { 50, "Dominican Republic" },
                    { 51, "Ecuador" },
                    { 52, "Egypt" },
                    { 53, "El Salvador" },
                    { 54, "Equatorial Guinea" },
                    { 55, "Eritrea" },
                    { 56, "Estonia" },
                    { 57, "Eswatini" },
                    { 58, "Ethiopia" },
                    { 59, "Fiji" },
                    { 60, "Finland" },
                    { 61, "France" },
                    { 62, "Gabon" },
                    { 63, "Gambia" },
                    { 64, "Georgia" },
                    { 65, "Germany" },
                    { 66, "Ghana" },
                    { 67, "Greece" },
                    { 68, "Grenada" },
                    { 69, "Guatemala" },
                    { 70, "Guinea" },
                    { 71, "Guinea-Bissau" },
                    { 72, "Guyana" },
                    { 73, "Haiti" },
                    { 74, "Holy See" },
                    { 75, "Honduras" },
                    { 76, "Hungary" },
                    { 77, "Iceland" },
                    { 78, "India" },
                    { 79, "Indonesia" },
                    { 80, "Iran" },
                    { 81, "Iraq" },
                    { 82, "Ireland" },
                    { 83, "Israel" },
                    { 84, "Italy" },
                    { 85, "Jamaica" },
                    { 86, "Japan" },
                    { 87, "Jordan" },
                    { 88, "Kazakhstan" },
                    { 89, "Kenya" },
                    { 90, "Kiribati" },
                    { 91, "Kuwait" },
                    { 92, "Kyrgyzstan" },
                    { 93, "Laos" },
                    { 94, "Latvia" },
                    { 95, "Lebanon" },
                    { 96, "Lesotho" },
                    { 97, "Liberia" },
                    { 98, "Libya" },
                    { 99, "Liechtenstein" },
                    { 100, "Lithuania" },
                    { 101, "Luxembourg" },
                    { 102, "Madagascar" },
                    { 103, "Malawi" },
                    { 104, "Malaysia" },
                    { 105, "Maldives" },
                    { 106, "Mali" },
                    { 107, "Malta" },
                    { 108, "Marshall Islands" },
                    { 109, "Mauritania" },
                    { 110, "Mauritius" },
                    { 111, "Mexico" },
                    { 112, "Micronesia" },
                    { 113, "Moldova" },
                    { 114, "Monaco" },
                    { 115, "Mongolia" },
                    { 116, "Montenegro" },
                    { 117, "Morocco" },
                    { 118, "Mozambique" },
                    { 119, "Myanmar (Burma)" },
                    { 120, "Namibia" },
                    { 121, "Nauru" },
                    { 122, "Nepal" },
                    { 123, "Netherlands" },
                    { 124, "New Zealand" },
                    { 125, "Nicaragua" },
                    { 126, "Niger" },
                    { 127, "Nigeria" },
                    { 128, "North Korea" },
                    { 129, "North Macedonia" },
                    { 130, "Norway" },
                    { 131, "Oman" },
                    { 132, "Pakistan" },
                    { 133, "Palau" },
                    { 134, "Palestine State" },
                    { 135, "Panama" },
                    { 136, "Papua New Guinea" },
                    { 137, "Paraguay" },
                    { 138, "Peru" },
                    { 139, "Philippines" },
                    { 140, "Poland" },
                    { 141, "Portugal" },
                    { 142, "Qatar" },
                    { 143, "Romania" },
                    { 144, "Russia" },
                    { 145, "Rwanda" },
                    { 146, "Saint Kitts and Nevis" },
                    { 147, "Saint Lucia" },
                    { 148, "Saint Vincent and the Grenadines" },
                    { 149, "Samoa" },
                    { 150, "San Marino" },
                    { 151, "Sao Tome and Principe" },
                    { 152, "Saudi Arabia" },
                    { 153, "Senegal" },
                    { 154, "Serbia" },
                    { 155, "Seychelles" },
                    { 156, "Sierra Leone" },
                    { 157, "Singapore" },
                    { 158, "Slovakia" },
                    { 159, "Slovenia" },
                    { 160, "Solomon Islands" },
                    { 161, "Somalia" },
                    { 162, "South Africa" },
                    { 163, "South Korea" },
                    { 164, "South Sudan" },
                    { 165, "Spain" },
                    { 166, "Sri Lanka" },
                    { 167, "Sudan" },
                    { 168, "Suriname" },
                    { 169, "Sweden" },
                    { 170, "Switzerland" },
                    { 171, "Syria" },
                    { 172, "Tajikistan" },
                    { 173, "Tanzania" },
                    { 174, "Thailand" },
                    { 175, "Timor-Leste" },
                    { 176, "Togo" },
                    { 177, "Tonga" },
                    { 178, "Trinidad and Tobago" },
                    { 179, "Tunisia" },
                    { 180, "Turkey" },
                    { 181, "Turkmenistan" },
                    { 182, "Tuvalu" },
                    { 183, "Uganda" },
                    { 184, "Ukraine" },
                    { 185, "United Arab Emirates" },
                    { 186, "United Kingdom" },
                    { 187, "United States of America" },
                    { 188, "Uruguay" },
                    { 189, "Uzbekistan" },
                    { 190, "Vanuatu" },
                    { 191, "Venezuela" },
                    { 192, "Vietnam" },
                    { 193, "Yemen" },
                    { 194, "Zambia" },
                    { 195, "Zimbabwe" }
                });

            migrationBuilder.InsertData(
                table: "Tournaments",
                columns: new[] { "Id", "CourtEnvironment", "CourtSurface", "EndDate", "IsActive", "Location", "StartDate", "TournamentName", "TournamentType" },
                values: new object[,]
                {
                    { 1, "Outdoor", "Grass", new DateTime(2026, 7, 12, 0, 0, 0, 0, DateTimeKind.Utc), true, "London, United Kingdom", new DateTime(2026, 6, 29, 0, 0, 0, 0, DateTimeKind.Utc), "Wimbledon", "Grand Slam" },
                    { 2, "Outdoor", "Clay", new DateTime(2026, 6, 7, 0, 0, 0, 0, DateTimeKind.Utc), true, "Paris, France", new DateTime(2026, 5, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Roland Garros", "Grand Slam" },
                    { 3, "Outdoor", "Hard", new DateTime(2026, 9, 13, 0, 0, 0, 0, DateTimeKind.Utc), true, "New York, USA", new DateTime(2026, 8, 31, 0, 0, 0, 0, DateTimeKind.Utc), "US Open", "Grand Slam" },
                    { 4, "Indoor", "Hard", new DateTime(2026, 10, 25, 0, 0, 0, 0, DateTimeKind.Utc), true, "Almaty, Kazakhstan", new DateTime(2026, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Almaty Open", "ATP 250" },
                    { 5, "Outdoor", "Hard", new DateTime(2026, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), true, "Melbourne, Australia", new DateTime(2026, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Australian Open", "Grand Slam" },
                    { 6, "Outdoor", "Clay", new DateTime(2026, 4, 19, 0, 0, 0, 0, DateTimeKind.Utc), true, "Roquebrune-Cap-Martin, France", new DateTime(2026, 4, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Monte-Carlo Masters", "ATP 1000" },
                    { 7, "Outdoor", "Clay", new DateTime(2026, 5, 17, 0, 0, 0, 0, DateTimeKind.Utc), true, "Madrid, Spain", new DateTime(2026, 5, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Mutua Madrid Open", "ATP 1000" },
                    { 8, "Outdoor", "Clay", new DateTime(2026, 5, 24, 0, 0, 0, 0, DateTimeKind.Utc), true, "Rome, Italy", new DateTime(2026, 5, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Italian Open", "ATP 1000" },
                    { 9, "Outdoor", "Grass", new DateTime(2026, 6, 21, 0, 0, 0, 0, DateTimeKind.Utc), true, "London, United Kingdom", new DateTime(2026, 6, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Cinch Championships", "ATP 500" },
                    { 10, "Indoor", "Hard", new DateTime(2026, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, "Basel, Switzerland", new DateTime(2026, 10, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Swiss Indoors Basel", "ATP 500" }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "All England Lawn Tennis and Croquet Club" },
                    { 2, "Stade Roland Garros" },
                    { 3, "USTA Billie Jean King National Tennis Center" },
                    { 4, "Almaty Arena" },
                    { 5, "Melbourne Park" },
                    { 6, "Monte-Carlo Country Club" },
                    { 7, "Caja Mágica" },
                    { 8, "Foro Italico" },
                    { 9, "Queen's Club" },
                    { 10, "St. Jakobshalle" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "Birthplace", "CountryId", "FirstName", "Height", "LastName", "Rank", "Weight" },
                values: new object[,]
                {
                    { 1, 36, "Belgrade, Serbia", 154, "Novak", "6'2\"/(188cm)", "Djokovic", 11, "170 lbs/(77kg)" },
                    { 2, 20, "El Palmar, Murcia, Spain", 165, "Carlos", "6'0\"/(183cm)", "Alcaraz", 3, "163 lbs/(74kg)" },
                    { 3, 22, "Innichen, Italy", 84, "Jannik", "6'3\"/(191cm)", "Sinner", 1, "168 lbs/(76kg)" },
                    { 4, 28, "Moscow, Russia", 114, "Daniil", "6'6\"/(198cm)", "Medvedev", 9, "183 lbs/(83kg)" },
                    { 5, 26, "Hamburg, Germany", 65, "Alexander", "6'6\"/(198cm)", "Zverev", 2, "198 lbs/(90kg)" },
                    { 6, 35, "Haskovo, Bulgaria", 26, "Grigor", "6'3\"/(191cm)", "Dimitrov", 121, "178 lbs/(80kg)" },
                    { 7, 28, "Athens, Greece", 67, "Stefanos", "6'4\"/(193cm)", "Tsitsipas", 43, "198 lbs/(90kg)" },
                    { 8, 27, "Oslo, Norway", 130, "Casper", "6'0\"/(183cm)", "Ruud", 24, "178 lbs/(81kg)" },
                    { 9, 23, "Gentofte, Denmark", 47, "Holger", "6'2\"/(188cm)", "Rune", 188, "169 lbs/(77kg)" },
                    { 10, 28, "Rancho Santa Fe, California, USA", 187, "Taylor", "6'5\"/(196cm)", "Fritz", 12, "185 lbs/(84kg)" },
                    { 11, 27, "Sydney, Australia", 9, "Alex", "6'0\"/(183cm)", "de Minaur", 9, "152 lbs/(69kg)" },
                    { 12, 28, "Moscow, Russia", 144, "Andrey", "6'2\"/(188cm)", "Rublev", 23, "165 lbs/(75kg)" },
                    { 13, 29, "Wroclaw, Poland", 140, "Hubert", "6'5\"/(196cm)", "Hurkacz", 34, "179 lbs/(81kg)" },
                    { 14, 23, "Atlanta, Georgia, USA", 187, "Ben", "6'4\"/(193cm)", "Shelton", 4, "195 lbs/(88kg)" },
                    { 15, 28, "Hyattsville, Maryland, USA", 187, "Frances", "6'2\"/(188cm)", "Tiafoe", 10, "190 lbs/(86kg)" },
                    { 16, 28, "Metz, France", 61, "Ugo", "6'2\"/(188cm)", "Humbert", 32, "161 lbs/(73kg)" },
                    { 17, 26, "Bradenton, Florida, USA", 187, "Sebastian", "6'5\"/(196cm)", "Korda", 74, "175 lbs/(79kg)" },
                    { 18, 24, "Carrara, Italy", 84, "Lorenzo", "6'1\"/(185cm)", "Musetti", 25, "165 lbs/(75kg)" },
                    { 19, 24, "Sutton, London, United Kingdom", 186, "Jack", "6'4\"/(193cm)", "Draper", 18, "187 lbs/(85kg)" },
                    { 20, 26, "Montreal, Canada", 32, "Felix", "6'4\"/(193cm)", "Auger-Aliassime", 5, "194 lbs/(88kg)" },
                    { 21, 25, "Mar del Plata, Argentina", 7, "Francisco", "5'10\"/(178cm)", "Comesana", 125, "165 lbs/(75kg)" },
                    { 22, 31, "Johannesburg, South Africa", 186, "Cameron", "6'2\"/(188cm)", "Norrie", 40, "180 lbs/(82kg)" },
                    { 23, 41, "Lausanne, Switzerland", 170, "Stan", "6'0\"/(183cm)", "Wawrinka", 162, "179 lbs/(81kg)" },
                    { 24, 40, "Paris, France", 61, "Gaël", "6'4\"/(193cm)", "Monfils", 46, "187 lbs/(85kg)" },
                    { 25, 30, "Rome, Italy", 84, "Matteo", "6'5\"/(196cm)", "Berrettini", 46, "210 lbs/(95kg)" },
                    { 26, 30, "Moscow, Russia", 144, "Karen", "6'6\"/(198cm)", "Khachanov", 27, "192 lbs/(87kg)" },
                    { 27, 25, "Buenos Aires, Argentina", 7, "Sebastian", "5'7\"/(170cm)", "Baez", 53, "154 lbs/(70kg)" },
                    { 28, 28, "Buenos Aires, Argentina", 7, "Francisco", "6'1\"/(185cm)", "Cerundolo", 20, "172 lbs/(78kg)" },
                    { 29, 29, "Toronto, Canada", 35, "Alejandro", "6'2\"/(188cm)", "Tabilo", 30, "165 lbs/(75kg)" },
                    { 30, 30, "Santiago, Chile", 35, "Nicolas", "6'7\"/(201cm)", "Jarry", 52, "198 lbs/(90kg)" },
                    { 31, 27, "La Plata, Argentina", 7, "Tomas Martin", "6'5\"/(196cm)", "Etcheverry", 31, "181 lbs/(82kg)" },
                    { 32, 22, "Courcouronnes, France", 61, "Arthur", "6'1\"/(185cm)", "Fils", 11, "183 lbs/(83kg)" },
                    { 33, 38, "Soisy-sous-Montmorency, France", 61, "Adrian", "6'0\"/(183cm)", "Mannarino", 83, "174 lbs/(79kg)" },
                    { 34, 36, "Warstein, Germany", 65, "Jan-Lennard", "6'4\"/(193cm)", "Struff", 59, "203 lbs/(92kg)" },
                    { 35, 32, "Sydney, Australia", 9, "Jordan", "6'0\"/(183cm)", "Thompson", 37, "181 lbs/(82kg)" },
                    { 36, 29, "Maia, Portugal", 141, "Nuno", "6'1\"/(185cm)", "Borges", 51, "165 lbs/(75kg)" },
                    { 37, 26, "Budapest, Hungary", 76, "Fabian", "6'4\"/(193cm)", "Marozsan", 63, "165 lbs/(75kg)" },
                    { 38, 27, "Sydney, Australia", 9, "Alexei", "6'5\"/(196cm)", "Popyrin", 27, "172 lbs/(78kg)" },
                    { 39, 25, "Sanremo, Italy", 84, "Matteo", "5'11\"/(180cm)", "Arnaldi", 38, "157 lbs/(71kg)" },
                    { 40, 23, "Lyon, France", 61, "Giovanni", "6'8\"/(203cm)", "Mpetshi Perricard", 108, "216 lbs/(98kg)" },
                    { 41, 28, "Voorhees, New Jersey, USA", 187, "Tommy", "6'1\"/(185cm)", "Paul", 18, "180 lbs/(82kg)" },
                    { 42, 31, "Turin, Italy", 84, "Lorenzo", "6'3\"/(191cm)", "Sonego", 87, "169 lbs/(77kg)" },
                    { 43, 29, "Zagreb, Croatia", 42, "Borna", "6'1\"/(185cm)", "Coric", 93, "179 lbs/(81kg)" },
                    { 44, 26, "Malaga, Spain", 165, "Alejandro", "6'0\"/(183cm)", "Davidovich Fokina", 26, "176 lbs/(80kg)" },
                    { 45, 30, "Senta, Serbia", 154, "Laslo", "6'1\"/(185cm)", "Djere", 110, "174 lbs/(79kg)" },
                    { 46, 28, "Podolsk, Russia", 144, "Roman", "6'1\"/(185cm)", "Safiullin", 79, "172 lbs/(78kg)" },
                    { 47, 28, "Paris, France", 187, "Maxime", "6'7\"/(201cm)", "Cressy", 194, "207 lbs/(94kg)" },
                    { 48, 27, "Helsinki, Finland", 60, "Emil", "188cm", "Ruusuvuori", 85, "165 lbs/(75kg)" },
                    { 49, 38, "Castellon de la Plana, Spain", 165, "Roberto", "6'0\"/(183cm)", "Bautista Agut", 55, "165 lbs/(75kg)" },
                    { 50, 30, "Gassin, France", 61, "Arthur", "6'5\"/(196cm)", "Rinderknech", 33, "187 lbs/(85kg)" },
                    { 51, 35, "Belgrade, Serbia", 154, "Dušan", "6'0\"/(183cm)", "Lajović", 78, "176 lbs/(80kg)" },
                    { 52, 27, "Kempen, Germany", 65, "Daniel", "6'3\"/(191cm)", "Altmaier", 67, "170 lbs/(77kg)" },
                    { 53, 27, "Moscow, Russia", 144, "Pavel", "6'4\"/(193cm)", "Kotov", 98, "185 lbs/(84kg)" },
                    { 54, 26, "Marechal Candido Rondon, Brazil", 24, "Thiago", "6'0\"/(183cm)", "Seyboth Wild", 74, "174 lbs/(79kg)" },
                    { 55, 32, "Thousand Oaks, California, USA", 187, "Marcos", "5'11\"/(180cm)", "Giron", 88, "160 lbs/(73kg)" },
                    { 56, 30, "Sydney, Australia", 9, "Aleksandar", "6'2\"/(188cm)", "Vukic", 115, "172 lbs/(78kg)" },
                    { 57, 29, "Atlanta, Georgia, USA", 187, "Christopher", "6'7\"/(201cm)", "Eubanks", 145, "180 lbs/(82kg)" },
                    { 58, 30, "Tsu, Mie, Japan", 86, "Yoshihito", "5'7\"/(170cm)", "Nishioka", 70, "141 lbs/(64kg)" },
                    { 59, 32, "Furtwangen, Germany", 65, "Dominik", "5'11\"/(180cm)", "Koepfer", 82, "172 lbs/(78kg)" },
                    { 60, 30, "Wageningen, Netherlands", 123, "Botic", "6'3\"/(191cm)", "van de Zandschulp", 41, "185 lbs/(84kg)" },
                    { 61, 26, "Belgrade, Serbia", 154, "Miomir", "6'0\"/(183cm)", "Kecmanović", 61, "170 lbs/(77kg)" },
                    { 62, 29, "Haarlem, Netherlands", 123, "Tallon", "6'2\"/(188cm)", "Griekspoor", 58, "183 lbs/(83kg)" },
                    { 63, 24, "Florence, Italy", 84, "Flavio", "6'0\"/(183cm)", "Cobolli", 7, "165 lbs/(75kg)" },
                    { 64, 25, "9 de Julio, Argentina", 7, "Mariano", "5'9\"/(175cm)", "Navone", 47, "160 lbs/(73kg)" },
                    { 65, 24, "San Diego, California, USA", 187, "Brandon", "6'1\"/(185cm)", "Nakashima", 19, "170 lbs/(77kg)" },
                    { 66, 33, "New York, New York, USA", 86, "Taro", "6'3\"/(191cm)", "Daniel", 90, "170 lbs/(77kg)" },
                    { 67, 33, "Tenerife, Spain", 165, "Roberto", "6'0\"/(183cm)", "Carballés Baena", 64, "165 lbs/(75kg)" },
                    { 68, 29, "Santanyi, Spain", 165, "Jaume", "6'0\"/(183cm)", "Munar", 49, "165 lbs/(75kg)" },
                    { 69, 21, "Laguna Hills, California, USA", 187, "Alex", "6'4\"/(193cm)", "Michelsen", 35, "170 lbs/(77kg)" },
                    { 70, 27, "New York, New York, USA", 187, "Aleksandar", "6'0\"/(183cm)", "Kovacevic", 81, "174 lbs/(79kg)" },
                    { 71, 28, "Sydney, Australia", 9, "Max", "6'1\"/(185cm)", "Purcell", 91, "157 lbs/(71kg)" },
                    { 72, 30, "Adelaide, Australia", 9, "Thanasi", "6'4\"/(193cm)", "Kokkinakis", 75, "185 lbs/(84kg)" },
                    { 73, 25, "Sydney, Australia", 9, "Rinky", "5'10\"/(178cm)", "Hijikata", 85, "152 lbs/(69kg)" },
                    { 74, 34, "Sydney, Australia", 9, "James", "6'0\"/(183cm)", "Duckworth", 64, "176 lbs/(80kg)" },
                    { 75, 24, "Villa Gesell, Argentina", 84, "Luciano", "6'1\"/(185cm)", "Darderi", 21, "172 lbs/(78kg)" },
                    { 76, 24, "Montreal, Canada", 32, "Gabriel", "6'8\"/(203cm)", "Diallo", 121, "212 lbs/(96kg)" },
                    { 77, 25, "La Plata, Argentina", 7, "Thiago Agustín", "6'2\"/(188cm)", "Tirante", 54, "172 lbs/(78kg)" },
                    { 78, 29, "Bondy, France", 61, "Quentin", "6'4\"/(193cm)", "Halys", 48, "180 lbs/(82kg)" },
                    { 79, 25, "Haarlem, Netherlands", 123, "Jesper", "5'11\"/(180cm)", "de Jong", 95, "159 lbs/(72kg)" },
                    { 80, 31, "Nottingham, United Kingdom", 186, "Billy", "6'2\"/(188cm)", "Harris", 105, "176 lbs/(80kg)" }
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "CourtEnvironment", "CourtName", "CourtSurface", "DateTime", "FirstPlayerId", "MatchRound", "MatchStatus", "ScoreResult", "SecondPlayerId", "TournamentId", "VenueId", "WinnerId" },
                values: new object[,]
                {
                    { 1, 1, "Centre Court", "Grass", new DateTime(2026, 7, 12, 15, 0, 0, 0, DateTimeKind.Utc), 1, "Final", "Completed", "6-4 6-7 7-6 6-3", 2, 1, 1, 1 },
                    { 2, 1, "Court No. 1", "Grass", new DateTime(2026, 7, 10, 14, 30, 0, 0, DateTimeKind.Utc), 3, "Semifinal", "Completed", "6-3 6-2 6-4", 4, 1, 1, 3 },
                    { 3, 1, "Court Philippe-Chatrier", "Clay", new DateTime(2026, 6, 7, 16, 0, 0, 0, DateTimeKind.Utc), 5, "Final", "Completed", "6-1 6-3 4-6 5-7 6-2", 6, 2, 2, 5 },
                    { 4, 1, "Court Suzanne-Lenglen", "Clay", new DateTime(2026, 6, 5, 13, 0, 0, 0, DateTimeKind.Utc), 1, "Quarterfinal", "Completed", "7-5 6-4 6-2", 4, 2, 2, 1 },
                    { 5, 1, "Arthur Ashe Stadium", "Hard", new DateTime(2026, 9, 13, 20, 0, 0, 0, DateTimeKind.Utc), 2, "Final", "Completed", "6-3 3-6 6-3 7-6", 3, 3, 3, 2 },
                    { 6, 1, "Louis Armstrong Stadium", "Hard", new DateTime(2026, 9, 11, 18, 0, 0, 0, DateTimeKind.Utc), 5, "Semifinal", "Completed", "6-4 6-4 6-3", 1, 3, 3, 5 },
                    { 7, 0, "Center Court 1", "Hard", new DateTime(2026, 10, 21, 14, 0, 0, 0, DateTimeKind.Utc), 6, "FourthRound", "InProgress", "6-3 4-5", 2, 4, 4, null },
                    { 8, 0, "Court 2", "Hard", new DateTime(2026, 10, 21, 16, 30, 0, 0, DateTimeKind.Utc), 3, "FourthRound", "Scheduled", null, 5, 4, 4, null },
                    { 9, 0, "Center Court 1", "Hard", new DateTime(2026, 10, 22, 11, 0, 0, 0, DateTimeKind.Utc), 4, "Quarterfinal", "Scheduled", null, 6, 4, 4, null },
                    { 10, 0, "Court 3", "Hard", new DateTime(2026, 10, 10, 21, 10, 0, 0, DateTimeKind.Utc), 1, "FourthRound", "Cancelled", null, 3, 4, 4, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Coaches_PlayerId",
                table: "Coaches",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_FirstPlayerId",
                table: "Matches",
                column: "FirstPlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_SecondPlayerId",
                table: "Matches",
                column: "SecondPlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TournamentId",
                table: "Matches",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_VenueId",
                table: "Matches",
                column: "VenueId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_WinnerId",
                table: "Matches",
                column: "WinnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_CountryId",
                table: "Players",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentVenues_VenueId",
                table: "TournamentVenues",
                column: "VenueId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Coaches");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "TournamentVenues");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Tournaments");

            migrationBuilder.DropTable(
                name: "Venues");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
