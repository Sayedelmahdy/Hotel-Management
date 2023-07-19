# Hotel Management Application - ADO.NET to Entity Framework Conversion


## Description

This project aims to convert the existing Hotel Management application from ADO.NET to Entity Framework. The Hotel Management application provides functionalities for managing reservations, client information, and kitchen orders. The application currently uses ADO.NET for database operations, and the goal is to modernize it by adopting Entity Framework, a powerful Object-Relational Mapping (ORM) framework for .NET applications.

### Features

- **User Roles:** The application supports two types of logins: **Admin** and **Kitchen**. The **Admin** role is responsible for making, updating, and deleting reservations, as well as handling payment processing for clients upon departure. The **Kitchen** role handles client food orders and updates the database accordingly.

- **Login_Manager Database:** The application includes a dedicated database named **Login_Manager** to manage user authentication and roles.

- **FrontEnd_Reservation Database:** This database contains all the necessary information related to reservations, including client details, booking dates, room preferences, and payment status.

### Conversion Process

The ADO.NET to Entity Framework conversion process involves the following steps:

1. **Database Schema Analysis:** Analyze the existing ADO.NET database schema of the original project [https://github.com/nazimamin/HotelManagement](https://github.com/nazimamin/HotelManagement) to identify the tables, relationships, and constraints.

2. **Entity Framework Configuration:** Set up the Entity Framework in the project by installing the required NuGet packages and configuring the database context.

3. **Data Model Creation:** Create the necessary data models (entities) to represent the tables in the database. Define the relationships between entities using Fluent API or Data Annotations.

4. **Repository Pattern:** Implement the repository pattern to abstract the data access layer and centralize database operations.

5. **Migrations:** Generate and apply migrations to bring the Entity Framework database schema in sync with the existing ADO.NET schema.

6. **Data Access Code Refactoring:** Replace the existing ADO.NET data access code in the original project [https://github.com/nazimamin/HotelManagement](https://github.com/nazimamin/HotelManagement) with Entity Framework's methods to perform CRUD (Create, Read, Update, Delete) operations.

7. **Unit Testing:** Conduct unit tests to ensure that the data access layer is functioning correctly with Entity Framework.


### Database

The Hotel Management System utilizes a SQL Server database to store and manage the data. The database backup files, `FrontEnd_Reservation.bak` and `Login_Manager.bak`, are included in the project repository.

To restore the database from the backup files, follow these steps:

1. Make sure you have SQL Server installed on your machine.

2. Open SQL Server Management Studio (SSMS) and connect to your SQL Server instance.

3. Right-click on "Databases" in the Object Explorer and select "Restore Database".

4. In the "Source" section, choose "Device" and click the ellipsis button (`...`) to browse for the backup file.

5. Locate and select the `FrontEnd_Reservation.bak` and `Login_Manager.bak` files from your local repository.

6. Verify the "Destination" database name and file locations.

7. Click "OK" to start the database restoration process.

8. Once the restoration is complete, the Hotel Management System should be able to connect to the database.

Please note that the exact steps may vary depending on your SQL Server version and configuration.


### Getting Started

To get started with the Hotel Management application and the conversion process, follow these steps:

1. Clone the original repository: `git clone https://github.com/nazimamin/HotelManagement`

2. Install the required NuGet packages for Entity Framework.

3. Set up the database connection string in the configuration file.

4. Apply migrations to create the Entity Framework database schema.

5. Run the application and test the functionalities.

### Contribution Guidelines

We welcome contributions to enhance the application's functionality and performance. If you wish to contribute, please follow these guidelines:

1. Fork the repository [https://github.com/Sayedelmahdy/Hotel-Management](https://github.com/Sayedelmahdy/Hotel-Management) and create a new branch for your feature or bug fix.

2. Commit your changes with descriptive commit messages.

3. Open a pull request and provide a clear explanation of your changes.

4. Ensure that your code passes all tests and does not introduce any breaking changes.

### Acknowledgements

Special thanks to my friend [Mohamed Abdulsayed](https://github.com/Abdulsayedd/Abdulsayedd) for their valuable contributions and collaboration on this project. Working together made this conversion process an enjoyable experience.


### Support and Contact

For any issues, questions, or suggestions related to the project or the conversion process, feel free to contact the maintainers:

- Sayed Elmahdy: sayed.work223@gmail.com
- Mohamed Abdelsayed: Abdulsayedd@gmail.com

## Contributions
- [Mohamed Abdelsayed](https://github.com/Abdulsayedd/Abdulsayedd)

---

We appreciate Nazimamin's initial contributions to the Hotel Management application and thank him for his work. We are committed to respecting the original work and aim to improve the application by converting it to Entity Framework.


