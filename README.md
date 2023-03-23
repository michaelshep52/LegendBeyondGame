# LegendBeyondGame
This repository contains the C# backend and client for Legend Game REST API. 
Where you can create Player, create an account, choose a character, and choose a inventory.
You also have the options to create a character and inventory as you desire but will not be added to the game.

## Nuget Packages
Make sure to restore the packages.
### API
- Microsoft.AspNetCore.Mvc.NewtonsoftJson (for json formatting to pascalcase for untiy)
- Microsoft.AspNetCore.Mvc.Versioning 
- Microsoft.AspNetCore.Mvc.Versioning.ApiExplorer
- Microsoft.AspNetCore.OpenApi
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.VisualStudio.Web.CodeGeneration.Design
- Npgsql.EntityFrameworkCore.PostgresSQL
- SwashBuckle.AspNetCore
### Data
- Microsoft.EntityFrameworkCore.Tools
- Npgsql.EntityFrameworkCore.PostgresSQL
### Addition Nuget information
#### If you do not have postgres downloaded on your computer no problem simply add:
- Microsoft.EntityFrameworkCore.Sqlite 
- Microsoft.EntityFrameworkCore.SqlServer
#### Remove or just leave: 
- Npgsql.EntityFrameworkCore.PostgresSQL

## Features
The following items are implemented:
- Create a generic class and use it.
- Make application an Api.
- Make application a CRUD Api.
- Make application asynchronous.
- Make application have atleast 2 tables or more that return data.
### Additional Features include
- Using Entity Framework Core for creating database and relationships.
- Repository pattern, unit of work, and services.

## Usage
Follow these steps:
- First to get repository on your local machine Clone by clicking the green <>code button and copying a route.
- Second you need the NuGet packages to be restore.
- Third Run the application.
- Finally Create, Read, Update, and Delete data from database with Swaggers user friendly UI.
