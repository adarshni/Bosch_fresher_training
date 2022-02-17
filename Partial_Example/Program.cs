using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialEmployee emp = new PartialEmployee();
            emp.FirstName = "Pranaya";
            emp.LastName = "Rout";
            emp.Salary = 100000;
            emp.Gender = "Male";
            emp.DisplayFullName();
            emp.DisplayEmployeeDetails();
            emp.inputdata();
            emp.DisplayFullName();
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();

        }
    }
}
