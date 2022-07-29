## Table of Contents

1. [Installation Instructions](#id-section1)

2. [Capstone Requirements](#id-section2)

3. [General Information about the App](#id-section3)

4. [Miscellaneous](#id-section4)

  

<hr>

  

<div  id='id-section1'/>

  

### Installation Instructions

*The following are instructions, in accordance with the Code Louisville's Software Development [C#] Capstone Project requirements, on how to install this application.*

* *This application is developed with `.NET 6.0`. You can `git pull` the repo and then run `dotnet run` in your Visual Studio Code's terminal to launch application.*

<hr>

  

<div  id='id-section2'/>

  

### Capstone Requirements

*The following is a detailed section indicating where project requirements are met in the repository & application.*

* Has at least **5** commits on GitHub. All commits have been made directly through **Visual Studio**. &radic;

* Has a **`readme.md`** file containing a paragraph+ describing the application, the capstone requirements met, & installation instructions. &radic;

* Has at least one class & at least one object of that class populated with data. Data must be used or displayed in the application. &radic;
`PersonController is used to create classes for each individual person in the application to list, create, edit, & delete.`

* Has at least 3 functions or methods with at least one returning a value that is used in the application. &radic;

* **Create an additional class which inherits one or more properties from its parent**
`PersonController inheriting from Controller`

* **Read data from an external file, such as text, JSON, CSV, etc and use that data in your application**
`Reading data from a SQLite database file.`

* **Use a LINQ query to retrieve information from a data structure (such as a list or array) or file**

* **Calculate and display data based on an external factor (ex: get the current date, and display how many days remaining until some event)**
`Calculating timelapse (in years) since burial in the localhost/Person page.`

* **Visualize data in a graph, chart, or other visual representation of data - displaying data in a table**
`The table in the localhost/Person page.`

* **Build a conversion tool that converts user input to another type and displays it (ex: converts cups to grams)**
`Taking the database data regarding birth day, month, year & death day, month, year & converting it into a DateTime type.`

<hr>

<div  id='id-section3'/>

  

### General Information about the Application

This application is a short application that helps manage those people buried at the Greenhaven Islamic Cemetery. For the sake of the capstone project, this project is a general CRUD application, but will eventually become one where an user 
would need to be authenticated before being able to access the data stored in the SQLite database.

This application is programmed using **`C#`** & **`EF Core`**.

<hr>

<div  id='id-section4'/>

  

### Miscellaneous