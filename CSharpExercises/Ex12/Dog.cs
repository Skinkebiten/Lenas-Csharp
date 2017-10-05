using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    class Dog : IAggressive, IFriendly
    {

        public void Greet()
        {
            Console.WriteLine($"The dog says bark.");
        }

        public void ThanksForDinner(string meal)
        {
            Console.WriteLine($"The dog thank you for the {meal}.");
        }

        public void ShowTeeth()
        {
            Console.WriteLine("The dog shows his teeth.");
        }

        public int Bite()
        {
            Console.WriteLine("The dog bites you!");
            Random random = new Random();
            int legs = random.Next(0, 5);
            return legs;
        }
    }
}
