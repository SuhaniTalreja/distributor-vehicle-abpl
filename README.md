# 🚚 Distributor Vehicle WebApp

The **Distributor Vehicle WebApp** is a web-based application built using the **ASP.NET Framework** to streamline the management of distributor vehicles. It facilitates slip generation, route management, and delivery tracking—helping logistics and distribution teams operate efficiently.

---

## 🔧 Tech Stack

- **Frontend**: HTML5, CSS3, JavaScript, Razor Views (if using ASP.NET MVC)
- **Backend**: ASP.NET Framework (C#)
- **Database**: SQL Server / LocalDB
- **IDE**: Visual Studio 2019 or 2022

---

## ✨ Features

- ✅ Generate and print vehicle slips
- ✅ Assign routes to distributor vehicles
- ✅ Track delivery summaries
- ✅ Store historical slip and vehicle data
- ✅ Simple, responsive UI (customizable)

---

## 📂 Project Structure

Typical ASP.NET MVC project layout:
DistributorVehicleApp/
├── Controllers/ # Handles HTTP requests and business logic
├── Models/ # Contains data models and entities
├── Views/ # Razor views for UI rendering
├── Scripts/ # JavaScript files
├── Content/ # CSS, fonts, images
├── App_Data/ # Local DB files (if used)
├── Web.config # Configuration settings
└── Global.asax # App-level event handling


---

## ⚙️ Getting Started

### 🔁 Prerequisites

- Visual Studio 2019/2022
- .NET Framework 4.6 or higher
- SQL Server or LocalDB

### 🚀 Setup Instructions

1. **Clone the repository**

   ```bash
   git clone https://github.com/SuhaniTalreja/distributor-vehicle-abpl.git
   cd distributor-vehicle-abpl
2. **Open in Visual Studio**

Open the .sln file in Visual Studio.

Restore NuGet packages (if prompted).

Ensure the correct database connection string is configured in Web.config.

3. **Build and Run**

Press F5 or select Start Debugging to launch the application.

Navigate through the UI to test slip generation and other features.
