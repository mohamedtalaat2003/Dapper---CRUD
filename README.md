# 🎮 Dapper CRUD Web API 

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Dapper](https://img.shields.io/badge/Dapper-Micro_ORM-blue?style=for-the-badge)

**I learned Dapper through a project-based learning approach**.

## 📖 Overview
This is a beginner-friendly **ASP.NET Core 8.0 Web API** project designed to demonstrate how to perform **CRUD (Create, Read, Update, Delete)** operations using **Dapper**. The project focuses on managing a simple `VideoGame` entity.

While Dapper is used for high-performance data querying and execution, **Entity Framework Core** is included solely to easily manage database schema creation using Migrations.

## 🚀 Tech Stack
* **Framework:** .NET 8.0
* **Language:** C#
* **Micro-ORM:** Dapper
* **ORM (For Migrations):** Entity Framework Core
* **Database:** SQL Server
* **API Documentation:** Swagger / OpenAPI

## 🧩 Architectural Highlights
* **Repository Pattern:** The data access logic is abstracted through `IVideoGameRepository` and implemented in `VideoGameRepository` to decouple the Dapper queries from the Controllers.
* **Dependency Injection (DI):** The repository is injected directly into controllers via ASP.NET Core's built-in DI container (`AddScoped`).

## ✨ Features
- [x] Retrieve all video games.
- [x] Retrieve a specific video game by ID.
- [x] Add a new video game.
- [x] Update an existing video game.
- [x] Delete a video game.

## 🛠️ Getting Started

### Prerequisites
* [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
* SQL Server
* Visual Studio 2022 / Visual Studio Code

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/mohamedtalaat2003/Dapper---CRUD.git
   ```
2. Navigate to the project directory:
   ```bash
   cd Dapper---CRUD/DapperBiggnerCourse
   ```
3. Update the `DefaultConnection` string in [appsettings.json](cci:7://file:///c:/Users/RoYaA/Pictures/Pictures/API/E-Commerce%20SaaS/ECommerce/ECommerce/Dapper---CRUD/DapperBiggnerCourse/appsettings.json:0:0-0:0) to point to your local SQL Server instance.
4. Apply the EF Core migrations to build the database:
   ```bash
   dotnet ef database update
   ```
5. Run the application:
   ```bash
   dotnet run
   ```
6. Open your browser and navigate to the Swagger UI (usually at `https://localhost:port/swagger`) to test the endpoints.

## 🤝 Contributing
Feel free to fork the repository and submit pull requests if you want to add more features (like error handling, pagination, etc.).

---
**Developed by [Mohamed Talaat]**
```

لو حابب أعمل ملف الـ `README.md` ده جوه الفولدر نفسه، تقدر تقولي وهنفذلك الأمر فوراً!
