using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_064
{
    class Customer
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        private string _FirstName;
        public string FirstName 
        {
            get { return "Mrs. " + _FirstName; }
            set { _FirstName = value; } 
        }
        public string City { get; set; }
    }
}
