# Employee Management System

![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-6.0-blue)
![Entity Framework](https://img.shields.io/badge/Entity_Framework-6.0-green)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.2-purple)

A complete employee management system built with ASP.NET Core MVC.

## Features

- **Employee Management**
  - Create, Read, Update, Delete (CRUD) operations
  - Sorting by all columns
  - Department assignment
  - Salary calculations

- **Department Management**
  - Department creation
  - Employee assignment

- **User Interface**
  - Responsive design
  - Modern Bootstrap 5 layout
  - Font Awesome icons
  - Interactive tables

## Technology Stack

| Component       | Technology |
|----------------|------------|
| Framework      | ASP.NET Core 6 MVC |
| Database       | SQL Server with Entity Framework Core |
| Frontend       | Bootstrap 5, jQuery |
| Authentication | ASP.NET Core Identity |

## Getting Started

### Prerequisites
- .NET 6 SDK
- SQL Server
- Visual Studio 2022 (recommended)

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/Osama-matter/Simple-Mangement-System-Using-MVC.git
   dotnet restore
   dotnet ef database update
   dotnet run
   Simple-Management-System/


### Project Structure
├── Controllers/
│   ├── EmployeesController.cs
│   └── DepartmentsController.cs
├── Models/
│   ├── Employee.cs
│   ├── Department.cs
│   └── ViewModels/
├── Views/
│   ├── Employees/
│   └── Shared/
├── wwwroot/
│   ├── css/
│   └── js/
├── Migrations/
└── appsettings.json


### Configuration
"ConnectionStrings": {
  "DefaultConnection": "Server=your_server;Database=EmployeeDB;Trusted_Connection=True;"
}

### Contact
Developer: Osama Matter

Email: osamamatter390@gmail.com

GitHub: @Osama-matter

### Key Features of This README:

1. **Clear Badges** - Shows technologies at a glance
2. **Feature Highlights** - Organized bullet points
3. **Tech Stack Table** - Clean component mapping
4. **Step-by-Step Installation** - With code blocks
5. **Visual Project Structure** - Directory tree visualization
6. **Screenshot Section** - Placeholder for actual images
7. **Configuration Help** - Connection string example
8. **License & Contact** - Standard project info
9. <img width="1920" height="1080" alt="Screenshot (190)" src="https://github.com/user-attachments/assets/c133d475-74e1-4e6f-8bdb-8671a898bccf" />
<img width="1920" height="1080" alt="Screenshot (189)" src="https://github.com/user-attachments/assets/27cb9eb6-8f41-4826-ab65-ab0b896c39dd" />
<img width="1920" height="1080" alt="Screenshot (188)" src="https://github.com/user-attachments/assets/2d003e5c-32be-4f03-92e2-db546e915b2b" />
<img width="1920" height="1080" alt="Screenshot (187)" src="https://github.com/user-attachments/assets/82aba7f2-341f-4021-a888-1fa0e3283aad" />

