# Local Business Client MVC

#### An ASP.NET Core MVC created to accompany the [Local Business API](https://github.com/chynnalew/LocalBusiness.Solution)

#### Created By: Chynna Lew 

## Technologies Used

* C#
* .NET 5
* NuGet
* ASP.NET Core
* Entity Framework Core
* Bootstrap
* CSS

## Description

This application was created to accompany the [Local Business API](https://github.com/chynnalew/LocalBusiness.Solution). This MVC allows the user to access the API's full CRUD functionality in the browser.

## Setup and Usage Instructions

### Technology Requirements

* Download and install [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* Download and install a code text editor. Ex: [VS Code](https://code.visualstudio.com/)

### Installation

* Download and run [this](https://github.com/chynnalew/LocalBusiness.Solution) API, following the instructions in the API README.md
  -This application REQUIRES the api to be running during use
* Clone [this](https://github.com/chynnalew/LocalBusinessClient.Solution) repository, or download and open the Zip on your local machine
* Open the LocalBusinessClient.Solution folder in your preferred text editor
* To install required packages, navigate to LocalBusinessClient.Solution/LocalBusinessClient in the terminal and type the following commands:
  - dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0
  - dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
  - dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0
  - dotnet tool install --global dotnet-ef --version 3.0.0

* To Restore, build, and launch the project:
  - Navigate to the LocalBusinessClient.Solution/LocalBusinessClient folder in the command line or terminal
    - Run the command `$ dotnet restore` to restore the project dependencies
    - Run the command `$ dotnet build` to build and compile the project
    - Run the command `$ dotnet run` to build and compile the project
    - The ASP.NET Core MVC is viewable in the browser at http://localhost:5004 
    - If the styling is not appearing in the browser, open http://localhost:5004 in an incognito browser or clear your browser cache

## Known Bugs

* none at this time

### License

[MIT License](https://opensource.org/licenses/MIT)
Copyright 2021 Chynna Lew

## Support and contact details

* [Chynna Lew](github.com/chynnalew) 
* <ChynnaLew@yahoo.com>

