
# Todo Management Full Project

A full-stack Todo Management system built with:

- **ASP.NET Core Web API** for the backend.
- **Angular** for the frontend.

---

## 📁 Project Structure

```
TodoMangment.FullProject/
│
├── TodoMangment.Solution/       # ASP.NET Core backend solution
│   ├── TodoMangment.API/        # Web API project
│   ├── TodoMangment.BLL/        # Business Logic Layer
│   └── TodoMangment.DAL/        # Data Access Layer
│
└── todo/                        # Angular frontend project
```

---

## ⚙️ Prerequisites

Make sure you have the following installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Node.js + npm](https://nodejs.org/)
- [Angular CLI](https://angular.io/cli)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/)

---

## 🔧 Backend Setup (ASP.NET Core API)

1. Navigate to the API folder:
   ```bash
   cd TodoMangment.Solution/TodoMangment.API
   ```

2. Apply database migrations (if using Code First):
   ```bash
   dotnet ef database update
   ```

3. Run the API:
   ```bash
   dotnet run
   ```

The API will be available at `https://localhost:5001` or `http://localhost:5000`.

---

## 🌐 Frontend Setup (Angular)

1. Navigate to the Angular project:
   ```bash
   cd todo
   ```

2. Install dependencies:
   ```bash
   npm install
   ```

3. Run the Angular app:
   ```bash
   ng serve
   ```

The frontend will be available at `http://localhost:4200`.

---

## 📌 Notes

- Make sure the API is running before starting the frontend to ensure it can connect.
- Update the Angular environment file if the API URL is different.

---

## 🧑‍💻 Author

**Mikheal Adel Gaber**  
[GitHub Profile](https://github.com/MikhealAdelGaber)
