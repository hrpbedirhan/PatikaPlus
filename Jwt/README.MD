# JWT Authentication API with ASP.NET Core

This project implements a basic JWT (JSON Web Token) authentication system using ASP.NET Core. The API includes functionality for user login and registration, with tokens generated for authentication.

---

## Table of Contents
1. [Features](#features)
2. [Technologies Used](#technologies-used)
3. [Prerequisites](#prerequisites)
4. [Setup and Installation](#setup-and-installation)
5. [API Endpoints](#api-endpoints)
6. [Configuration](#configuration)
7. [Usage](#usage)

---

## Features
- User registration with email and password.
- User authentication using JWT tokens.
- Middleware to protect API endpoints using authentication.
- Secure token generation with `HS256` algorithm.

---

## Technologies Used
- ASP.NET Core
- Entity Framework Core
- PostgreSQL
- JWT Authentication
- Swagger for API documentation

---

## Prerequisites
Before setting up the project, ensure you have the following installed:
- [.NET 7 SDK](https://dotnet.microsoft.com/download)
- [PostgreSQL](https://www.postgresql.org/download/)
- A code editor like [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/).

---

## Setup and Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/yourusername/jwt-auth-api.git
    cd jwt-auth-api
    ```

2. Configure the database connection in `appsettings.json`:
    ```json
    {
      "ConnectionStrings": {
        "Default": "Host=localhost;Port=5432;Database=JwtDb;Username=yourusername;Password=yourpassword"
      },
      "Jwt": {
        "Key": "YourSuperSecureAndLongJwtKeyHere123456",
        "Issuer": "yourdomain.com",
        "Audience": "yourdomain.com"
      }
    }
    ```

3. Apply database migrations:
    ```bash
    dotnet ef database update
    ```

4. Run the application:
    ```bash
    dotnet run
    ```

5. Access the Swagger UI for testing the API at:
    ```
    https://localhost:<PORT>/swagger/index.html
    ```

---

## API Endpoints

### **User Registration**
**POST** `/api/auth/register`
- **Request Body:**
  ```json
  {
    "email": "example@example.com",
    "password": "yourpassword"
  }
  ```
- **Response:**
  ```json
  {
    "message": "User registered successfully."
  }
  ```

### **User Login**
**POST** `/api/auth/login`
- **Request Body:**
  ```json
  {
    "email": "example@example.com",
    "password": "yourpassword"
  }
  ```
- **Response:**
  ```json
  {
    "token": "your_jwt_token"
  }
  ```

---

## Configuration
### appsettings.json
Configure the JWT settings and database connection in the `appsettings.json` file:
```json
{
  "ConnectionStrings": {
    "Default": "Host=localhost;Port=5432;Database=JwtDb;Username=yourusername;Password=yourpassword"
  },
  "Jwt": {
    "Key": "YourSuperSecureAndLongJwtKeyHere123456",
    "Issuer": "yourdomain.com",
    "Audience": "yourdomain.com"
  }
}
```

Ensure the `Jwt:Key` is at least 32 characters long for secure token generation.

---

## Usage
1. Use the `/register` endpoint to create a new user.
2. Authenticate the user using the `/login` endpoint to receive a JWT token.
3. Include the token in the `Authorization` header of subsequent requests:
    ```
    Authorization: Bearer your_jwt_token
    ```
4. Access secured endpoints with the token.

---

![Response Token](./assets/token.png)