
# **Best Restaurants**

#### Author: **_Jessica Hvozdovich and Nitun Data_**
#### May 28, 2020

### Description

_The purpose of this project is to create a C# web application and practice database basics with MySQL and Entity. This application takes user input to display different cuisines and the restaurants that belong to in a one to many relationship._

### Instructions for use:

1. Open Terminal (macOS) or PowerShell (Windows)
2. To download the project directory enter the following commands:
* cd Desktop
* git clone https://github.com/jhvozdovich/best-restaurants.git
* cd best-restaurants (or the file name automatically generated by the download)
3. To view the downloaded files, open them in a text editor or IDE of your choice.
* if you have VSCode for example, when your terminal is within the main project directory you can open all of the files with the command:
* code .
4. If you need to install the REPL dotnet script enter the following command in your terminal: 
* dotnet tool install -g dotnet-script
5. To install the necessary dependencies, run the following commands:
* dotnet restore
* dotnet build
* dotnet run

#### If you need to install and configure MySQL:
1. Download the MySQL Community Server DMG file [here](https://dev.mysql.com/downloads/file/?id=484914) with the "No thanks, just start my download" link.
2. On the configuration page of the installer select the following options:
* Use legacy password encryption
* Set your password
3. Open the terminal and enter the command:
*'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile
4. Download the MySQL Workbench DMG file [here](https://dev.mysql.com/downloads/file/?id=484391)
5. Open Local instance 3306 with the password you set.
6. Within the BestRestaurant directory add your MySQL password to the appsettings.json file on line 3.
* "Server=localhost;Port=3306;database=best_restaurants;uid=root;pwd=YOURPASSWORDHERE;"
* Make any other changes needed if you have an alternative server, port, or uid selected. These are the default settings.

#### To create a local version of the database:
1. Open MySQL Workbench and Local Instance 3306.
2. Select the SQL + button in the top left of the navigation bar.
3. Paste the following in the query section to create the database:

CREATE DATABASE `best_restaurants` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `best_restaurants`;

CREATE TABLE `cuisines` (
  `CuisineId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`CuisineId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `restaurants` (
  `CuisineId` int(11) DEFAULT NULL,
  `Name` varchar(255) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `RestaurantId` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`RestaurantId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

4. Press the lightning bolt button to run this command.
5. If the database does not appear, right click in the schemas bar and select Refresh All.

### Known Bugs

No bugs have been identified at the time of this update.

### Support and Contact Information

Please contact me with any suggestions or questions at jhvozdovich@gmail.com. Thank you for your input!  
_Have a bug or an issue with this application? [Open a new issue](https://github.com/jhvozdovich/best-restaurants/issues) here on GitHub._

### Technologies Used

* C#
* ASP.NET Core
* ASP.NET Core MVC
* MySQL
* Entity Framework Core
* Git and GitHub

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **User enters home page** | User Input:"URL: localhost:5000/" | Output: “Welcome!” |
| **User can navigate to a Cuisines Page** | User Input:"Click: View Cuisines" | Output: “Italian, Indian, Moroccan, Japanese” |
| **If no Cuisines have been added a message appears** | User Input:"Click: View Cuisines" | Output: “You have no Cuisines listed! Add a few.” |
| **User can navigate to an Add Cuisines Page** | User Input:"Click: Add Cuisines" | Output: “Create a new Cuisine.” |
| **User can fill out the Add Cuisines Form** | User Input:"Enter New Cuisine Name: French" | Output: “Cuisines: Italian, Indian, Moroccan, Japanese, French” |
| **User can click on Cuisines to view their Restaurants** | User Input:"Click: Japanese" | Output: “Restaurants: Okinawa Teriayki” |
| **If no Restaurants have been added a message appears** | User Input:"Click: View Restaurants" | Output: “You have no Restaurants listed.” |
| **User can navigate to a create new Restaurants page for each Cuisine** | User Input:"Click: Japanese Click: Add Restaurant" | Output: “Restaurant Form" |
| **User can add a new Restaurant for each Cuisine** | User Input:"Name: Belle Epicurean, Address: 925 4th Ave" | Output: “Frech Restaurants: French Bakery, Belle Epicurean” |
| **User can view Restaurant details when clicked** | User Input:"Click: Belle Epicurean" | Output: “Restaurant Details: Name: Belle Epicurean, Address: 925 4th Ave” |
| **User can delete all Cuisines** | User Input:"Click: Delete All" | Output: “You have no Cuisines listed!” |
| **User can delete single Cuisines** | User Input:"Click: Delete Cuisine" | Output: “You have removed this Cuisine!” |
| **User can delete all Restaurants** | User Input:"Click: Delete All" | Output: “This customer has no outstanding Restaurants." |
| **User can delete single Restaurants** | User Input:"Click: Delete Restaurant" | Output: “You have removed this Restaurant!” |


#### License

This software is licensed under the MIT license.

Copyright © 2020 **_Jessica Hvozdovich and Nitun Datta_**
