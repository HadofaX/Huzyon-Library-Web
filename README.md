# Huzyon Library

A Library Management System built with ASP.NET Core MVC and SQL Server.

## About the Project

Huzyon Library is a web application developed to demonstrate how a library management system can display and organize data from related database tables.

The project uses ASP.NET Core MVC for the web interface and SQL Server for data storage. ADO.NET is used to retrieve database records through a Data Access Layer (DAL).

## Technologies Used

* C#
* ASP.NET Core MVC
* SQL Server
* ADO.NET
* HTML
* CSS
* JavaScript
* Bootstrap

## Features

* Dashboard with database record counts
* Product management views
* Customer data views
* Order and order details views
* Category views
* Favorites views
* Product-category relationships
* Products by category chart
* Navigation between the system's pages

## Project Structure

* `Huzyon.Models` — Class library containing the Data Access Layer and models.
* `Huzyon.Web` — ASP.NET Core MVC web application.
* `Huzyon.Web.sln` — Visual Studio solution.

## Database Setup

The application uses SQL Server. Update the connection string in `DbConfig.cs` to match your local SQL Server instance before running the project.

The database schema and sample data must be available in SQL Server for the application to work correctly.

## How to Run

1. Clone or download this repository.
2. Open `Huzyon.Web.sln` in Visual Studio 2022.
3. Configure the SQL Server connection string in `DbConfig.cs`.
4. Make sure the required database and tables exist.
5. Build and run the `Huzyon.Web` project.

## Project Status

Developed as a learning project using ASP.NET Core MVC and SQL Server.
