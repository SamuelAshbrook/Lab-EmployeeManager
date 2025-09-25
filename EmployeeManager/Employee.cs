using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager
{
    internal class Employee
    {
        // Private fields for employee details
        private string employeeName;
        private string employeeId;
        private int hoursWorked;
        private double hourlyRate;

        // Constructor to initialize employee details
        public Employee(string name, string id, int hours)
        {
            employeeName = name;
            employeeId = id;
            hoursWorked = hours;
            hourlyRate = 9.5;
        }

        // Override ToString method to display employee details
        public override string ToString()
        {
            return $"{employeeName} ({employeeId})";
        }

        // Calculate and return the employee's weekly wage
        public double CalculateWeeklyWage()
        {
            return hoursWorked * hourlyRate;
        }

        public static bool IsValidName(string name)
        {
            return name.Length > 0 && name.Length <= 50;
        }

        public static bool IsValidId(string id)
        {
            return id.Length == 3 && char.IsLetter(id[0]) && char.IsDigit(id[1]) && char.IsDigit(id[2]);
        }
    }
}
