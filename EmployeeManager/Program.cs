using EmployeeManager;
using System;

// Get employee details from user input
Console.Write("Employee Name: ");
string name = Console.ReadLine();

string id;

while (true)
{
    Console.Write("Employee ID: ");
    id = Console.ReadLine();

    // Validate that the ID has a letter followed by two digits
    if (id.Length == 3 && char.IsLetter(id[0]) && char.IsDigit(id[1]) && char.IsDigit(id[2]))
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
