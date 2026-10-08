# Foresters Sitecore Demo

A .NET web application demonstrating a Sitecore-style content management architecture built with ASP.NET Core, Entity Framework Core, SQL Server, and ASP.NET Core Identity.

## Overview

This project demonstrates how a financial-services-style website can be built with a structured CMS approach, including dynamic content pages, administrative functionality, authentication, authorization, and database-backed content management.

## Features

* ASP.NET Core / .NET 10
* Entity Framework Core
* SQL Server
* ASP.NET Core Identity
* User authentication and authorization
* Role-based access control
* Dynamic content pages
* Sitecore-inspired content management structure
* PageKey-based content lookup
* Database migrations
* Admin/content management functionality
* MVC architecture

## Architecture

The application separates:

* **Presentation** — Razor/MVC views
* **Application logic** — Controllers and services
* **Data access** — Entity Framework Core
* **Database** — SQL Server
* **Authentication** — ASP.NET Core Identity

## Database

The application uses SQL Server for persistent data storage.

Database migrations are included in the repository so the database schema can be recreated in another development environment.

> The actual SQL Server database and credentials are not included in this repository.

## Running Locally

Prerequisites:

* .NET 10 SDK
* SQL Server
* Visual Studio Code or Visual Studio

Clone the repository, configure the local database connection, apply the migrations, and run the application.

```bash
dotnet restore
dotnet ef database update
dotnet run
```

The application will then be available locally.

## Purpose

This project was created as a demonstration of modern .NET development, database-driven applications, authentication/authorization, and CMS-style architecture.
