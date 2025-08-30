# BlazorCRUDApp

BlazorCRUDApp is a CRUD web application built with Blazor (.NET 7) for managing people records. It demonstrates modern Blazor component design, validation, and a layered architecture using multiple projects.

## Features
- Add, update, and delete people records
- Form validation for required fields, email, and mobile
- Responsive UI with Bootstrap styling
- Modular architecture with separate projects for data access, business logic, and service layers

## Project Structure
- **BlazorLearningApp**: Main Blazor WebAssembly project (UI)
- **App.Models**: Contains model classes (e.g., People)
- **App.DataAccess**: Data access layer (repositories)
- **App.Business**: Business logic layer (managers)
- **App.Service**: Service layer for business/data orchestration
- **BaseManager**: Base classes for managers

## Getting Started
1. **Prerequisites**: .NET 7 SDK
2. **Restore Packages**: Run `dotnet restore` in the solution directory
3. **Build Solution**: Run `dotnet build`
4. **Run App**: Run `dotnet run --project BlazorLearningApp/BlazorLearningApp.csproj`
5. Open your browser at the provided URL (usually `https://localhost:5001`)

## Usage
- Use the navigation menu to access the People Detail page
- Add or update people using the form
- Delete records using the table action button

## Technologies Used
- Blazor WebAssembly
- .NET 7
- Bootstrap 5
- DataAnnotations for validation

## Screenshots
<img width="1919" height="947" alt="image" src="https://github.com/user-attachments/assets/b3d10790-2922-4eda-897f-22b0680a7f9e" />


