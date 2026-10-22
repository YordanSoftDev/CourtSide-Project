namespace CourtSide.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using CourtSide.Data.Models;
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public static IEnumerable<Player> DefaultPlayers =>
             new List<Player>
             {new Player
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
                 }
             };
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasOne(p => p.Country)
                .WithMany()
                .HasForeignKey(p => p.CountryId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p => p.Coaches)
                .WithOne(c => c.Player)
                .HasForeignKey(c => c.PlayerId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(DefaultPlayers);
        }
    }
}
