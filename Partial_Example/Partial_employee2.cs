using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Example
{
    partial class PartialEmployee
    {
        public void DisplayFullName()
        {
            Console.WriteLine(@"Full Name is :  {0} {1}", _firstname, _lastName);
        }

        public void inputdata()
        {
            Console.WriteLine("Enter emp name");
            _firstname = Console.ReadLine();
            Console.WriteLine("Enter emp last name");
            _lastName = Console.ReadLine();
            Console.WriteLine("Enter emp gender ");
            Gender = Console.ReadLine();

            Console.WriteLine("Enter emp salary");
            _salary = Convert.ToInt32(Console.ReadLine());

        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Details : ");
            Console.WriteLine(@"First Name : {0}", _firstname);
            Console.WriteLine(@"Last Name : {0}", _lastName);
            Console.WriteLine(@"Gender : {0}", _gender);
            Console.WriteLine(@"Salary : {0}", _salary);
        }
    }
}




