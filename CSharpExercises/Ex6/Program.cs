using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    partial class Program
    {


        static void Main(string[] args)
        {
            //----- 6.2 --------------

            //Cube myCube = new Cube(2, 3, 4);
            //Cube superCube = new Cube(100, 200, 300);

            //Console.WriteLine(myCube.WriteVolume());
            //Console.WriteLine(superCube.WriteVolume());
            //--------------------------------------

            //Address homeAdress = new Address();

            //homeAdress.ZipCode = "444 55";
            //Console.WriteLine(homeAdress.ZipCode);


            // UPPGIFT med REGEX

            Address homeAdress = new Address
            {
                Street = "Tarngatan",
                StreetNumber = "7",
                City = "Stenungsund",
            };

            homeAdress.ZipCode = "44455";
            homeAdress.ZipCode = "111 22";
            homeAdress.ZipCode = "Lena";

            string strFullStreet = $"{homeAdress.Street} + {homeAdress.StreetNumber},  {homeAdress.City}"; //Lägg in {homeAdress.ZipCode} också

            string hej = homeAdress.ToString();

            Console.WriteLine(homeAdress);

            Console.ReadKey();

            //------------------------------------------

            //Uppgift 6.4 enums

            //Person lisa = new Person
            //{
            //    FirstName = "Lisa",
            //    LastName = "Larsson",
            //    Birthday = 860130,
            //    Gender = Gender.Female,
            //    FavoriteSport = Sport.Tennis,
            //};



            //Console.WriteLine(lisa);
            //Console.WriteLine();
            //Console.WriteLine("Here is a list of all sport enums:");
            //Console.WriteLine();
            //Console.WriteLine("* " + Sport.Hurling);
            //Console.WriteLine("* " + Sport.Rugby);
            //Console.WriteLine("* " + Sport.Soccer);
            //Console.WriteLine("* " + Sport.Squash);
            //Console.WriteLine("* " + Sport.Tennis);


            //Console.WriteLine();
            //Console.Write("Enter a sport: ");
            //string answer = Console.ReadLine();
            //bool sportIsMatch = false;
            //var allSports = Enum.GetValues(typeof(Sport));

            //foreach (var sport in allSports)
            //{
            //    if (answer == sport.ToString())
            //    {
            //        sportIsMatch = true;
            //    }
            //}

            //if (sportIsMatch)
            //{
            //    Console.WriteLine($"oh, i know {answer}!");
            //}
            //else
            //{
            //    Console.WriteLine($"sorry, i don't know {answer}...");
            //}

            //------------------------------------------------

            //Circle circle = new Circle(5, 6, 7);
            //Rectangle rectangle = new Rectangle(10, 20, 30, 40);
            //Triangle triangle = new Triangle(15, 25, 35, 45);

            //Console.WriteLine(circle);
            //Console.WriteLine(rectangle);
            //Console.WriteLine(triangle);


            //Uppgift Circle Bob och Lisa




            //Circle bob = new Circle("Bob", 20);
            //Circle lisa = new Circle("Lisa", 30);

            //Console.WriteLine(bob.SayHello());            
            //string stringArea = bob.WriteArea();
            //Console.WriteLine(stringArea);
            //Console.WriteLine(lisa.SayHello());
            //Console.WriteLine(lisa.WriteArea());





            //SayHello();
            //WriteArea();
        }
    }
}
