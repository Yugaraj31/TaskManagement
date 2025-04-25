## Task Management API & Unit Test Project
This repository contains a simple Task Management API built with ASP.NET Core along with a separate NUnit test project for unit testing core service logic such as authentication and token generation.

# Technologies & Packages Used
Main Project (Task Management)
.NET 6 / .NET 7

ASP.NET Core Web API

Dependency Injection

JWT Token Authentication

Entity Framework Core

Microsoft.Extensions.Configuration

# Test Project (TaskTest)
NUnit - Unit testing framework

Moq - For mocking dependencies

Microsoft.Extensions.Configuration.Abstractions (for mocking configuration if needed)

# 🔧 Setup Instructions
Clone the repository:

bash
Copy
Edit
git clone https://github.com/your-username/task-management.git
cd task-management
Restore dependencies:

bash
Copy
Edit
dotnet restore

# Apply Database Migrations (if using EF Core):

Make sure you have SQL Server or another relational database configured in your appsettings.json.

bash
Copy
Edit
dotnet ef database update

# Run the Application:

bash
Copy
Edit
dotnet run

# Database Schema
The following tables are created in the database for managing users, tasks, comments, and user login:

Users: Stores user information such as username and role (Admin/User).

TaskItems: Stores task-related information, linking tasks to users.

TaskComments: Stores comments related to tasks, linking each comment to both a task and a user.

UserLogin: Stores usernames and hashed passwords for authentication. Make sure to hash passwords before storing!

# API Controller for User Authentication & Task Management
The API consists of several controllers responsible for managing user authentication and task management.

AuthController: User Authentication
The AuthController handles the user login and authentication, generating a JWT token upon successful login.

TaskController: Task Management
The TaskController allows you to create tasks, retrieve tasks by ID, and add comments to tasks.

# Expected Output from the API
User Authentication (POST: /api/authenticate)
Request Body:

json
Copy
Edit
{
    "username": "example",
    "password": "example123"
}
Successful Response:

json
Copy
Edit
{
    "token": "your-generated-token-here"
}
Error Response (Invalid credentials):

json
Copy
Edit
{
    "message": "Invalid username or password"
}

# How to Test the API
1. Test Authentication
You can use Postman or any HTTP client to test the Authenticate endpoint. Here’s how to do it:

Method: POST

URL: https://localhost:5001/api/authenticate

Body (JSON):

json
Copy
Edit
{
    "username": "example",
    "password": "example123"
}
If credentials are correct, you’ll get back a JWT token that can be used for subsequent authenticated requests.

# 2. Test Task Management
You can also use Postman to test task-related APIs:

Create Task:

Method: POST

URL: https://localhost:5001/api/task/create

Body (JSON):

json
Copy
Edit
{
    "title": "New Task",
    "assignedUserId": 1
}
Get Task by ID:

Method: GET

URL: https://localhost:5001/api/task/{taskId}

Add Comment to Task:

Method: POST

URL: https://localhost:5001/api/task/{taskId}/comment

Body (JSON):

json
Copy
Edit
{
    "comment": "This is a comment"
}

## Conclusion
This guide walks you through creating the database schema for a task management system, implementing authentication, and task management in an API. Additionally, it provides steps to test and interact with the API.

