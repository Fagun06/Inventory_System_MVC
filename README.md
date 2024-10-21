
# Inventory Management System

## Project Overview
The **Inventory Management System** is a web-based application built using **ASP.NET MVC 8** and **Entity Framework** for database management. The system helps manage customers and equipment inventory, allowing for seamless interaction with the data, including adding, editing, and searching for records. It tracks the relationship between customers and the equipment they purchase, including the quantity of items bought.

## Features
- **Customer Management**: Add, view, update, and delete customers, with details such as name, mobile number, and purchased equipment.
- **Equipment Management**: Manage equipment inventory with options to add, view, edit, and delete records.
- **Search Functionality**: Search by customer name and equipment name.
- **Entity Framework for ORM**: Uses Entity Framework to manage database interactions like CRUD operations and data mapping.
- **Navigation Properties**: Manages relationships between customers and equipment using foreign keys.
- **Responsive Design**: The application is responsive and works across devices of various sizes.

## Technologies Used
- **ASP.NET MVC 8**: Backend framework used to structure the web application.
- **C#**: Language used for backend development.
- **Entity Framework Core**: For database access and management.
- **SQL Server**: Used as the database for storing customers and equipment.
- **Bootstrap**: For responsive front-end design.
- **HTML, CSS, JavaScript**: For the user interface and interactions.

## Database Structure
### Tables:
1. **Customer**:
   - `CustomerID`: Primary key.
   - `CustomerName`: Name of the customer.
   - `CustomerMobile`: Mobile number of the customer.
   - `EquipmentID`: Foreign key referencing the equipment purchased.
   - `EquiCount`: Number of equipment items purchased by the customer.

2. **Equipment**:
   - `EquipmentID`: Primary key.
   - `EquipmentName`: Name of the equipment.
   - `Quantity`: Stock available for the equipment.
   - `Date`: Date when the equipment was added to the inventory.
   - **Navigation property** to reference the customers who purchased this equipment.

### Entity Framework Code-First Migration
The database is managed through **Entity Framework Code-First** approach, where models are defined in the code and the database schema is generated accordingly.

Sample model for **Customer**:
```csharp
public class Customer
{
    public int CustomerID { get; set; }
    public string CustomerName { get; set; }
    public string CustomerMobile { get; set; }

    // Foreign key to Equipment
    public int EquipmentID { get; set; }
    public Equipment Equipment { get; set; }

    public int EquiCount { get; set; } // Number of equipment purchased
}
```

Sample model for **Equipment**:
```csharp
public class Equipment
{
    public int EquipmentID { get; set; }
    public string EquipmentName { get; set; }
    public int Quantity { get; set; }
    public DateTime Date { get; set; }

    // Navigation property to reference customers
    public ICollection<Customer> Customers { get; set; }
}
```

### Database Migrations
To create or update the database schema, use the following commands in the **Package Manager Console**:
```bash
Add-Migration Init
Update-Database
```

## Installation and Setup
1. Clone the repository:
   ```bash
   git clone https://github.com/Fagun06/Inventory_System_MVC.git
   ```
2. Open the solution in **Visual Studio**.
3. Set up the database connection string in `appsettings.json` to point to your **SQL Server**.
4. Apply migrations to create the database using **Entity Framework**:
   ```bash
   Update-Database
   ```
5. Build and run the project.

## User Interface Overview
### Equipment Management:
Users can search and manage equipment. Key features include:
- Searching by equipment name.
- Adding new equipment entries to the inventory.
- Displaying equipment details such as name, stock, and date.

### Customer Management:
Users can:
- Search by customer name.
- Add new customers and associate them with purchased equipment.
- View a list of customers and the equipment they've bought.

## Contributing
Contributions are welcome! Feel free to fork the repository, make changes, and submit a pull request.


## Repository Link
The code for this project is hosted on GitHub:
[Inventory Management System](https://github.com/Fagun06/Inventory_System_MVC.git)
