using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TennisScores.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDataPlayersAndCountries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Country",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 187);
        }
    }
}
