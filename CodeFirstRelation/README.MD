# PatikaCodeFirstDb2

This project demonstrates a **Code First** approach using **Entity Framework Core** to create **Users** and **Posts** tables along with relationships between them. Each `User` can have multiple `Posts`, but each `Post` belongs to only one `User`.

## Technologies

- **.NET 6.0** or **.NET 7.0**
- **Entity Framework Core**
- **PostgreSQL** (using Npgsql for database connection)

## Project Structure

- **User**: A class representing user information.
- **Post**: A class representing post information, which belongs to a user.
- **PatikaSecondDbContext**: The DbContext class managing the connection and models.

## Getting Started

### 1. Running the Project

#### a. Prerequisites

- Visual Studio 2022 or later (or any .NET IDE)
- **.NET SDK** installed
- **PostgreSQL** installed on your machine

#### b. Connection String

The connection string used in this project is for **PostgreSQL**. You can configure it in the `OnConfiguring` method of the `PatikaSecondDbContext` class:

```csharp
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseNpgsql("Host=localhost;Database=PatikaCodeFirstDb2;Username=postgres;Password=your_password");
}
```
This connects to a local PostgreSQL instance with the database name PatikaCodeFirstDb2. Make sure to replace your_password with your actual PostgreSQL password.

c. Migration and Database Update
To create the database and apply migrations, use the following commands:

Add migration:

* Visual Studio Package Manager Console:

```powershell
Add-Migration InitialCreate
```
* Using the CLI:

```bash
dotnet ef migrations add InitialCreate
```
Update the database:
* Visual Studio Package Manager Console:

```powershell
Update-Database
````
Using the CLI:

```bash
dotnet ef database update
```
This will create the necessary database and tables (Users and Posts), and configure the relationships.

## Usage
Once the project is running, you can perform the following operations:

* Create Users: Add new users to the Users table.
* Add Posts: Add posts for each user in the Posts table.
* Access Data: Retrieve users along with their posts based on the relationships.
