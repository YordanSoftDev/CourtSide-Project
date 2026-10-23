namespace CourtSide.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using CourtSide.Data.Models;
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public static IEnumerable<Player> MensPlayers =>
             new List<Player>
             {
                 new Player
                 {
                     Id = 1,
                     FirstName = "Novak",
                     LastName = "Djokovic",
                     Age = 39,
                     Weight = "170 lbs/(77kg)",
                     Height = "6'2\"/(188cm)",
                     CountryId = 154, // Serbia
                     Birthplace = "Belgrade, Serbia",
                     Rank = 12,
                     Points = 3090,
                     TournamentsPlayed = 14
                 },
                 new Player
                 {
                     Id = 2,
                     FirstName = "Carlos",
                     LastName = "Alcaraz",
                     Age = 23,
                     Weight = "163 lbs/(74kg)",
                     Height = "6'0\"/(183cm)",
                     CountryId = 165, // Spain
                     Birthplace = "El Palmar, Murcia, Spain",
                     Rank = 3,
                     Points = 5610,
                     TournamentsPlayed = 18
                 },
                 new Player
                 {
                     Id = 3,
                     FirstName = "Jannik",
                     LastName = "Sinner",
                     Age = 25,
                     Weight = "168 lbs/(76kg)",
                     Height = "6'3\"/(191cm)",
                     CountryId = 84, // Italy
                     Birthplace = "Innichen, Italy",
                     Rank = 1,
                     Points = 10450,
                     TournamentsPlayed = 20
                 },
                 new Player
                 {
                     Id = 4,
                     FirstName = "Daniil",
                     LastName = "Medvedev",
                     Age = 30,
                     Weight = "183 lbs/(83kg)",
                     Height = "6'6\"/(198cm)",
                     CountryId = 114, // Monaco
                     Birthplace = "Moscow, Russia",
                     Rank = 5,
                     Points = 3620,
                     TournamentsPlayed = 21
                 },
                 new Player
                 {
                     Id = 5,
                     FirstName = "Alexander",
                     LastName = "Zverev",
                     Age = 29,
                     Weight = "198 lbs/(90kg)",
                     Height = "6'6\"/(198cm)",
                     CountryId = 65, // Germany
                     Birthplace = "Hamburg, Germany",
                     Rank = 2,
                     Points = 9750,
                     TournamentsPlayed = 22
                 },
                 new Player
                 {
                     Id = 6,
                     FirstName = "Grigor",
                     LastName = "Dimitrov",
                     Age = 35,
                     Weight = "178 lbs/(80kg)",
                     Height = "6'3\"/(191cm)",
                     CountryId = 26, // Bulgaria
                     Birthplace = "Haskovo, Bulgaria",
                     Rank = 124,
                     Points = 472,
                     TournamentsPlayed = 16
                 },
                 new Player
                 {
                     Id = 7,
                     FirstName = "Stefanos",
                     LastName = "Tsitsipas",
                     Age = 28,
                     Weight = "198 lbs/(90kg)",
                     Height = "6'4\"/(193cm)",
                     CountryId = 67, // Greece
                     Birthplace = "Athens, Greece",
                     Rank = 35,
                     Points = 1380,
                     TournamentsPlayed = 23
                 },
                 new Player
                 {
                     Id = 8,
                     FirstName = "Casper",
                     LastName = "Ruud",
                     Age = 27,
                     Weight = "178 lbs/(81kg)",
                     Height = "6'0\"/(183cm)",
                     CountryId = 130, // Norway
                     Birthplace = "Oslo, Norway",
                     Rank = 25,
                     Points = 1995,
                     TournamentsPlayed = 25
                 },
                 new Player
                 {
                     Id = 10,
                     FirstName = "Taylor",
                     LastName = "Fritz",
                     Age = 28,
                     Weight = "185 lbs/(84kg)",
                     Height = "6'5\"/(196cm)",
                     CountryId = 187, // United States of America
                     Birthplace = "Rancho Santa Fe, California, USA",
                     Rank = 13,
                     Points = 2830,
                     TournamentsPlayed = 22
                 },
                 new Player
                 {
                     Id = 11,
                     FirstName = "Alex",
                     LastName = "de Minaur",
                     Age = 27,
                     Weight = "152 lbs/(69kg)",
                     Height = "6'0\"/(183cm)",
                     CountryId = 9, // Australia
                     Birthplace = "Sydney, Australia",
                     Rank = 10,
                     Points = 3280,
                     TournamentsPlayed = 21
                 },
                 new Player
                 {
                     Id = 12,
                     FirstName = "Andrey",
                     LastName = "Rublev",
                     Age = 29,
                     Weight = "165 lbs/(75kg)",
                     Height = "6'2\"/(188cm)",
                     CountryId = 144, // Russia
                     Birthplace = "Moscow, Russia",
                     Rank = 22,
                     Points = 2175,
                     TournamentsPlayed = 24
                 },
                 new Player
                 {
                     Id = 13,
                     FirstName = "Hubert",
                     LastName = "Hurkacz",
                     Age = 29,
                     Weight = "179 lbs/(81kg)",
                     Height = "6'5\"/(196cm)",
                     CountryId = 140, // Poland
                     Birthplace = "Wroclaw, Poland",
                     Rank = 28,
                     Points = 1585,
                     TournamentsPlayed = 20
                 },
                 new Player
                 {
                     Id = 14,
                     FirstName = "Ben",
                     LastName = "Shelton",
                     Age = 24,
                     Weight = "195 lbs/(88kg)",
                     Height = "6'4\"/(193cm)",
                     CountryId = 187, // United States of America
                     Birthplace = "Atlanta, Georgia, USA",
                     Rank = 4,
                     Points = 4680,
                     TournamentsPlayed = 23
                 },
                 new Player
                 {
                     Id = 15,
                     FirstName = "Frances",
                     LastName = "Tiafoe",
                     Age = 28,
                     Weight = "190 lbs/(86kg)",
                     Height = "6'2\"/(188cm)",
                     CountryId = 187, // United States of America
                     Birthplace = "Hyattsville, Maryland, USA",
                     Rank = 8,
                     Points = 3380,
                     TournamentsPlayed = 24
                 },
                 new Player
                 {
                     Id = 16,
                     FirstName = "Ugo",
                     LastName = "Humbert",
                     Age = 28,
                     Weight = "161 lbs/(73kg)",
                     Height = "6'2\"/(188cm)",
                     CountryId = 61, // France
                     Birthplace = "Metz, France",
                     Rank = 38,
                     Points = 1270,
                     TournamentsPlayed = 22
                 },
                 new Player
                 {
                     Id = 17,
                     FirstName = "Sebastian",
                     LastName = "Korda",
                     Age = 26,
                     Weight = "175 lbs/(79kg)",
                     Height = "6'5\"/(196cm)",
                     CountryId = 187, // United States of America
                     Birthplace = "Bradenton, Florida, USA",
                     Rank = 81,
                     Points = 730,
                     TournamentsPlayed = 18
                 },
                 new Player
                 {
                     Id = 18,
                     FirstName = "Lorenzo",
                     LastName = "Musetti",
                     Age = 24,
                     Weight = "165 lbs/(75kg)",
                     Height = "6'1\"/(185cm)",
                     CountryId = 84, // Italy
                     Birthplace = "Carrara, Italy",
                     Rank = 27,
                     Points = 1720,
                     TournamentsPlayed = 26
                 },
                 new Player
                 {
                     Id = 19,
                     FirstName = "Jack",
                     LastName = "Draper",
                     Age = 24,
                     Weight = "187 lbs/(85kg)",
                     Height = "6'4\"/(193cm)",
                     CountryId = 186, // United Kingdom
                     Birthplace = "Sutton, London, United Kingdom",
                     Rank = 157,
                     Points = 360,
                     TournamentsPlayed = 17
                 },
                 new Player
                 {
                     Id = 20,
                     FirstName = "Felix",
                     LastName = "Auger-Aliassime",
                     Age = 26,
                     Weight = "194 lbs/(88kg)",
                     Height = "6'4\"/(193cm)",
                     CountryId = 32, // Canada
                     Birthplace = "Montreal, Canada",
                     Rank = 7,
                     Points = 3515,
                     TournamentsPlayed = 21
                 },
                 new Player
                 {
                     Id = 21,
                     FirstName = "Francisco",
                     LastName = "Comesana",
                     Age = 26,
                     Weight = "165 lbs/(75kg)",
                     Height = "5'10\"/(178cm)",
                     CountryId = 7, // Argentina
                     Birthplace = "Mar del Plata, Argentina",
                     Rank = 128,
                     Points = 455,
                     TournamentsPlayed = 15
                 },
                 new Player
                 {
                     Id = 22,
                     FirstName = "Cameron",
                     LastName = "Norrie",
                     Age = 31,
                     Weight = "180 lbs/(82kg)",
                     Height = "6'2\"/(188cm)",
                     CountryId = 186, // United Kingdom
                     Birthplace = "Johannesburg, South Africa",
                     Rank = 41,
                     Points = 1195,
                     TournamentsPlayed = 20
                 },
                 new Player
                 {
                     Id = 23,
                     FirstName = "Stan",
                     LastName = "Wawrinka",
                     Age = 41,
                     Weight = "179 lbs/(81kg)",
                     Height = "6'0\"/(183cm)",
                     CountryId = 170, // Switzerland
                     Birthplace = "Lausanne, Switzerland",
                     Rank = 148,
                     Points = 376,
                     TournamentsPlayed = 14
                 },
                 new Player
                 {
                     Id = 25,
                     FirstName = "Matteo",
                     LastName = "Berrettini",
                     Age = 30,
                     Weight = "210 lbs/(95kg)",
                     Height = "6'5\"/(196cm)",
                     CountryId = 84, // Italy
                     Birthplace = "Rome, Italy",
                     Rank = 46,
                     Points = 1083,
                     TournamentsPlayed = 16
                 },
                 new Player
                 {
                     Id = 26,
                     FirstName = "Karen",
                     LastName = "Khachanov",
                     Age = 30,
                     Weight = "192 lbs/(87kg)",
                     Height = "6'6\"/(198cm)",
                     CountryId = 144, // Russia
                     Birthplace = "Moscow, Russia",
                     Rank = 24,
                     Points = 2005,
                     TournamentsPlayed = 22
                 },
                 new Player
                 {
                     Id = 27,
                     FirstName = "Sebastian",
                     LastName = "Baez",
                     Age = 25,
                     Weight = "154 lbs/(70kg)",
                     Height = "5'7\"/(170cm)",
                     CountryId = 7, // Argentina
                     Birthplace = "Buenos Aires, Argentina",
                     Rank = 48,
                     Points = 1044,
                     TournamentsPlayed = 24
                 },
                 new Player
                 {
                     Id = 28,
                     FirstName = "Francisco",
                     LastName = "Cerundolo",
                     Age = 28,
                     Weight = "172 lbs/(78kg)",
                     Height = "6'1\"/(185cm)",
                     CountryId = 7, // Argentina
                     Birthplace = "Buenos Aires, Argentina",
                     Rank = 19,
                     Points = 2260,
                     TournamentsPlayed = 23
                 },
                 new Player
                 {
                     Id = 29,
                     FirstName = "Alejandro",
                     LastName = "Tabilo",
                     Age = 29,
                     Weight = "165 lbs/(75kg)",
                     Height = "6'2\"/(188cm)",
                     CountryId = 35, // Chile
                     Birthplace = "Toronto, Canada",
                     Rank = 30,
                     Points = 1565,
                     TournamentsPlayed = 21
                 },
                 new Player
                 {
                     Id = 31,
                     FirstName = "Tomas Martin",
                     LastName = "Etcheverry",
                     Age = 27,
                     Weight = "181 lbs/(82kg)",
                     Height = "6'5\"/(196cm)",
                     CountryId = 7, // Argentina
                     Birthplace = "La Plata, Argentina",
                     Rank = 29,
                     Points = 1565,
                     TournamentsPlayed = 25
                 },
                 new Player
                 {
                     Id = 32,
                     FirstName = "Arthur",
                     LastName = "Fils",
                     Age = 22,
                     Weight = "183 lbs/(83kg)",
                     Height = "6'1\"/(185cm)",
                     CountryId = 61, // France
                     Birthplace = "Courcouronnes, France",
                     Rank = 9,
                     Points = 3375,
                     TournamentsPlayed = 23
                 },
                 new Player
                 {
                     Id = 33,
                     FirstName = "Adrian",
                     LastName = "Mannarino",
                     Age = 38,
                     Weight = "174 lbs/(79kg)",
                     Height = "6'0\"/(183cm)",
                     CountryId = 61, // France
                     Birthplace = "Soisy-sous-Montmorency, France",
                     Rank = 73,
                     Points = 783,
                     TournamentsPlayed = 27
                 },
                 new Player
                 {
                     Id = 34,
                     FirstName = "Jan-Lennard",
                     LastName = "Struff",
                     Age = 36,
                     Weight = "203 lbs/(92kg)",
                     Height = "6'4\"/(193cm)",
                     CountryId = 65, // Germany
                     Birthplace = "Warstein, Germany",
                     Rank = 54,
                     Points = 969,
                     TournamentsPlayed = 19
                 },
                 new Player
                 {
                     Id = 36,
                     FirstName = "Nuno",
                     LastName = "Borges",
                     Age = 29,
                     Weight = "165 lbs/(75kg)",
                     Height = "6'1\"/(185cm)",
                     CountryId = 141, // Portugal
                     Birthplace = "Maia, Portugal",
                     Rank = 51,
                     Points = 1000,
                     TournamentsPlayed = 22
                 },
                 new Player
                 {
                     Id = 37,
                     FirstName = "Fabian",
                     LastName = "Marozsan",
                     Age = 27,
                     Weight = "165 lbs/(75kg)",
                     Height = "6'4\"/(193cm)",
                     CountryId = 76, // Hungary
                     Birthplace = "Budapest, Hungary",
                     Rank = 61,
                     Points = 860,
                     TournamentsPlayed = 21
                 },
                 new Player
                 {
                     Id = 38,
                     FirstName = "Alexei",
                     LastName = "Popyrin",
                     Age = 27,
                     Weight = "172 lbs/(78kg)",
                     Height = "6'5\"/(196cm)",
                     CountryId = 9, // Australia
                     Birthplace = "Sydney, Australia",
                     Rank = 127,
                     Points = 458,
                     TournamentsPlayed = 21
                 },
                 new Player
                 {
                     Id = 39,
                     FirstName = "Matteo",
                     LastName = "Arnaldi",
                     Age = 25,
                     Weight = "157 lbs/(71kg)",
                     Height = "5'11\"/(180cm)",
                     CountryId = 84, // Italy
                     Birthplace = "Sanremo, Italy",
                     Rank = 36,
                     Points = 1311,
                     TournamentsPlayed = 24
                 },
                 new Player
                 {
                     Id = 40,
                     FirstName = "Giovanni",
                     LastName = "Mpetshi Perricard",
                     Age = 23,
                     Weight = "216 lbs/(98kg)",
                     Height = "6'8\"/(203cm)",
                     CountryId = 61, // France
                     Birthplace = "Lyon, France",
                     Rank = 146,
                     Points = 385,
                     TournamentsPlayed = 18
                 },
                 new Player
                 {
                     Id = 41,
                     FirstName = "Tommy",
                     LastName = "Paul",
                     Age = 29,
                     Weight = "180 lbs/(82kg)",
                     Height = "6'1\"/(185cm)",
                     CountryId = 187, // United States of America
                     Birthplace = "Voorhees, New Jersey, USA",
                     Rank = 14,
                     Points = 2625,
                     TournamentsPlayed = 22
                 },
                 new Player
                 {
                     Id = 42,
                     FirstName = "Lorenzo",
                     LastName = "Sonego",
                     Age = 31,
                     Weight = "169 lbs/(77kg)",
                     Height = "6'3\"/(191cm)",
                     CountryId = 84, // Italy
                     Birthplace = "Turin, Italy",
                     Rank = 90,
                     Points = 658,
                     TournamentsPlayed = 25
                 },
                 new Player
                 {
                     Id = 44,
                     FirstName = "Alejandro",
                     LastName = "Davidovich Fokina",
                     Age = 27,
                     Weight = "176 lbs/(80kg)",
                     Height = "6'0\"/(183cm)",
                     CountryId = 165, // Spain
                     Birthplace = "Malaga, Spain",
                     Rank = 15,
                     Points = 2610,
                     TournamentsPlayed = 23
                 },
                 new Player
                 {
                     Id = 45,
                     FirstName = "Laslo",
                     LastName = "Djere",
                     Age = 31,
                     Weight = "174 lbs/(79kg)",
                     Height = "6'1\"/(185cm)",
                     CountryId = 154, // Serbia
                     Birthplace = "Senta, Serbia",
                     Rank = 136,
                     Points = 412,
                     TournamentsPlayed = 17
                 },
                 new Player
                 {
                     Id = 46,
                     FirstName = "Roman",
                     LastName = "Safiullin",
                     Age = 29,
                     Weight = "172 lbs/(78kg)",
                     Height = "6'1\"/(185cm)",
                     CountryId = 144, // Russia
                     Birthplace = "Podolsk, Russia",
                     Rank = 69,
                     Points = 807,
                     TournamentsPlayed = 22
                 },
                 new Player
                 {
                     Id = 50,
                     FirstName = "Arthur",
                     LastName = "Rinderknech",
                     Age = 31,
                     Weight = "187 lbs/(85kg)",
                     Height = "6'5\"/(196cm)",
                     CountryId = 61, // France
                     Birthplace = "Gassin, France",
                     Rank = 60,
                     Points = 870,
                     TournamentsPlayed = 25
                 },
                 new Player
                 {
                     Id = 52,
                     FirstName = "Daniel",
                     LastName = "Altmaier",
                     Age = 28,
                     Weight = "170 lbs/(77kg)",
                     Height = "6'3\"/(191cm)",
                     CountryId = 65, // Germany
                     Birthplace = "Kempen, Germany",
                     Rank = 62,
                     Points = 849,
                     TournamentsPlayed = 24
                 },
                 new Player
                 {
                     Id = 53,
                     FirstName = "Pavel",
                     LastName = "Kotov",
                     Age = 27,
                     Weight = "185 lbs/(84kg)",
                     Height = "6'4\"/(193cm)",
                     CountryId = 144, // Russia
                     Birthplace = "Moscow, Russia",
                     Rank = 169,
                     Points = 339,
                     TournamentsPlayed = 22
                 },
                 new Player
                 {
                     Id = 54,
                     FirstName = "Thiago",
                     LastName = "Seyboth Wild",
                     Age = 26,
                     Weight = "174 lbs/(79kg)",
                     Height = "6'0\"/(183cm)",
                     CountryId = 24, // Brazil
                     Birthplace = "Marechal Candido Rondon, Brazil",
                     Rank = 110,
                     Points = 545,
                     TournamentsPlayed = 21
                 },
                 new Player
                 {
                     Id = 55,
                     FirstName = "Marcos",
                     LastName = "Giron",
                     Age = 33,
                     Weight = "160 lbs/(73kg)",
                     Height = "5'11\"/(180cm)",
                     CountryId = 187, // United States of America
                     Birthplace = "Thousand Oaks, California, USA",
                     Rank = 87,
                     Points = 676,
                     TournamentsPlayed = 25
                 },
                 new Player
                 {
                     Id = 56,
                     FirstName = "Aleksandar",
                     LastName = "Vukic",
                     Age = 30,
                     Weight = "172 lbs/(78kg)",
                     Height = "6'2\"/(188cm)",
                     CountryId = 9, // Australia
                     Birthplace = "Sydney, Australia",
                     Rank = 116,
                     Points = 507,
                     TournamentsPlayed = 23
                 },
                 new Player
                 {
                     Id = 60,
                     FirstName = "Botic",
                     LastName = "van de Zandschulp",
                     Age = 31,
                     Weight = "185 lbs/(84kg)",
                     Height = "6'3\"/(191cm)",
                     CountryId = 123, // Netherlands
                     Birthplace = "Wageningen, Netherlands",
                     Rank = 37,
                     Points = 1295,
                     TournamentsPlayed = 24
                 },
                 new Player
                 {
                     Id = 61,
                     FirstName = "Miomir",
                     LastName = "Kecmanović",
                     Age = 27,
                     Weight = "170 lbs/(77kg)",
                     Height = "6'0\"/(183cm)",
                     CountryId = 154, // Serbia
                     Birthplace = "Belgrade, Serbia",
                     Rank = 161,
                     Points = 353,
                     TournamentsPlayed = 25
                 },
                 new Player
                 {
                     Id = 62,
                     FirstName = "Tallon",
                     LastName = "Griekspoor",
                     Age = 30,
                     Weight = "183 lbs/(83kg)",
                     Height = "6'2\"/(188cm)",
                     CountryId = 123, // Netherlands
                     Birthplace = "Haarlem, Netherlands",
                     Rank = 65,
                     Points = 835,
                     TournamentsPlayed = 26
                 },
                 new Player
                 {
                     Id = 63,
                     FirstName = "Flavio",
                     LastName = "Cobolli",
                     Age = 24,
                     Weight = "165 lbs/(75kg)",
                     Height = "6'0\"/(183cm)",
                     CountryId = 84, // Italy
                     Birthplace = "Florence, Italy",
                     Rank = 6,
                     Points = 3590,
                     TournamentsPlayed = 23
                 },
                 new Player
                 {
                     Id = 64,
                     FirstName = "Mariano",
                     LastName = "Navone",
                     Age = 25,
                     Weight = "160 lbs/(73kg)",
                     Height = "5'9\"/(175cm)",
                     CountryId = 7, // Argentina
                     Birthplace = "9 de Julio, Argentina",
                     Rank = 43,
                     Points = 1164,
                     TournamentsPlayed = 22
                 },
                 new Player
                 {
                     Id = 65,
                     FirstName = "Brandon",
                     LastName = "Nakashima",
                     Age = 25,
                     Weight = "170 lbs/(77kg)",
                     Height = "6'1\"/(185cm)",
                     CountryId = 187, // United States of America
                     Birthplace = "San Diego, California, USA",
                     Rank = 17,
                     Points = 2350,
                     TournamentsPlayed = 24
                 },
                 new Player
                 {
                     Id = 66,
                     FirstName = "Taro",
                     LastName = "Daniel",
                     Age = 33,
                     Weight = "170 lbs/(77kg)",
                     Height = "6'3\"/(191cm)",
                     CountryId = 86, // Japan
                     Birthplace = "New York, New York, USA",
                     Rank = 177,
                     Points = 321,
                     TournamentsPlayed = 21
                 },
                   new Player
                 {
                     Id = 67,
                     FirstName = "Roberto",
                     LastName = "Carballés Baena",
                     Age = 33,
                     Weight = "165 lbs/(75kg)",
                     Height = "6'0\"/(183cm)",
                     CountryId = 165, // Spain
                     Birthplace = "Tenerife, Spain",
                     Rank = 64,
                     Points = 835,
                     TournamentsPlayed = 25
                 },
                 new Player
                 {
                     Id = 68,
                     FirstName = "Jaume",
                     LastName = "Munar",
                     Age = 29,
                     Weight = "165 lbs/(75kg)",
                     Height = "6'0\"/(183cm)",
                     CountryId = 165, // Spain
                     Birthplace = "Santanyi, Spain",
                     Rank = 64,
                     Points = 835,
                     TournamentsPlayed = 22
                 },
                 new Player
                 {
                     Id = 69,
                     FirstName = "Alex",
                     LastName = "Michelsen",
                     Age = 21,
                     Weight = "170 lbs/(77kg)",
                     Height = "6'4\"/(193cm)",
                     CountryId = 187, // United States of America
                     Birthplace = "Laguna Hills, California, USA",
                     Rank = 34,
                     Points = 1385,
                     TournamentsPlayed = 24
                 },
                 new Player
                 {
                     Id = 70,
                     FirstName = "Aleksandar",
                     LastName = "Kovacevic",
                     Age = 27,
                     Weight = "174 lbs/(79kg)",
                     Height = "6'0\"/(183cm)",
                     CountryId = 187, // United States of America
                     Birthplace = "New York, New York, USA",
                     Rank = 84,
                     Points = 703,
                     TournamentsPlayed = 23
                 },
                 new Player
                 {
                     Id = 71,
                     FirstName = "Max",
                     LastName = "Purcell",
                     Age = 28,
                     Weight = "157 lbs/(71kg)",
                     Height = "6'1\"/(185cm)",
                     CountryId = 9, // Australia
                     Birthplace = "Sydney, Australia",
                     Rank = 91,
                     Points = 650,
                     TournamentsPlayed = 24
                 },
                 new Player
                 {
                     Id = 72,
                     FirstName = "Thanasi",
                     LastName = "Kokkinakis",
                     Age = 30,
                     Weight = "185 lbs/(84kg)",
                     Height = "6'4\"/(193cm)",
                     CountryId = 9, // Australia
                     Birthplace = "Adelaide, Australia",
                     Rank = 75,
                     Points = 760,
                     TournamentsPlayed = 20
                 },
                 new Player
                 {
                     Id = 73,
                     FirstName = "Rinky",
                     LastName = "Hijikata",
                     Age = 25,
                     Weight = "152 lbs/(69kg)",
                     Height = "5'10\"/(178cm)",
                     CountryId = 9, // Australia
                     Birthplace = "Sydney, Australia",
                     Rank = 85,
                     Points = 689,
                     TournamentsPlayed = 26
                 },
                 new Player
                 {
                     Id = 74,
                     FirstName = "James",
                     LastName = "Duckworth",
                     Age = 34,
                     Weight = "176 lbs/(80kg)",
                     Height = "6'0\"/(183cm)",
                     CountryId = 9, // Australia
                     Birthplace = "Sydney, Australia",
                     Rank = 68,
                     Points = 814,
                     TournamentsPlayed = 25
                 },
                 new Player
                 {
                     Id = 75,
                     FirstName = "Luciano",
                     LastName = "Darderi",
                     Age = 24,
                     Weight = "172 lbs/(78kg)",
                     Height = "6'1\"/(185cm)",
                     CountryId = 84, // Italy
                     Birthplace = "Villa Gesell, Argentina",
                     Rank = 23,
                     Points = 2160,
                     TournamentsPlayed = 26
                 },
                 new Player
                 {
                     Id = 76,
                     FirstName = "Gabriel",
                     LastName = "Diallo",
                     Age = 24,
                     Weight = "212 lbs/(96kg)",
                     Height = "6'8\"/(203cm)",
                     CountryId = 32, // Canada
                     Birthplace = "Montreal, Canada",
                     Rank = 148,
                     Points = 382,
                     TournamentsPlayed = 21
                 },
                 new Player
                 {
                     Id = 77,
                     FirstName = "Thiago Agustín",
                     LastName = "Tirante",
                     Age = 25,
                     Weight = "172 lbs/(78kg)",
                     Height = "6'2\"/(188cm)",
                     CountryId = 7, // Argentina
                     Birthplace = "La Plata, Argentina",
                     Rank = 49,
                     Points = 1024,
                     TournamentsPlayed = 22
                 },
                 new Player
                 {
                     Id = 78,
                     FirstName = "Quentin",
                     LastName = "Halys",
                     Age = 29,
                     Weight = "180 lbs/(82kg)",
                     Height = "6'4\"/(193cm)",
                     CountryId = 61, // France
                     Birthplace = "Bondy, France",
                     Rank = 45,
                     Points = 1127,
                     TournamentsPlayed = 23
                 },
                 new Player
                 {
                     Id = 79,
                     FirstName = "Jesper",
                     LastName = "de Jong",
                     Age = 25,
                     Weight = "159 lbs/(72kg)",
                     Height = "5'11\"/(180cm)",
                     CountryId = 123, // Netherlands
                     Birthplace = "Haarlem, Netherlands",
                     Rank = 100,
                     Points = 591,
                     TournamentsPlayed = 22
                 },
                 new Player
                 {
                     Id = 80,
                     FirstName = "Billy",
                     LastName = "Harris",
                     Age = 31,
                     Weight = "176 lbs/(80kg)",
                     Height = "6'2\"/(188cm)",
                     CountryId = 186, // United Kingdom
                     Birthplace = "Nottingham, United Kingdom",
                     Rank = 105,
                     Points = 568,
                     TournamentsPlayed = 28
                 },
                 new Player
                 {
                     Id = 81,
                     FirstName = "Hamad",
                     LastName = "Medjedovic",
                     Age = 23,
                     Weight = "190 lbs/(86kg)",
                     Height = "6'2\"/(188cm)",
                     CountryId = 154, // Serbia
                     Birthplace = "Novi Pazar, Serbia",
                     Rank = 78,
                     Points = 751,
                     TournamentsPlayed = 19
                 },
                 new Player
                 {
                     Id = 82,
                     FirstName = "Kyrian",
                     LastName = "Jacquet",
                     Age = 25,
                     Weight = "155 lbs/(70kg)",
                     Height = "5'10\"/(178cm)",
                     CountryId = 61, // France
                     Birthplace = "Lyon, France",
                     Rank = 79,
                     Points = 741,
                     TournamentsPlayed = 21
                 },
                 new Player
                 {
                     Id = 83,
                     FirstName = "Clément",
                     LastName = "Tabur",
                     Age = 26,
                     Weight = "160 lbs/(73kg)",
                     Height = "5'8\"/(173cm)",
                     CountryId = 61, // France
                     Birthplace = "Reims, France",
                     Rank = 160,
                     Points = 355,
                     TournamentsPlayed = 22
                 },
                 new Player
                 {
                     Id = 84,
                     FirstName = "Benjamin",
                     LastName = "Bonzi",
                     Age = 30,
                     Weight = "180 lbs/(82kg)",
                     Height = "6'0\"/(183cm)",
                     CountryId = 61, // France
                     Birthplace = "Nîmes, France",
                     Rank = 97,
                     Points = 617,
                     TournamentsPlayed = 24
                 },
                 new Player
                 {
                     Id = 85,
                     FirstName = "Luca",
                     LastName = "Van Assche",
                     Age = 22,
                     Weight = "158 lbs/(72kg)",
                     Height = "5'10\"/(178cm)",
                     CountryId = 61, // France
                     Birthplace = "Woluwe-Saint-Lambert,Belgium",
                     Rank = 47,
                     Points = 1080,
                     TournamentsPlayed = 24
                 },
                 new Player
                 {
                     Id = 86,
                     FirstName = "Titouan",
                     LastName = "Droguet",
                     Age = 25,
                     Weight = "176 lbs/(80kg)",
                     Height = "6'3\"/(191cm)",
                     CountryId = 61, // France
                     Birthplace = "Villeneuve-SaintGeorges,   France",
                     Rank = 72,
                     Points = 801,
                     TournamentsPlayed = 21
                 },
                 new Player
                 {
                     Id = 87,
                     FirstName = "Corentin",
                     LastName = "Moutet",
                     Age = 27,
                     Weight = "156 lbs/(71kg)",
                     Height = "5'11\"/(180cm)",
                     CountryId = 61, // France
                     Birthplace = "Paris, France",
                     Rank = 101,
                     Points = 590,
                     TournamentsPlayed = 20
                 },
                 new Player
                 {
                     Id = 88,
                     FirstName = "Arthur",
                     LastName = "Féry",
                     Age = 24,
                     Weight = "165 lbs/(75kg)",
                     Height = "5'9\"/(175cm)",
                     CountryId = 186, // United Kingdom
                     Birthplace = "Sèvres, France",
                     Rank = 33,
                     Points = 1406,
                     TournamentsPlayed = 19
                 },
                 new Player
                 {
                     Id = 89,
                     FirstName = "Borna",
                     LastName = "Gojo",
                     Age = 28,
                     Weight = "187 lbs/(85kg)",
                     Height = "6'5\"/(196cm)",
                     CountryId = 42, // Croatia
                     Birthplace = "Split, Croatia",
                     Rank = 135,
                     Points = 416,
                     TournamentsPlayed = 16
                 },
                 new Player
                 {
                     Id = 90,
                     FirstName = "Pierre-Hugues",
                     LastName = "Herbert",
                     Age = 35,
                     Weight = "176 lbs/(80kg)",
                     Height = "6'2\"/(188cm)",
                     CountryId = 61, // France
                     Birthplace = "Schiltigheim, France",
                     Rank = 248,
                     Points = 315,
                     TournamentsPlayed = 18
                 },
                 new Player
                 {
                     Id = 91, 
                     FirstName = "Rafael",
                     LastName = "Jodar",
                     Age = 20,
                     Weight = "154 lbs/(70kg)",
                     Height = "6'3\"/(191cm)",
                     CountryId = 165, // Spain
                     Birthplace = "Madrid, Spain",
                     Rank = 11,
                     Points = 2850,
                     TournamentsPlayed = 17
                 },
                 new Player
                 {
                     Id = 92,
                     FirstName = "Arthur",
                     LastName = "Gea",
                     Age = 21,
                     Weight = "165 lbs/(75kg)",
                     Height = "6'1\"/(185cm)",
                     CountryId = 75, // France (FRA)
                     Birthplace = "Hyères, France",
                     Rank = 195,
                     Points = 295,
                     TournamentsPlayed = 22
                 }
             };
                public static IEnumerable<Player> WomensPlayers =>
                    new List<Player>
             {


                 new Player
                 {
                     Id = 1001,
                     FirstName = "Elena",
                     LastName = "Rybakina",
                     Age = 27,
                     Weight = "143 lbs/(65kg)",
                     Height = "6'0\"/(184cm)",
                     CountryId = 113, // Kazakhstan (KAZ)
                     Birthplace = "Moscow, Russia",
                     Rank = 1,
                     Points = 9196,
                     TournamentsPlayed = 20
                 },
                 new Player
                 {
                     Id = 1002,
                     FirstName = "Aryna",
                     LastName = "Sabalenka",
                     Age = 28,
                     Weight = "176 lbs/(80kg)",
                     Height = "6'0\"/(182cm)",
                     CountryId = 16, // Belarus (BLR)
                     Birthplace = "Minsk, Belarus",
                     Rank = 2,
                     Points = 7550,
                     TournamentsPlayed = 20
                 },
                 new Player
                 {
                     Id = 1003,
                     FirstName = "Mirra",
                     LastName = "Andreeva",
                     Age = 19,
                     Weight = "135 lbs/(61kg)",
                     Height = "5'9\"/(175cm)",
                     CountryId = 144, // Russia (RUS)
                     Birthplace = "Krasnoyarsk, Russia",
                     Rank = 3,
                     Points = 6306,
                     TournamentsPlayed = 20
                 },
                 new Player
                 {
                     Id = 1004,
                     FirstName = "Jessica",
                     LastName = "Pegula",
                     Age = 32,
                     Weight = "154 lbs/(70kg)",
                     Height = "5'7\"/(170cm)",
                     CountryId = 187, // UnitedStatesofAmerica    (USA)
                     Birthplace = "Buffalo, New York, USA",
                     Rank = 4,
                     Points = 6235,
                     TournamentsPlayed = 19
                 },
                 new Player
                 {
                     Id = 1005,
                     FirstName = "Coco",
                     LastName = "Gauff",
                     Age = 22,
                     Weight = "141 lbs/(64kg)",
                     Height = "5'9\"/(175cm)",
                     CountryId = 187, // UnitedStatesofAmerica    (USA)
                     Birthplace = "Delray Beach, Florida, USA",
                     Rank = 5,
                     Points = 5974,
                     TournamentsPlayed = 19
                 },
                 new Player
                 {
                     Id = 1006,
                     FirstName = "Elina",
                     LastName = "Svitolina",
                     Age = 32,
                     Weight = "132 lbs/(60kg)",
                     Height = "5'9\"/(174cm)",
                     CountryId = 184, // Ukraine (UKR)
                     Birthplace = "Odesa, Ukraine",
                     Rank = 6,
                     Points = 5229,
                     TournamentsPlayed = 19
                 },
                 new Player
                 {
                     Id = 1007,
                     FirstName = "Karolina",
                     LastName = "Muchova",
                     Age = 30,
                     Weight = "141 lbs/(64kg)",
                     Height = "5'11\"/(180cm)",
                     CountryId = 45, // Czechia (Czech Republic)
                     Birthplace = "Olomouc, Czech Republic",
                     Rank = 7,
                     Points = 4833,
                     TournamentsPlayed = 19
                 },
                 new Player
                 {
                     Id = 1008,
                     FirstName = "Linda",
                     LastName = "Noskova",
                     Age = 21,
                     Weight = "143 lbs/(65kg)",
                     Height = "5'10\"/(179cm)",
                     CountryId = 45, // Czechia (Czech Republic)
                     Birthplace = "Vsetín, Czech Republic",
                     Rank = 8,
                     Points = 4678,
                     TournamentsPlayed = 19
                 },
                 new Player
                 {
                     Id = 1009,
                     FirstName = "Iga",
                     LastName = "Swiatek",
                     Age = 25,
                     Weight = "143 lbs/(65kg)",
                     Height = "5'9\"/(175cm)",
                     CountryId = 140, // Poland (POL)
                     Birthplace = "Warsaw, Poland",
                     Rank = 9,
                     Points = 4389,
                     TournamentsPlayed = 19
                 },
                 new Player
                 {
                     Id = 1010,
                     FirstName = "Marta",
                     LastName = "Kostyuk",
                     Age = 24,
                     Weight = "137 lbs/(62kg)",
                     Height = "5'9\"/(175cm)",
                     CountryId = 184, // Ukraine (UKR)
                     Birthplace = "Kyiv, Ukraine",
                     Rank = 10,
                     Points = 3920,
                     TournamentsPlayed = 18
                 },
                 new Player
                 {
                     Id = 1011,
                     FirstName = "Maja",
                     LastName = "Chwalinska",
                     Age = 25,
                     Weight = "128 lbs/(58kg)",
                     Height = "5'5\"/(165cm)",
                     CountryId = 140, // Poland (POL)
                     Birthplace = "Dąbrowa Górnicza, Poland",
                     Rank = 11,
                     Points = 3031,
                     TournamentsPlayed = 22
                 },
                 new Player
                 {
                     Id = 1012,
                     FirstName = "Iva",
                     LastName = "Jovic",
                     Age = 18,
                     Weight = "130 lbs/(59kg)",
                     Height = "5'8\"/(173cm)",
                     CountryId = 187, // UnitedStatesofAmerica    (USA)
                     Birthplace = "Torrance, California, USA",
                     Rank = 12,
                     Points = 2931,
                     TournamentsPlayed = 22
                 },
                 new Player
                 {
                     Id = 1013,
                     FirstName = "Diana",
                     LastName = "Shnaider",
                     Age = 22,
                     Weight = "143 lbs/(65kg)",
                     Height = "5'8\"/(173cm)",
                     CountryId = 144, // Russia (RUS)
                     Birthplace = "Zhigulyovsk, Russia",
                     Rank = 13,
                     Points = 2663,
                     TournamentsPlayed = 22
                 },
                 new Player
                 {
                     Id = 1014,
                     FirstName = "Belinda",
                     LastName = "Bencic",
                     Age = 29,
                     Weight = "139 lbs/(63kg)",
                     Height = "5'9\"/(175cm)",
                     CountryId = 170, // Switzerland (SUI)
                     Birthplace = "Flawil, Switzerland",
                     Rank = 14,
                     Points = 2662,
                     TournamentsPlayed = 18
                 },
                 new Player
                 {
                     Id = 1015,
                     FirstName = "Elise",
                     LastName = "Mertens",
                     Age = 30,
                     Weight = "148 lbs/(67kg)",
                     Height = "5'10\"/(179cm)",
                     CountryId = 17, // Belgium (BEL)
                     Birthplace = "Leuven, Belgium",
                     Rank = 15,
                     Points = 2540,
                     TournamentsPlayed = 21
                 },
                 new Player
                 {
                     Id = 1016,
                     FirstName = "Victoria",
                     LastName = "Mboko",
                     Age = 20,
                     Weight = "143 lbs/(65kg)",
                     Height = "5'9\"/(176cm)",
                     CountryId = 32, // Canada (CAN)
                     Birthplace = "Charlotte, NorthCarolina,USA",
                     Rank = 16,
                     Points = 2501,
                     TournamentsPlayed = 16
                 },
                 new Player
                 {
                     Id = 1017,
                     FirstName = "Sorana",
                     LastName = "Cirstea",
                     Age = 36,
                     Weight = "130 lbs/(59kg)",
                     Height = "5'9\"/(176cm)",
                     CountryId = 143, // Romania (ROU)
                     Birthplace = "Bucharest, Romania",
                     Rank = 17,
                     Points = 2380,
                     TournamentsPlayed = 21
                 },
                 new Player
                 {
                     Id = 1018,
                     FirstName = "Amanda",
                     LastName = "Anisimova",
                     Age = 25,
                     Weight = "132 lbs/(60kg)",
                     Height = "5'11\"/(180cm)",
                     CountryId = 187, // UnitedStatesofAmerica    (USA)
                     Birthplace = "Freehold, New Jersey, USA",
                     Rank = 18,
                     Points = 2363,
                     TournamentsPlayed = 15
                 },
                 new Player
                 {
                     Id = 1019,
                     FirstName = "Naomi",
                     LastName = "Osaka",
                     Age = 29,
                     Weight = "152 lbs/(69kg)",
                     Height = "5'11\"/(180cm)",
                     CountryId = 86, // Japan (JPN)
                     Birthplace = "Chuo-ku, Osaka, Japan",
                     Rank = 19,
                     Points = 2297,
                     TournamentsPlayed = 18
                 },
                 new Player
                 {
                     Id = 1020,
                     FirstName = "Alexandra",
                     LastName = "Eala",
                     Age = 21,
                     Weight = "132 lbs/(60kg)",
                     Height = "5'9\"/(175cm)",
                     CountryId = 139, // Philippines (PHI)
                     Birthplace = "Quezon City, Philippines",
                     Rank = 20,
                     Points = 2241,
                     TournamentsPlayed = 28
                 },
                 new Player
                 {
                     Id = 1021,
                     FirstName = "Madison",
                     LastName = "Keys",
                     Age = 31,
                     Weight = "145 lbs/(66kg)",
                     Height = "5'10\"/(178cm)",
                     CountryId = 187, // UnitedStatesofAmerica    (USA)
                     Birthplace = "Rock Island, Illinois, USA",
                     Rank = 21,
                     Points = 2029,
                     TournamentsPlayed = 21
                 },
                 new Player
                 {
                     Id = 1022,
                     FirstName = "Qinwen",
                     LastName = "Zheng",
                     Age = 24,
                     Weight = "139 lbs/(63kg)",
                     Height = "5'10\"/(178cm)",
                     CountryId = 36, // China (CHN)
                     Birthplace = "Shiyan, Hubei, China",
                     Rank = 22,
                     Points = 2018,
                     TournamentsPlayed = 18
                 },
                 new Player
                 {
                     Id = 1023,
                     FirstName = "Anna",
                     LastName = "Kalinskaya",
                     Age = 27,
                     Weight = "137 lbs/(62kg)",
                     Height = "5'9\"/(175cm)",
                     CountryId = 144, // Russia (RUS)
                     Birthplace = "Moscow, Russia",
                     Rank = 23,
                     Points = 1989,
                     TournamentsPlayed = 22
                 },
                 new Player
                 {
                     Id = 1024,
                     FirstName = "Jelena",
                     LastName = "Ostapenko",
                     Age = 29,
                     Weight = "141 lbs/(64kg)",
                     Height = "5'10\"/(178cm)",
                     CountryId = 94, // Latvia (LAT)
                     Birthplace = "Riga, Latvia",
                     Rank = 24,
                     Points = 1916,
                     TournamentsPlayed = 21
                 },
                 new Player
                 {
                     Id = 1025,
                     FirstName = "Ann",
                     LastName = "Li",
                     Age = 26,
                     Weight = "135 lbs/(61kg)",
                     Height = "5'7\"/(170cm)",
                     CountryId = 187, // UnitedStatesofAmerica    (USA)
                     Birthplace = "King ofPrussiaPennsylvania,    USA",
                     Rank = 25,
                     Points = 1833,
                     TournamentsPlayed = 27
                 },
                 new Player
                 {
                     Id = 1026,
                     FirstName = "Marie",
                     LastName = "Bouzkova",
                     Age = 28,
                     Weight = "134 lbs/(61kg)",
                     Height = "5'11\"/(180cm)",
                     CountryId = 45, // Czechia (Czech Republic)
                     Birthplace = "Prague, Czech Republic",
                     Rank = 26,
                     Points = 1818,
                     TournamentsPlayed = 23
                 },
                 new Player
                 {
                     Id = 1027,
                     FirstName = "Anastasia",
                     LastName = "Potapova",
                     Age = 25,
                     Weight = "126 lbs/(57kg)",
                     Height = "5'9\"/(175cm)",
                     CountryId = 144, // Russia (RUS)
                     Birthplace = "Saratov, Russia",
                     Rank = 27,
                     Points = 1814,
                     TournamentsPlayed = 21
                 },
                 new Player
                 {
                     Id = 1028,
                     FirstName = "Emma",
                     LastName = "Navarro",
                     Age = 25,
                     Weight = "154 lbs/(70kg)",
                     Height = "5'7\"/(170cm)",
                     CountryId = 187, // UnitedStatesofAmerica    (USA)
                     Birthplace = "New York City, New York,USA",
                     Rank = 28,
                     Points = 1794,
                     TournamentsPlayed = 25
                 },
                 new Player
                 {
                     Id = 1029,
                     FirstName = "Nikola",
                     LastName = "Bartunkova",
                     Age = 20,
                     Weight = "132 lbs/(60kg)",
                     Height = "5'8\"/(173cm)",
                     CountryId = 45, // Czechia (Czech Republic)
                     Birthplace = "Prague, Czech Republic",
                     Rank = 29,
                     Points = 1711,
                     TournamentsPlayed = 23
                 },
                 new Player
                 {
                     Id = 1030,
                     FirstName = "Leylah",
                     LastName = "Fernandez",
                     Age = 24,
                     Weight = "128 lbs/(58kg)",
                     Height = "5'6\"/(168cm)",
                     CountryId = 32, // Canada (CAN)
                     Birthplace = "Montreal, Canada",
                     Rank = 30,
                     Points = 1709,
                     TournamentsPlayed = 28
                 },
                 new Player
                 {
                     Id = 1031,
                     FirstName = "Maria",
                     LastName = "Sakkari",
                     Age = 31,
                     Weight = "138 lbs/(62kg)",
                     Height = "5'8\"/(172cm)",
                     CountryId = 67, // Greece (GRE)
                     Birthplace = "Athens, Greece",
                     Rank = 31,
                     Points = 1706,
                     TournamentsPlayed = 23
                 },
                 new Player
                 {
                     Id = 1032,
                     FirstName = "Sara",
                     LastName = "Bejlek",
                     Age = 20,
                     Weight = "125 lbs/(57kg)",
                     Height = "5'5\"/(165cm)",
                     CountryId = 45, // Czechia (Czech Republic)
                     Birthplace = "Hrušovany nadJevišovkou,   Czech       Republic",
                     Rank = 32,
                     Points = 1650,
                     TournamentsPlayed = 25
                 },
                 new Player
                 {
                     Id = 1033,
                     FirstName = "Ekaterina",
                     LastName = "Alexandrova",
                     Age = 31,
                     Weight = "146 lbs/(66kg)",
                     Height = "5'9\"/(175cm)",
                     CountryId = 144, // Russia (RUS)
                     Birthplace = "Chelyabinsk, Russia",
                     Rank = 33,
                     Points = 1591,
                     TournamentsPlayed = 26
                 },
                 new Player
                 {
                     Id = 1034,
                     FirstName = "Diane",
                     LastName = "Parry",
                     Age = 24,
                     Weight = "132 lbs/(60kg)",
                     Height = "5'7\"/(170cm)",
                     CountryId = 61, // France (FRA)
                     Birthplace = "Nice, France",
                     Rank = 34,
                     Points = 1549,
                     TournamentsPlayed = 27
                 },
                 new Player
                 {
                     Id = 1035,
                     FirstName = "Jasmine",
                     LastName = "Paolini",
                     Age = 30,
                     Weight = "119 lbs/(54kg)",
                     Height = "5'4\"/(163cm)",
                     CountryId = 84, // Italy (ITA)
                     Birthplace = "Castelnuovo diGarfagnana, Italy",
                     Rank = 35,
                     Points = 1453,
                     TournamentsPlayed = 19
                 },
                 new Player
                 {
                     Id = 1036,
                     FirstName = "Donna",
                     LastName = "Vekic",
                     Age = 30,
                     Weight = "141 lbs/(64kg)",
                     Height = "5'10\"/(179cm)",
                     CountryId = 42, // Croatia (CRO)
                     Birthplace = "Osijek, Croatia",
                     Rank = 36,
                     Points = 1333,
                     TournamentsPlayed = 24
                 },
                 new Player
                 {
                     Id = 1037,
                     FirstName = "Peyton",
                     LastName = "Stearns",
                     Age = 25,
                     Weight = "135 lbs/(61kg)",
                     Height = "5'8\"/(173cm)",
                     CountryId = 187, // UnitedStatesofAmerica    (USA)
                     Birthplace = "Cincinnati, Ohio, USA",
                     Rank = 37,
                     Points = 1316,
                     TournamentsPlayed = 23
                 },
                 new Player
                 {
                     Id = 1038,
                     FirstName = "Cristina",
                     LastName = "Bucsa",
                     Age = 28,
                     Weight = "130 lbs/(59kg)",
                     Height = "5'9\"/(175cm)",
                     CountryId = 165, // Spain (ESP)
                     Birthplace = "Chisinau, Moldova",
                     Rank = 38,
                     Points = 1294,
                     TournamentsPlayed = 24
                 },
                 new Player
                 {
                     Id = 1039,
                     FirstName = "Xinyu",
                     LastName = "Wang",
                     Age = 25,
                     Weight = "139 lbs/(63kg)",
                     Height = "6'0\"/(182cm)",
                     CountryId = 36, // China (CHN)
                     Birthplace = "Shenzhen, China",
                     Rank = 39,
                     Points = 1288,
                     TournamentsPlayed = 25
                 },
                 new Player
                 {
                     Id = 1040,
                     FirstName = "Daria",
                     LastName = "Snigur",
                     Age = 24,
                     Weight = "130 lbs/(59kg)",
                     Height = "5'7\"/(170cm)",
                     CountryId = 184, // Ukraine (UKR)
                     Birthplace = "Kyiv, Ukraine",
                     Rank = 40,
                     Points = 1280,
                     TournamentsPlayed = 24
                 },
                 new Player
                 {
                     Id = 1041,
                     FirstName = "Kimberly",
                     LastName = "Birrell",
                     Age = 28,
                     Weight = "132 lbs/(60kg)",
                     Height = "5'7\"/(170cm)",
                     CountryId = 9, // Australia (AUS)
                     Birthplace = "Dusseldorf, Germany",
                     Rank = 41,
                     Points = 1280,
                     TournamentsPlayed = 28
                 },
                 new Player
                 {
                     Id = 1042,
                     FirstName = "Talia",
                     LastName = "Gibson",
                     Age = 22,
                     Weight = "135 lbs/(61kg)",
                     Height = "5'9\"/(175cm)",
                     CountryId = 9, // Australia (AUS)
                     Birthplace = "Perth, Australia",
                     Rank = 42,
                     Points = 1273,
                     TournamentsPlayed = 31
                 },
                 new Player
                 {
                    Id = 1043,
                    FirstName = "Liudmila",
                    LastName = "Samsonova",
                    Age = 27,
                    Weight = "148 lbs/(67kg)",
                    Height = "5'11\"/(180cm)",
                    CountryId = 144, // Russia (RUS)
                    Birthplace = "Olenegorsk, Russia",
                    Rank = 43,
                    Points = 1234,
                    TournamentsPlayed = 25
                 },
                 new Player
                 {
                     Id = 1044,
                     FirstName = "Hailey",
                     LastName = "Baptiste",
                     Age = 24,
                     Weight = "150 lbs/(68kg)",
                     Height = "5'9\"/(175cm)",
                     CountryId = 187, // UnitedStatesofAmerica    (USA)
                     Birthplace = "Washington, D.C., USA",
                     Rank = 44,
                     Points = 1154,
                     TournamentsPlayed = 15
                 },
                 new Player
                 {
                     Id = 1045,
                     FirstName = "Barbora",
                     LastName = "Krejcikova",
                     Age = 30,
                     Weight = "137 lbs/(62kg)",
                     Height = "5'10\"/(178cm)",
                     CountryId = 45, // Czechia (Czech Republic)
                     Birthplace = "Brno, Czech Republic",
                     Rank = 45,
                     Points = 1133,
                     TournamentsPlayed = 20
                 },
                 new Player
                 {
                     Id = 1046,
                     FirstName = "Janice",
                     LastName = "Tjen",
                     Age = 24,
                     Weight = "130 lbs/(59kg)",
                     Height = "5'6\"/(168cm)",
                     CountryId = 79, // Indonesia (INA)
                     Birthplace = "Jakarta, Indonesia",
                     Rank = 46,
                     Points = 1120,
                     TournamentsPlayed = 29
                 },
                 new Player
                 {
                     Id = 1047,
                     FirstName = "Magdalena",
                     LastName = "Frech",
                     Age = 28,
                     Weight = "134 lbs/(61kg)",
                     Height = "5'7\"/(171cm)",
                     CountryId = 140, // Poland (POL)
                     Birthplace = "Łódź, Poland",
                     Rank = 47,
                     Points = 1110,
                     TournamentsPlayed = 23
                 },
                 new Player
                 {
                     Id = 1048,
                     FirstName = "Karolina",
                     LastName = "Pliskova",
                     Age = 34,
                     Weight = "159 lbs/(72kg)",
                     Height = "6'1\"/(186cm)",
                     CountryId = 45, // Czechia (Czech Republic)
                     Birthplace = "Louny, Czech Republic",
                     Rank = 48,
                     Points = 1105,
                     TournamentsPlayed = 15
                 },
                 new Player
                 {
                     Id = 1049,
                     FirstName = "Sonay",
                     LastName = "Kartal",
                     Age = 24,
                     Weight = "132 lbs/(60kg)",
                     Height = "5'7\"/(170cm)",
                     CountryId = 186, // United Kingdom (GBR)
                     Birthplace = "London, United Kingdom",
                     Rank = 49,
                     Points = 1097,
                     TournamentsPlayed = 11
                 },
                 new Player
                 {
                     Id = 1050,
                     FirstName = "Yuliia",
                     LastName = "Starodubtseva",
                     Age = 26,
                     Weight = "135 lbs/(61kg)",
                     Height = "5'8\"/(172cm)",
                     CountryId = 184, // Ukraine (UKR)
                     Birthplace = "Kakhovka, Ukraine",
                     Rank = 50,
                     Points = 1090,
                     TournamentsPlayed = 29
                 },
                 new Player
                 {
                    Id = 1051,
                    FirstName = "Anhelina",
                    LastName = "Kalinina",
                    Age = 29,
                    Weight = "132 lbs/(60kg)",
                    Height = "5'10\"/(179cm)",
                    CountryId = 184, // Ukraine (UKR)
                    Birthplace = "Nova Kakhovka, Ukraine",
                    Rank = 51,
                    Points = 1087,
                    TournamentsPlayed = 24
                 },
                 new Player
                 {
                     Id = 1052,
                     FirstName = "Mayar",
                     LastName = "Sherif",
                     Age = 30,
                     Weight = "137 lbs/(62kg)",
                     Height = "5'11\"/(180cm)",
                     CountryId = 52, // Egypt (EGY)
                     Birthplace = "Cairo, Egypt",
                     Rank = 52,
                     Points = 1085,
                     TournamentsPlayed = 27
                 },
                 new Player
                 {
                     Id = 1053,
                     FirstName = "Lanlana",
                     LastName = "Tararudee",
                     Age = 22,
                     Weight = "132 lbs/(60kg)",
                     Height = "5'8\"/(173cm)",
                     CountryId = 174, // Thailand (THA)
                     Birthplace = "Nakhon Ratchasima, Thailand",
                     Rank = 53,
                     Points = 1080,
                     TournamentsPlayed = 28
                 },
                 new Player
                 {
                     Id = 1054,
                     FirstName = "Clara",
                     LastName = "Tauson",
                     Age = 23,
                     Weight = "150 lbs/(68kg)",
                     Height = "6'0\"/(182cm)",
                     CountryId = 47, // Denmark (DEN)
                     Birthplace = "Copenhagen, Denmark",
                     Rank = 54,
                     Points = 1074,
                     TournamentsPlayed = 24
                 },
                 new Player
                 {
                     Id = 1055,
                    FirstName = "Ashlyn",
                    LastName = "Krueger",
                    Age = 22,
                    Weight = "143 lbs/(65kg)",
                    Height = "6'1\"/(185cm)",
                    CountryId = 187, // United States of America (USA)
                    Birthplace = "Spring, Texas, USA",
                    Rank = 55,
                    Points = 1072,
                    TournamentsPlayed = 23
                 },
                 new Player
                 {
                     Id = 1056,
                     FirstName = "Tamara",
                     LastName = "Korpatsch",
                     Age = 31,
                     Weight = "128 lbs/(58kg)",
                     Height = "5'7\"/(170cm)",
                     CountryId = 65, // Germany (GER)
                     Birthplace = "Hamburg, Germany",
                     Rank = 56,
                     Points = 1070,
                     TournamentsPlayed = 33
                 },
                 new Player
                 {
                     Id = 1057,
                     FirstName = "Lilli",
                     LastName = "Tagger",
                     Age = 18,
                     Weight = "130 lbs/(59kg)",
                     Height = "5'9\"/(175cm)",
                     CountryId = 10, // Austria (AUT)
                     Birthplace = "Lienz, Austria",
                     Rank = 57,
                     Points = 1052,
                     TournamentsPlayed = 22
                 },
                 new Player
                 {
                     Id = 1058,
                     FirstName = "Katie",
                     LastName = "Boulter",
                     Age = 30,
                     Weight = "137 lbs/(62kg)",
                     Height = "5'11\"/(180cm)",
                     CountryId = 186, // United Kingdom (GBR)
                     Birthplace = "Leicester, United Kingdom",
                     Rank = 58,
                     Points = 1042,
                     TournamentsPlayed = 23
                 },
                 new Player
                 {
                     Id = 1059,
                     FirstName = "Caty",
                     LastName = "Mcnally",
                     Age = 24,
                     Weight = "139 lbs/(63kg)",
                     Height = "5'10\"/(178cm)",
                     CountryId = 187, // United States of America    (USA)
                     Birthplace = "Cincinnati, Ohio, USA",
                     Rank = 59,
                     Points = 1035,
                     TournamentsPlayed = 24
                 },
                 new Player
                 {
                     Id = 1060,
                     FirstName = "Elena-Gabriela",
                     LastName = "Ruse",
                     Age = 28,
                     Weight = "132 lbs/(60kg)",
                     Height = "5'8\"/(172cm)",
                     CountryId = 143, // Romania (ROU)
                     Birthplace = "Bucharest, Romania",
                     Rank = 60,
                     Points = 1033,
                     TournamentsPlayed = 24
                 },
                 new Player
                 {
                     Id = 1061,
                     FirstName = "Paula",
                     LastName = "Badosa",
                     Age = 28,
                     Weight = "154 lbs/(70kg)",
                     Height = "5'11\"/(180cm)",
                     CountryId = 165, // Spain (ESP)
                     Birthplace = "New York City, USA",
                     Rank = 61,
                     Points = 1023,
                     TournamentsPlayed = 22
                 },
                 new Player
                 {
                     Id = 1062,
                     FirstName = "Oleksandra",
                     LastName = "Oliynykova",
                     Age = 25,
                     Weight = "130 lbs/(59kg)",
                     Height = "5'8\"/(173cm)",
                     CountryId = 184, // Ukraine (UKR)
                     Birthplace = "Kyiv, Ukraine",
                     Rank = 62,
                     Points = 1022,
                     TournamentsPlayed = 30
                 },
                 new Player
                 {
                     Id = 1063,
                     FirstName = "Zeynep",
                     LastName = "Sonmez",
                     Age = 24,
                     Weight = "128 lbs/(58kg)",
                     Height = "5'7\"/(170cm)",
                     CountryId = 180, // Turkey (TUR)
                     Birthplace = "Istanbul, Turkey",
                     Rank = 63,
                     Points = 987,
                     TournamentsPlayed = 26
                 },
                 new Player
                 {
                     Id = 1064,
                     FirstName = "Alycia",
                     LastName = "Parks",
                     Age = 25,
                     Weight = "143 lbs/(65kg)",
                     Height = "6'1\"/(185cm)",
                     CountryId = 187, // United States of America  (USA)
                     Birthplace = "Atlanta, Georgia, USA",
                     Rank = 64,
                     Points = 985,
                     TournamentsPlayed = 36
                 },
                 new Player
                 {
                     Id = 1065,
                     FirstName = "Elisabetta",
                     LastName = "Cocciaretto",
                     Age = 25,
                     Weight = "123 lbs/(56kg)",
                     Height = "5'5\"/(166cm)",
                     CountryId = 84, // Italy (ITA)
                     Birthplace = "Ancona, Italy",
                     Rank = 65,
                     Points = 975,
                     TournamentsPlayed = 21
                 },
                 new Player
                 {
                     Id = 1066,
                     FirstName = "Yulia",
                     LastName = "Putintseva",
                     Age = 31,
                     Weight = "130 lbs/(59kg)",
                     Height = "5'4\"/(163cm)",
                     CountryId = 88, // Kazakhstan (KAZ)
                     Birthplace = "Moscow, Russia",
                     Rank = 66,
                     Points = 969,
                     TournamentsPlayed = 24
                 },
                 new Player
                 {
                     Id = 1067,
                     FirstName = "Kamilla",
                     LastName = "Rakhimova",
                     Age = 25,
                     Weight = "132 lbs/(60kg)",
                     Height = "5'7\"/(170cm)",
                     CountryId = 189, // Uzbekistan (UZB)
                     Birthplace = "Yekaterinburg, Russia",
                     Rank = 67,
                     Points = 966,
                     TournamentsPlayed = 28
                 },
                 new Player
                 {
                     Id = 1068,
                     FirstName = "Camila",
                     LastName = "Osorio",
                     Age = 24,
                     Weight = "128 lbs/(58kg)",
                     Height = "5'3\"/(160cm)",
                     CountryId = 37, // Colombia (COL)
                     Birthplace = "Cúcuta, Colombia",
                     Rank = 68,
                     Points = 963,
                     TournamentsPlayed = 25
                 },
                 new Player
                 {
                     Id = 1069,
                     FirstName = "Tatjana",
                     LastName = "Maria",
                     Age = 39,
                     Weight = "137 lbs/(62kg)",
                     Height = "5'8\"/(172cm)",
                     CountryId = 65, // Germany (GER)
                     Birthplace = "Bad Saulgau, Germany",
                     Rank = 69,
                     Points = 945,
                     TournamentsPlayed = 32
                 },
                 new Player
                 {
                     Id = 1070,
                     FirstName = "Maria",
                     LastName = "Timofeeva",
                     Age = 22,
                     Weight = "130 lbs/(59kg)",
                     Height = "5'6\"/(167cm)",
                     CountryId = 189, // Uzbekistan (UZB)
                     Birthplace = "Moscow, Russia",
                     Rank = 70,
                     Points = 931,
                     TournamentsPlayed = 25
                 },
                 new Player
                 {
                     Id = 1071,
                     FirstName = "Jaqueline",
                     LastName = "Cristian",
                     Age = 28,
                     Weight = "143 lbs/(65kg)",
                     Height = "5'11\"/(180cm)",
                     CountryId = 143, // Romania (ROU)
                     Birthplace = "Bucharest, Romania",
                     Rank = 71,
                     Points = 928,
                     TournamentsPlayed = 20
                 },
                 new Player
                 {
                     Id = 1072,
                     FirstName = "Anna",
                     LastName = "Blinkova",
                     Age = 28,
                     Weight = "130 lbs/(59kg)",
                     Height = "5'10\"/(179cm)",
                     CountryId = 61, // France (FRA)
                     Birthplace = "Moscow, Russia",
                     Rank = 72,
                     Points = 921,
                     TournamentsPlayed = 32
                 },
                 new Player
                 {
                     Id = 1073,
                     FirstName = "Katie",
                     LastName = "Volynets",
                     Age = 24,
                     Weight = "130 lbs/(59kg)",
                     Height = "5'7\"/(170cm)",
                     CountryId = 187, // United States of America  (USA)
                     Birthplace = "Walnut Creek, California, USA",
                     Rank = 73,
                     Points = 919,
                     TournamentsPlayed = 27
                 },
                 new Player
                 {
                     Id = 1074,
                     FirstName = "Daria",
                     LastName = "Kasatkina",
                     Age = 29,
                     Weight = "137 lbs/(62kg)",
                     Height = "5'7\"/(170cm)",
                     CountryId = 9, // Australia (AUS)
                     Birthplace = "Tolyatti, Russia",
                     Rank = 74,
                     Points = 913,
                     TournamentsPlayed = 25
                 },
                 new Player
                 {
                     Id = 1075,
                     FirstName = "Anna",
                     LastName = "Bondar",
                     Age = 29,
                     Weight = "137 lbs/(62kg)",
                     Height = "5'9\"/(175cm)",
                     CountryId = 76, // Hungary (HUN)
                     Birthplace = "Szeghalom, Hungary",
                     Rank = 75,
                     Points = 913,
                     TournamentsPlayed = 28
                 },
                 new Player
                 {
                     Id = 1076,
                     FirstName = "Sinja",
                     LastName = "Kraus",
                     Age = 24,
                     Weight = "130 lbs/(59kg)",
                     Height = "5'8\"/(172cm)",
                     CountryId = 10, // Austria (AUT)
                     Birthplace = "Vienna, Austria",
                     Rank = 76,
                     Points = 910,
                     TournamentsPlayed = 32
                 },
                 new Player
                 {
                     Id = 1077,
                     FirstName = "Magda",
                     LastName = "Linette",
                     Age = 34,
                     Weight = "130 lbs/(59kg)",
                     Height = "5'7\"/(171cm)",
                     CountryId = 140, // Poland (POL)
                     Birthplace = "Poznań, Poland",
                     Rank = 77,
                     Points = 908,
                     TournamentsPlayed = 21
                 },
                 new Player
                 {
                     Id = 1078,
                     FirstName = "Petra",
                     LastName = "Marcinko",
                     Age = 20,
                     Weight = "132 lbs/(60kg)",
                     Height = "5'9\"/(175cm)",
                     CountryId = 42, // Croatia (CRO)
                     Birthplace = "Zagreb, Croatia",
                     Rank = 78,
                     Points = 905,
                     TournamentsPlayed = 30
                 },
                 new Player
                 {
                     Id = 1079,
                     FirstName = "Kaitlin",
                     LastName = "Quevedo",
                     Age = 20,
                     Weight = "128 lbs/(58kg)",
                     Height = "5'7\"/(170cm)",
                     CountryId = 165, // Spain (ESP)
                     Birthplace = "Naples, Florida, USA",
                     Rank = 79,
                     Points = 902,
                     TournamentsPlayed = 23
                 },
                 new Player
                 {
                     Id = 1080,
                     FirstName = "Alina",
                     LastName = "Korneeva",
                     Age = 19,
                     Weight = "135 lbs/(61kg)",
                     Height = "5'9\"/(175cm)",
                     CountryId = 144, // Russia (RUS)
                     Birthplace = "Moscow, Russia",
                     Rank = 80,
                     Points = 900,
                     TournamentsPlayed = 24
                 },
                 new Player
                 {
                     Id = 1081,
                     FirstName = "Xiyu",
                     LastName = "Wang",
                     Age = 25,
                     Weight = "148 lbs/(67kg)",
                     Height = "5'11\"/(180cm)",
                     CountryId = 36, // China (CHN)
                     Birthplace = "Taixing, Jiangsu, China",
                     Rank = 81,
                     Points = 899,
                     TournamentsPlayed = 17
                 },
                 new Player
                 {
                     Id = 1082,
                     FirstName = "Viktorija",
                     LastName = "Golubic",
                     Age = 34,
                     Weight = "132 lbs/(60kg)",
                     Height = "5'7\"/(169cm)",
                     CountryId = 170, // Switzerland (SUI)
                     Birthplace = "Zurich, Switzerland",
                     Rank = 82,
                     Points = 899,
                     TournamentsPlayed = 24
                 },
                 new Player
                 {
                     Id = 1083,
                     FirstName = "Panna",
                     LastName = "Udvardy",
                     Age = 28,
                     Weight = "132 lbs/(60kg)",
                     Height = "5'7\"/(170cm)",
                     CountryId = 76, // Hungary (HUN)
                     Birthplace = "Kaposvár, Hungary",
                     Rank = 83,
                     Points = 899,
                     TournamentsPlayed = 31
                 },
                 new Player
                 {
                     Id = 1084,
                     FirstName = "Mananchaya",
                     LastName = "Sawangkaew",
                     Age = 24,
                     Weight = "128 lbs/(58kg)",
                     Height = "5'6\"/(168cm)",
                     CountryId = 174, // Thailand (THA)
                     Birthplace = "Chanthaburi, Thailand",
                     Rank = 84,
                     Points = 886,
                     TournamentsPlayed = 27
                 },
                 new Player
                 {
                     Id = 1085,
                     FirstName = "Shuai",
                     LastName = "Zhang",
                     Age = 37,
                     Weight = "143 lbs/(65kg)",
                     Height = "5'10\"/(177cm)",
                     CountryId = 36, // China (CHN)
                     Birthplace = "Tianjin, China",
                     Rank = 85,
                     Points = 880,
                     TournamentsPlayed = 33
                 },
                 new Player
                 {
                     Id = 1086,
                     FirstName = "Katerina",
                     LastName = "Siniakova",
                     Age = 30,
                     Weight = "150 lbs/(68kg)",
                     Height = "5'9\"/(174cm)",
                     CountryId = 45, // Czechia (Czech Republic)
                     Birthplace = "Hradec Králové, Czech Republic",
                     Rank = 86,
                     Points = 865,
                     TournamentsPlayed = 18
                 },
                 new Player
                 {
                     Id = 1087,
                     FirstName = "Taylah",
                     LastName = "Preston",
                     Age = 20,
                     Weight = "130 lbs/(59kg)",
                     Height = "5'8\"/(172cm)",
                     CountryId = 9, // Australia (AUS)
                     Birthplace = "Perth, Australia",
                     Rank = 87,
                     Points = 858,
                     TournamentsPlayed = 32
                 },
                 new Player
                 {
                     Id = 1088,
                     FirstName = "Tereza",
                     LastName = "Valentova",
                     Age = 19,
                     Weight = "135 lbs/(61kg)",
                     Height = "5'10\"/(178cm)",
                     CountryId = 45, // Czechia (Czech Republic)
                     Birthplace = "Prague, Czech Republic",
                     Rank = 88,
                     Points = 833,
                     TournamentsPlayed = 21
                 },
                 new Player
                 {
                     Id = 1089,
                     FirstName = "Taylor",
                     LastName = "Townsend",
                     Age = 30,
                     Weight = "170 lbs/(77kg)",
                     Height = "5'7\"/(170cm)",
                     CountryId = 187, // United States of America  (USA)
                     Birthplace = "Chicago, Illinois, USA",
                     Rank = 89,
                     Points = 831,
                     TournamentsPlayed = 13
                 },
                 new Player
                 {
                     Id = 1090,
                     FirstName = "Maya",
                     LastName = "Joint",
                     Age = 20,
                     Weight = "128 lbs/(58kg)",
                     Height = "5'7\"/(170cm)",
                     CountryId = 9, // Australia (AUS)
                     Birthplace = "Grosse Pointe, Michigan, USA",
                     Rank = 90,
                     Points = 824,
                     TournamentsPlayed = 26
                 },
                 new Player
                 {
                     Id = 1091,
                     FirstName = "Antonia",
                     LastName = "Ruzic",
                     Age = 23,
                     Weight = "132 lbs/(60kg)",
                     Height = "5'9\"/(175cm)",
                     CountryId = 42, // Croatia (CRO)
                     Birthplace = "Oroslavje, Croatia",
                     Rank = 91,
                     Points = 823,
                     TournamentsPlayed = 28
                 },
                 new Player
                 {
                     Id = 1092,
                     FirstName = "Leolia",
                     LastName = "Jeanjean",
                     Age = 31,
                     Weight = "130 lbs/(59kg)",
                     Height = "5'6\"/(168cm)",
                     CountryId = 61, // France (FRA)
                     Birthplace = "Montpellier, France",
                     Rank = 92,
                     Points = 816,
                     TournamentsPlayed = 28
                 },
                 new Player
                 {
                     Id = 1093,
                     FirstName = "Darja",
                     LastName = "Vidmanova",
                     Age = 23,
                     Weight = "132 lbs/(60kg)",
                     Height = "5'8\"/(173cm)",
                     CountryId = 45, // Czechia (Czech Republic)
                     Birthplace = "Moscow, Russia",
                     Rank = 93,
                     Points = 812,
                     TournamentsPlayed = 26
                 },
                 new Player
                 {
                     Id = 1094,
                     FirstName = "Renata",
                     LastName = "Zarazua",
                     Age = 29,
                     Weight = "126 lbs/(57kg)",
                     Height = "5'3\"/(160cm)",
                     CountryId = 111, // Mexico (MEX)
                     Birthplace = "Mexico City, Mexico",
                     Rank = 94,
                     Points = 801,
                     TournamentsPlayed = 34
                 },
                 new Player
                 {
                     Id = 1095,
                     FirstName = "Claire",
                     LastName = "Liu",
                     Age = 26,
                     Weight = "130 lbs/(59kg)",
                     Height = "5'7\"/(170cm)",
                     CountryId = 187, // United States of America  (USA)
                     Birthplace = "Thousand Oaks, California, USA",
                     Rank = 95,
                     Points = 789,
                     TournamentsPlayed = 25
                 },
                 new Player
                 {
                     Id = 1096,
                     FirstName = "Jessica",
                     LastName = "Bouzas Maneiro",
                     Age = 24,
                     Weight = "134 lbs/(61kg)",
                     Height = "5'8\"/(173cm)",
                     CountryId = 165, // Spain (ESP)
                     Birthplace = "Vilagarcía de Arousa, Spain",
                     Rank = 96,
                     Points = 769,
                     TournamentsPlayed = 29
                 },
                 new Player
                 {
                     Id = 1097,
                     FirstName = "Alina",
                     LastName = "Charaeva",
                     Age = 24,
                     Weight = "130 lbs/(59kg)",
                     Height = "5'7\"/(170cm)",
                     CountryId = 8, // Armenia (ARM)
                     Birthplace = "Moscow, Russia",
                     Rank = 97,
                     Points = 759,
                     TournamentsPlayed = 30
                 },
                 new Player
                 {
                     Id = 1098,
                     FirstName = "Hanne",
                     LastName = "Vandewinkel",
                     Age = 22,
                     Weight = "128 lbs/(58kg)",
                     Height = "5'7\"/(170cm)",
                     CountryId = 17, // Belgium (BEL)
                     Birthplace = "Lommel, Belgium",
                     Rank = 98,
                     Points = 756,
                     TournamentsPlayed = 28
                 },
                 new Player
                 {
                     Id = 1099,
                     FirstName = "Francesca",
                     LastName = "Jones",
                     Age = 26,
                     Weight = "132 lbs/(60kg)",
                     Height = "5'8\"/(172cm)",
                     CountryId = 186, // United Kingdom (GBR)
                     Birthplace = "Leeds, United Kingdom",
                     Rank = 99,
                     Points = 752,
                     TournamentsPlayed = 26
                 },
                 new Player
                 {
                     Id = 1100,
                     FirstName = "Fiona",
                     LastName = "Ferro",
                     Age = 29,
                     Weight = "128 lbs/(58kg)",
                     Height = "5'7\"/(170cm)",
                     CountryId = 61, // France (FRA)
                     Birthplace = "Libreville, Gabon",
                     Rank = 100,
                     Points = 748,
                     TournamentsPlayed = 24
                 }
   };
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasMany(p => p.Coaches)
                .WithOne(c => c.Player)
                .HasForeignKey(c => c.PlayerId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(MensPlayers.Concat(WomensPlayers));
        }
    }
}
