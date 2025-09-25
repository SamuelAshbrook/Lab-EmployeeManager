using System;

namespace EmployeeManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("John Doe", 12345, 40);
            Console.WriteLine(emp.ToString());
        }
    }
}