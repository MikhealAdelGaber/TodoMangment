
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


## 🔧 Backend Setup (ASP.NET Core API)

1. Navigate to the API folder:
   ```bash
   cd TodoMangment.Solution/TodoMangment.API
   ```

2. Apply database migrations :
   ```bash
   dotnet ef database update
   ```
   i can not use ABP but used SQL Server you can to do Update Database the Connection String in appsetting.jason Project TodoMangment.API 

3. Run the API:
   ```bash
   dotnet run
   ```

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

---

## 📌 Notes

- Make sure the API is running before starting the frontend to ensure it can connect.
- Update the Angular environment file if the API URL is different.

---

## 🧑‍💻 Author

**Mikheal Adel Gaber**  
[GitHub Profile](https://github.com/MikhealAdelGaber)
