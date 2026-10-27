# 🚀 Project Name - CourtSide

CourtSide is a tennis management and scoring web application designed to track real-time match results, player rankings, tournament schedules, and venue details across professional tours.

![.NET Version](https://img.shields.io/badge/.NET-10.0-purple)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-10.0-blue)
![License](https://img.shields.io/badge/license-MIT-green)

---

## 📋 Table of Contents

- About the Project 
- CourtSide is a web platform developed using ASP.NET Core MVC 10.0 and Entity Framework Core. It allows tracking tournaments, player statistics, rankings, and match scoring.

- Technologies Used
- Backend: C#, .NET 10.0, ASP.NET Core MVC, Entity Framework Core
- Database: Microsoft SQL Server
- Frontend: Bootstrap 5, Bootstrap Icons, Inter & Montserrat Google Fonts, JavaScript / jQuery

- [Prerequisites](#prerequisites)
- .NET 10.0 SDK
- SQL Server (or SQL Server Express)
- Visual Studio 2022 or Visual Studio 2026  

- [Getting Started](#getting-started) 
- Clone the repository:```bash git clone [https://github.com/your-username/courtside.git](https://github.com/your-username/courtside.git)
   git clone [https://github.com/YordanSoftDev/CourtSide-Project.git](https://github.com/YordanSoftDev/CourtSide-Project.git)
- The application uses local configuration settings stored in `appsettings.json`.      
- Configure your database connection string in `appsettings.json` 
- Run Entity Framework migrations to set up the database: update-database
- Run the project: dotnet run

- [Project Structure]
  CourtSide-Project/
  --CourtSide.Common/         Validation constants and matches enumerations
  --CourtSide.Data/           DbContext, migrations, and database configuration
  --CourtSide.Data.Models/    Domain entities and database models
  --CourtSide.Models/         Data transport & domain model abstractions
  --CourtSide.Services.Core/  Core business logic and service implementations
  --CourtSide.ViewModels/     Input/Output View Models for UI interaction
  --CourtSide.Web/            ASP.NET Core MVC Controllers, Views

- [Features](#features)
- [Usage](#usage)
- [Database Setup](#database-setup)
- [Configuration](#configuration)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

---

## 📖 About the Project

Write 2–4 sentences describing what the application does, what problem it solves, and for whom it was built.

**Example:**  
This is a simple task management web application built as part of the *ASP.NET Fundamentals* course. It demonstrates core concepts like MVC architecture, Entity Framework Core, and RESTful API design.

---

## 🛠️ Technologies Used

| Technology            | Version  | Purpose                          |
|-----------------------|----------|----------------------------------|
| ASP.NET Core MVC      | 10.0     | Web framework                    |
| Entity Framework Core | 10.0     | ORM / Database access            |
| SQL Server / SQLite   | 10.0     | Database (via EF Core SqlServer) |
| Bootstrap             | 5.3      | Frontend styling                 |
| AutoMapper            | 16.2     | Object-to-object mapping                 |
| Razor Pages / Views   | 10.0     | Server-side HTML rendering       |

---

## ✅ Prerequisites

Make sure you have the following installed before running the project:

- [.NET SDK 10.0+](https://dotnet.microsoft.com/download)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server) or SQLite (if used)
- [Git](https://git-scm.com/)

---

## 🚀 Getting Started

Follow these steps to get the project running locally.

### 1. Clone the repository

```bash
```bash
git clone [https://github.com/YordanSoftDev/CourtSide-Project.git](https://github.com/YordanSoftDev/CourtSide-Project.git)
cd CourtSide-Project
```

### 2. Restore dependencies

```bash
dotnet restore
```

### 3. Apply database migrations

```bash
dotnet ef database update
```

### 4. Run the application

```bash
dotnet run
```

The app will be available at `https://localhost:5001` or `http://localhost:5000`.

---

## 📁 Project Structure

```
CourtSide/
│
├── Controllers/          # MVC Controllers
├── Models/               # Domain models and ViewModels
├── Views/                # Razor Views (.cshtml)
├── Data/                 # DbContext and migrations
├── Services/             # Business logic / service layer
├── wwwroot/              # Static files (CSS, JS, images)
├── appsettings.json      # App configuration
└── Program.cs            # App entry point and middleware setup
```

---

## ✨ Features

- [ ] User registration and login (ASP.NET Identity)
- [ ] CRUD operations for [main entity]
- [ ] RESTful API endpoints
- [ ] Input validation (server-side & client-side)
- [ ] Responsive UI with Bootstrap

---

## 💻 Usage

Describe how to use the main features of the app after launching it. Add screenshots if possible.

```
1. Navigate to /Register to create an account.
2. Log in at /Login.
3. Use the dashboard to manage your [entities].
```

> 💡 **Tip:** You can add screenshots using: `![Screenshot](docs/screenshot.png)`

---

## 🗄️ Database Setup

The project uses **Entity Framework Core** with a Code-First approach.

Connection string is configured in `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=CourtSideDb;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true"
}
```

To create and seed the database:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

## ⚙️ Configuration

Key settings in `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=CourtSideDb;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information"
    }
  }
}
```

> ⚠️ **Never commit sensitive data** (passwords, API keys) to source control. Use `appsettings.Development.json` or environment variables for local secrets.

---

## 🤝 Contributing

Contributions are welcome! To contribute:

1. Fork the repository
2. Create a new branch: `git checkout -b feature/your-feature-name`
3. Commit your changes: `git commit -m "Add some feature"`
4. Push to the branch: `git push origin feature/your-feature-name`
5. Open a Pull Request

---

## 📄 License

This project is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for details.

---

## 📬 Contact

**Yordan Georgiev** – [@YordanSoftDev](https://github.com/YordanSoftDev)

Project Link: [https://github.com/YordanSoftDev/CourtSide-Project](https://github.com/YordanSoftDev/CourtSide-Project)
---

*Built as part of the **ASP.NET Fundamentals** course.*
