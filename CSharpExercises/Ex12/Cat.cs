using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    class Cat : IFriendly
    {
        public void Greet()
        {
            Console.WriteLine("The cat says miao.");
        }

        public void ThanksForDinner(string meal)
        {
            Console.WriteLine($"The cat says thank you for the {meal}.");
        }
    }
}
