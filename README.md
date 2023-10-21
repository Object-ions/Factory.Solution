# _Dr. Sillystringz Factory Management System_

#### By _**Moshe Atia**_

#### _This web application will allow the user, a factory manager, to manage machines and engineers in a factory environment._

## Technologies Used

- _C#_
- _HtmL_
- _css_
- _.Net 6.0_
- _ASP.NET Core MVC 6.0_
- _Entity Framework Core_

## Description

The Factory Management System is an ASP.NET Core MVC web application designed to track machines and the engineers who are licensed to work with them. Users can add new machines, new engineers, and assign which engineer is licensed to work on which machine.

## Setup/Installation Requirements

Installing/Configuring MySQL:

1. Follow the instructions on this <a href="https://old.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql">page</a> for installing and configuring MySQL.

Installing dotnet-ef:

1. Run the following command to globally install dotnet-ef tools which will allow you to create migrations and create databases:
   `$ dotnet tool install --global dotnet-ef --version 6.0.0`

Cloning the Repo:

1. Open Terminal.
2. Change your directory to where you would want the cloned directory.
3. Input the following command into your terminal:  
   `$ git clone https://github.com/Object-ions/Factory.Solution.git`
4. Using the terminal, navigate to the production directory: "Clinic" and create a new file called appsettings.json
5. Within appsettings.json, put in the following code while also replacing the following values with your own values as shown below the code snippet:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

- [YOUR-USERNAME-HERE] with your username
- [YOUR-PASSWORD-HERE] with your password
- [YOUR-DB-NAME] with the name of your database

Running the program:

1. Navigate to the project's production directory "Factory" using the terminal.
2. Run the following command to update the database:  
   `$ dotnet ef database update`
3. Within the command line, run the command `$ dotnet watch run` to compile and execute the console application in developer mode.

## Available Routes

### Engineers

- **List all engineers:**  
  `GET /Engineers`
- **View engineer details:**  
  `GET /Engineers/Details/{id}`
- **Add a new engineer:**  
  `GET /Engineers/Create` (form display)  
  `POST /Engineers/Create` (data submission)

- **Edit an engineer:**  
  `GET /Engineers/Edit/{id}` (form display)  
  `POST /Engineers/Edit/{id}` (data submission)

- **Delete an engineer:**  
  `GET /Engineers/Delete/{id}` (confirmation display)  
  `POST /Engineers/Delete/{id}` (deletion action)

### Machines

- **List all machines:**  
  `GET /Machines`
- **View machine details:**  
  `GET /Machines/Details/{id}`
- **Add a new machine:**  
  `GET /Machines/Create` (form display)  
  `POST /Machines/Create` (data submission)

- **Edit a machine:**  
  `GET /Machines/Edit/{id}` (form display)  
  `POST /Machines/Edit/{id}` (data submission)

- **Delete a machine:**  
  `GET /Machines/Delete/{id}` (confirmation display)  
  `POST /Machines/Delete/{id}` (deletion action)

## Known Bugs

- _styling bug know for the "Edit" View on "Engineers" side._

## License

MIT License

Copyright (c) 2023 Moshe Atia

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
