using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    // ----------------------------- 12.2------------------------------
    public interface IFriendly
    {
        void Greet();
        void ThanksForDinner(string meal);
    }

    public interface IAggressive
    {
        void ShowTeeth();
        int Bite();
    }

    class Program
    {
        static void TypeInWhite(string header)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(header);
            Console.ResetColor();
        }


        //-------------------------12.1-----------------------------

        

        static void DisplayArrayOfRockStars(string[] rockstars)
        {
            foreach (var rockstar in rockstars)
            {
                Console.WriteLine("* " + rockstar);
                
            }
        }

        static void DisplayListOfRockStars(List<string> rockstars)
        {
            foreach (var rockstar in rockstars)
            {
                Console.WriteLine("* " + rockstar);
                
            }
        }

        static void DisplayWithIEnumerable(IEnumerable<string> rockstars)
        {
            foreach (var rockstar in rockstars)
            {
                Console.WriteLine("* " + rockstar);
            }
        }





        //-----------------------12.2---------------------------------
        public static void DoNiceThings(IFriendly animal)
        {
            animal.Greet();
            animal.ThanksForDinner("mouse");
        }

        public static void DoMeanThings(IAggressive animal)
        {
            int legs = 0;

            animal.ShowTeeth();
            animal.Bite();
            Console.WriteLine($"You lost {legs} legs!");
        }


        static void Main(string[] args)
        {
            //-------------------------12.1------------------------------

            string[] rockstarsArray = new string[] { "Jim Morrison", "Ozzy Osborne", "David Bowie", "Freddie Mercery" };

            List<string> rockstarsList = new List<string> { "Jim Morrison", "Ozzy Osborne", "David Bowie", "Freddie Mercery" };


            TypeInWhite("Array");
            DisplayArrayOfRockStars(rockstarsArray);
            Console.WriteLine();

            TypeInWhite("List");
            DisplayListOfRockStars(rockstarsList);
            Console.WriteLine();

            TypeInWhite("IE Array");
            DisplayWithIEnumerable(rockstarsArray);
            Console.WriteLine();

            TypeInWhite("IE List");
            DisplayWithIEnumerable(rockstarsList);
            Console.WriteLine();



            //--------------------12.2-----------------------------

            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("DoNiceThings");
            //Console.ResetColor();
            //var dog1 = new Dog();
            //DoNiceThings(dog1);

            //Console.WriteLine();

            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("DoMeanThings");
            //Console.ResetColor();
            //DoMeanThings(dog1);

            //Console.WriteLine();

            //Console.ForegroundColor = ConsoleColor.White;
            //Console.WriteLine("DoNiceThings");
            //Console.ResetColor();
            //var cat1 = new Cat();
            //DoNiceThings(cat1);

            //Console.WriteLine();


        }
    }
}
