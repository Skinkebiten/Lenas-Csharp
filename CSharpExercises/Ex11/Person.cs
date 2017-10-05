using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    public class Person
    {
        public string FirstName { get; set; }            
        public Gender Gender { get; set; }
        public int Age { get; set; }

        //public int Id { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string Email { get; set; }
        //public Gender Gender { get; set; }
        //public int Age { get; set; }
    }

    public enum Gender
    {
        Female, Male, Unknown
    }
}
