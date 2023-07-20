# LegendBeyondGame
This repository contains the C# backend and client for Legend Game REST API. 
Where you can create Player, create an account, choose a character, and choose a inventory.
You also have the options to create a character and inventory as you desire but will not be added to the game. 
- Comming soon:
- To play the game you must download unity game engine  https://unity.com/download follow propt to download.

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

### Additional Nuget information
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

## API Pictures
<img width="1280" alt="Screenshot 2023-07-20 at 12 03 00 PM" src="https://github.com/michaelshep52/LegendBeyondGame/assets/112525897/24af212a-8319-44b2-b568-4e1749737845">
<img width="1280" alt="Screenshot 2023-07-20 at 12 03 04 PM" src="https://github.com/michaelshep52/LegendBeyondGame/assets/112525897/98765435-1b50-4c12-98c7-aaf0c5633437">
<img width="1280" alt="Screenshot 2023-07-20 at 12 03 07 PM" src="https://github.com/michaelshep52/LegendBeyondGame/assets/112525897/48e5d9ee-1a98-4613-a7c2-e4d7dd29a08d">
<img width="1280" alt="Screenshot 2023-07-20 at 12 03 10 PM" src="https://github.com/michaelshep52/LegendBeyondGame/assets/112525897/65352316-208b-476c-a2a3-ce4f3285a940">

## Game is to Large to be uploaded into github
- Still trying to find a way around it to post it
- However here are the features

## Game Features
- Home Page with Login/Register/Settings
- Login Page to Login as existing user
- Register Page to create new account
- Character Select Page to choose between different characters that have different attributes and inventories (currently not finished)

## Game Details
- Open World First person Shooter
- 1 type of enemy that animates and dies
- Many new features coming soon!

# SCENE PICTURES
## Main page
<img width="1280" alt="Screenshot 2023-04-03 at 6 55 14 AM" src="https://user-images.githubusercontent.com/112525897/229491213-a6fc0e68-6394-4d78-9720-e14010bfc140.png">

## Register
<img width="1280" alt="Screenshot 2023-04-03 at 6 55 23 AM" src="https://user-images.githubusercontent.com/112525897/229491244-5276a5a8-4ed0-4975-af82-2466058bf250.png">

## Login
<img width="1280" alt="Screenshot 2023-04-03 at 6 55 36 AM" src="https://user-images.githubusercontent.com/112525897/229491308-7921e687-22d9-46b1-aea1-875d11a24d6a.png">

## Character Selection
<img width="1280" alt="Screenshot 2023-04-03 at 6 55 28 AM" src="https://user-images.githubusercontent.com/112525897/229491280-924c6d52-4244-4df5-ba43-dec871104205.png">

## Game
<img width="1280" alt="Screenshot 2023-04-03 at 6 55 44 AM" src="https://user-images.githubusercontent.com/112525897/229491340-a4df3eb3-6ed7-4d71-8c39-02177c7fb3a3.png">

<img width="1280" alt="Screenshot 2023-04-03 at 6 55 55 AM" src="https://user-images.githubusercontent.com/112525897/229491390-2553bbb6-8eb0-4ef6-9a06-bea388eb1a52.png">

<img width="1280" alt="Screenshot 2023-04-03 at 6 55 59 AM" src="https://user-images.githubusercontent.com/112525897/229491433-7d6332cf-95cc-4d44-a3af-7128547b2974.png">

<img width="1280" alt="Screenshot 2023-04-03 at 6 56 08 AM" src="https://user-images.githubusercontent.com/112525897/229491462-8b9f20bb-72bb-47cb-a7e2-a8c1eb9d92ee.png">

