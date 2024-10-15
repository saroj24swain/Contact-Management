# Contact Management Application

This project is a full-stack application built using **Angular** (frontend) and **.NET Core** (backend) to manage contact information. It supports CRUD operations, validation, and basic error handling.

## Project Structure

- **Backend (API)**: Built with .NET Core 6.0
- **Frontend (Angular)**: Built with Angular 13+ and Bootstrap for styling

---

## Prerequisites

Before running the application, ensure that you have the following installed:

- **Node.js** (v14+)
- **Angular CLI** (v13+)
- **.NET Core SDK** (6.0+)
- **Visual Studio 2022** or **VS Code** (for running .NET Core)
- **Git** (for cloning the repository)

---

## How to Set Up and Run

### Step 1: Clone the Repository

Clone the repository to your local machine using Git:

```bash
git clone https://github.com/saroj24swain/Contact-Management.git 

### Step 2: Publish and Run the .NET Core API
Open the .NET Core API project located in the backend folder using Visual Studio or VS Code.

Build the project to restore dependencies:

dotnet build

run the project 
dotnet run

The API will be hosted at https://localhost/7185

swagger https://localhost:7185/api/contacts

### Step 3: Serve the Angular Frontend

npm install
ng serve