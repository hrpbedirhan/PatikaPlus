# Survivor API

A Web API project designed for a **Survivor competition**. The application implements CRUD operations for managing **Competitors** and **Categories** using ASP.NET Core and Entity Framework Core.

---

## Table of Contents
1. [Technologies Used](#technologies-used)
2. [Project Structure](#project-structure)
3. [Database Models](#database-models)
4. [API Endpoints](#api-endpoints)
5. [Installation and Setup](#installation-and-setup)
6. [Testing the API](#testing-the-api)
7. [Usage Examples](#usage-examples)

---

## Technologies Used
- **ASP.NET Core** - Framework for building the Web API
- **Entity Framework Core** - ORM for database interaction
- **PostgreSQL** - Database used for storing data
- **Swagger / Postman** - Tools for API testing

---

## Project Structure

```
Survivor/
│
├── Controllers/
│   ├── CategoryController.cs   # Controller for Category CRUD
│   └── CompetitorController.cs # Controller for Competitor CRUD
│
├── Model/
│   ├── Entities/
│   │   ├── BaseEntity.cs       # Abstract base class for entities
│   │   ├── Category.cs         # Category entity model
│   │   └── Competitor.cs       # Competitor entity model
│   └── SurvivorDbContext.cs    # Database context configuration
│
├── Program.cs                  # Application entry point and configurations
└── appsettings.json            # Configuration for connection string
```

---

## Database Models

### 1. BaseEntity
An abstract class providing common properties for all entities:
- **Id**: Primary key (int)
- **IsDeleted**: Soft delete flag (bool)
- **CreatedDate**: Record creation timestamp (DateTime)
- **ModifiedDate**: Last modification timestamp (DateTime)

### 2. Category Entity
Represents a competition category:
```csharp
public class Category : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Competitor> Competitors { get; set; }
}
```

### 3. Competitor Entity
Represents a competition participant:
```csharp
public class Competitor : BaseEntity
{
    public int CategoryId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Category Category { get; set; }
}
```

---

## API Endpoints

### CategoryController
| Method | Endpoint                  | Description                    |
|--------|--------------------------|--------------------------------|
| GET    | `/api/Category`          | Get all categories             |
| GET    | `/api/Category/{id}`     | Get a specific category by ID  |
| POST   | `/api/Category`          | Create a new category          |
| PUT    | `/api/Category/{id}`     | Update an existing category    |
| DELETE | `/api/Category/{id}`     | Delete a specific category     |

### CompetitorController
| Method | Endpoint                                | Description                             |
|--------|----------------------------------------|-----------------------------------------|
| GET    | `/api/Competitor`                      | Get all competitors                     |
| GET    | `/api/Competitor/{id}`                 | Get a specific competitor by ID         |
| GET    | `/api/Competitor/categories/{id}`      | Get competitors by category ID          |
| POST   | `/api/Competitor`                      | Create a new competitor                 |
| PUT    | `/api/Competitor/{id}`                 | Update an existing competitor           |
| DELETE | `/api/Competitor/{id}`                 | Delete a specific competitor            |

---

## Installation and Setup

Follow these steps to set up and run the project:

1. **Clone the repository**:
```bash
git clone <https://github.com/hrpbedirhan/PatikaPlus/tree/master/Survivor>
cd Survivor
```

2. **Install the required packages**:
```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
```

3. **Configure Database Connection**:
Update the `appsettings.json` with your PostgreSQL configuration:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=SurvivorDb;Username=postgres;Password=your_password"
  }
}
```

4. **Update Program.cs**:
Ensure the `SurvivorDbContext` is configured correctly:
```csharp
builder.Services.AddDbContext<SurvivorDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
```

5. **Run Database Migrations**:
Create and apply the initial database migration:
```bash
dotnet ef migrations add InitialCreate

# Update the database
dotnet ef database update
```

6. **Run the Project**:
Start the application:
```bash
dotnet run
```

---

## Testing the API
You can test the API endpoints using:
1. **Swagger**: Open `https://localhost:<port>/swagger` to access Swagger UI.
2. **Postman**: Manually test each endpoint using Postman.

### Sample Request
#### Create a New Category
**Request**:
```http
POST /api/Category
Content-Type: application/json
{
    "name": "Tribes"
}
```

**Response**:
```json
{
    "id": 1,
    "name": "Tribes",
    "isDeleted": false,
    "createdDate": "2024-06-17T00:00:00",
    "modifiedDate": "2024-06-17T00:00:00"
}
```

---

## Usage Examples
### Fetch Competitors by Category
**Request**:
```http
GET /api/Competitor/categories/1
```

**Response**:
```json
[
  {
    "id": 1,
    "firstName": "John",
    "lastName": "Doe",
    "categoryId": 1,
    "isDeleted": false,
    "createdDate": "2024-06-17T00:00:00",
    "modifiedDate": "2024-06-17T00:00:00"
  }
]
```

---

## Notes
- **Soft Delete**: Entities include an `IsDeleted` property for soft deletes.
- **Timestamps**: `CreatedDate` and `ModifiedDate` are automatically set during entity creation and updates.
- **Error Handling**: The API returns `404 Not Found` for invalid IDs and appropriate status codes for all operations.

---