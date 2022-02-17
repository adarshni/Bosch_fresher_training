using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Example
{
    public partial class PartialEmployee
    {
        public string _firstname;
        private string _lastName;
        public double _salary;
        public string _gender;
        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

    }
}


