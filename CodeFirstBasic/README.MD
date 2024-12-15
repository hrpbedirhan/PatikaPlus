# CodeFirstBasic

This project demonstrates the use of the **Code First** approach in Entity Framework Core to create and manage a database with PostgreSQL. The application includes two entities, `Movie` and `Game`, and uses migrations to create the database schema.


## Prerequisites

Before running the project, ensure you have the following installed:

1. [.NET SDK](https://dotnet.microsoft.com/download)
2. [PostgreSQL](https://www.postgresql.org/download/)
3. [pgAdmin](https://www.pgadmin.org/)

## Project Overview

The project contains the following entities:

### Movie
- **Id**: Primary key, auto-incremented
- **Title**: Movie title (string)
- **Genre**: Movie genre (e.g., Action, Comedy) (string)
- **ReleaseYear**: Release year of the movie (int)

### Game
- **Id**: Primary key, auto-incremented
- **Name**: Game name (string)
- **Platform**: Platform (e.g., PC, PlayStation, Xbox) (string)
- **Rating**: Game rating (decimal, 0-10)

### Database Context
The database context is defined in the `PatikaFirstDbContext` class. The connection string is configured in the `OnConfiguring` method.

```csharp
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseNpgsql("Host=localhost;Database=PatikaCodeFirstDb1;Username=your_username;Password=your_password");
}
```

## Getting Started

### Step 1: Configure PostgreSQL

1. Create a PostgreSQL database named `PatikaCodeFirstDb1`.
2. Update the connection string in `PatikaFirstDbContext` with your PostgreSQL username and password.

### Step 2: Install Dependencies

Run the following commands to install the required NuGet packages:

```bash
# Install EF Core packages
dotnet add package Microsoft.EntityFrameworkCore

dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
```

### Step 3: Apply Migrations

1. Add a migration:
   ```bash
   dotnet ef migrations add InitialCreate
   ```

2. Apply the migration to update the database:
   ```bash
   dotnet ef database update
   ```

### Step 4: Run the Application

Run the project:
```bash
dotnet run
```

### Step 5: Verify the Database

Use pgAdmin or PostgreSQL CLI to check if the `Movies` and `Games` tables are created in the `PatikaCodeFirstDb1` database.

- In pgAdmin, run:
  ```sql
  SELECT * FROM "Movies";
  SELECT * FROM "Games";
  ```

## Additional Notes

- You can modify or extend the entities and regenerate migrations if needed.
- If you encounter connection issues, verify that PostgreSQL is running and the connection string is correct.

## Contact

For questions or feedback, feel free to reach out!

