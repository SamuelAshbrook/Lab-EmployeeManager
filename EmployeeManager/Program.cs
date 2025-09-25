using EmployeeManager;
using System;

string name = "";
string id = "";

// Get employee details from user input
while (true)
{
    Console.Write("Employee Name: ");
    name = Console.ReadLine();
    if (Employee.IsValidName(name))
    {
        break; // Valid name, exit the loop
    }
    else
    {
        Console.WriteLine("Invalid name. Please enter a name between 1 and 50 characters.");
    }
}

while (true)
{
    Console.Write("Employee ID: ");
    id = Console.ReadLine();

    // Validate that the ID has a letter followed by two digits
    if (Employee.IsValidId(id))
    {
        break; // Valid ID, exit the loop
    }
    else
    {
        Console.WriteLine("Invalid ID format. Please enter a letter followed by two digits (e.g. S29).");
    }
}

Console.Write("Hours Worked: ");
int hours = int.Parse(Console.ReadLine());

// Create an Employee object
Employee employee = new Employee(name, id, hours);

// Display employee weekly wage
Console.WriteLine($"The weekly wage is £{employee.CalculateWeeklyWage():F2}");
