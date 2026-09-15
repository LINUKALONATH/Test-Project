# MyProject

A starter full-stack project with an Angular frontend and ASP.NET Core Web API backend.

## Structure

- `frontend/my-project`: Angular standalone application
- `backend/MyProject.API`: ASP.NET Core Web API

## Run the backend

```powershell
cd backend/MyProject.API
dotnet run
```

## Run the frontend

```powershell
cd frontend/my-project
npm install
npm start
```

The frontend expects the API at `http://localhost:5000/api` in development.
