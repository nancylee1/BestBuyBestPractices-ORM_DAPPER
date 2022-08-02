using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using BestBuyBestPractices;
//^^^^MUST HAVE USING DIRECTIVES^^^^
#region Configuration to link to MySQL
var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
string connString = config.GetConnectionString("DefaultConnection"); // getting the connection string from our appsettings.json file
IDbConnection conn = new MySqlConnection(connString); // wrapping the connection above to an object called "conn" we create
#endregion

// EXERCISE 2 - CREATING A NEW PRODUCT UTILIZING DAPPER *******************************************

DapperDepartmentRepository repo = new DapperDepartmentRepository(conn);

Console.WriteLine("Hello user, here are the current departments:");

var depts = repo.GetAllDepartments(); // creating a variable to store the collection
foreach (var item in depts)
{
    Console.WriteLine($"Department ID: {item.DepartmentID} Name: {item.Name}");
    Console.WriteLine();
}

// Insert a new department ***********

DapperDepartmentRepository newDeptName = new DapperDepartmentRepository(conn);

Console.WriteLine("Please provide a new department name to insert: ");
var userInputDeptName = Console.ReadLine(); 

newDeptName.InsertDepartment(userInputDeptName);

var deptName = newDeptName.GetAllDepartments();
foreach (var item in deptName)
{
    Console.WriteLine($"Department Name to Insert: {item.Name}");
}

// Create a DapperProductRepository Class that conforms to the IProductRepository interface *************************

DapperProductRepository repoProd = new DapperProductRepository(conn);

Console.WriteLine("Hello user, please provide a new product's name:");
var userInput = Console.ReadLine();
Console.WriteLine("Hello user, please provide this new product's price:");
double userInputPrice = double.Parse(Console.ReadLine());
Console.WriteLine("Hello user, please provide this new product's category ID:");
int userInputCategoryID = int.Parse(Console.ReadLine());

repoProd.CreateProduct(userInput, userInputPrice, userInputCategoryID);

var products = repoProd.GetAllProducts();
foreach (var item in products)
{
    Console.WriteLine($"Product ID: {item.ProductID} Name: {item.Name} Price: { item.Price}");
    Console.WriteLine();
}

//Bonus - Create the UpdateProduct method in the DapperProductRepository class and implement in Program.cs**************************


Console.WriteLine("Hello user, please provide a product ID to update: ");
int userInputProductID = int.Parse(Console.ReadLine()); 
Console.WriteLine("Hello user, please provide an updated product's price:");
double userInputProductPrice = double.Parse(Console.ReadLine());    

repoProd.UpdateProduct(userInputProductID, userInputProductPrice);

// Extra Bonus - Create the DeleteProduct method. HINT: You will need to delete records from the Sales table and the Reviews table where that Product may be referenced. You can do this all in the DeleteProduct method you are creating.******************

Console.WriteLine("Hello user, please provide a product ID to delete: ");
int userInputDeleteProductID = int.Parse(Console.ReadLine());

repoProd.DeleteProduct(userInputDeleteProductID);