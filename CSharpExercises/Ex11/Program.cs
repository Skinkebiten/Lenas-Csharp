using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void TypeInWhite(string header)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(header);
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            //---Uppgift 11.2------

            var parser = new Parser();
            string personShort = @"C:\Users\lena.fridlund\Downloads\PersonShort.csv";

            List<Person> list = parser.CreateListOfNames(personShort);

            TypeInWhite("Hela listan");
            foreach (var person in list)
            {
                Console.WriteLine(person.FirstName + "\t\t " + person.Age + "\t " + person.Gender);
            }
            Console.WriteLine(  );

            TypeInWhite("Sorterad efter ålder");
            list = list.OrderBy(element => element.Age).ToList();
            foreach (var person in list)
            {
                Console.WriteLine(person.FirstName + "\t\t " + person.Age + "\t " + person.Gender);
            }
            Console.WriteLine();

            TypeInWhite("Sorterad på förnamn");
            list = list.OrderBy(element => element.FirstName).ToList(); //Element och x som i förra uppgiften betyder samma sak
            foreach (var person in list)
            {
                Console.WriteLine(person.FirstName + "\t\t " + person.Age + "\t " + person.Gender);
            }
            Console.WriteLine();

            TypeInWhite("Män äldre än 35 år");
            list = list.OrderBy(x => x.Age != 35 ? x.Age : int.MaxValue).ToList();  //Funkar inte

            foreach (var person in list)
            {
                Console.WriteLine(person.FirstName + "\t\t " + person.Age + "\t " + person.Gender);
            }
            Console.WriteLine();

            //---Uppgift 11.1

            //var parser = new Parser();

            //string personShort = @"C:\Users\lena.fridlund\Downloads\PersonShort.csv";

            //List<string> list = parser.CreateListOfNames(personShort);
            //TypeInWhite("Vanlig lista");
            //foreach (var person in list)
            //{
            //    Console.WriteLine(person);
            //}
            //Console.WriteLine();

            //TypeInWhite("Sorterad efter namn");
            //list = list.OrderBy(x => x.Substring(0)).ToList();
            //foreach (var person in list)
            //{
            //    Console.WriteLine(person);
            //}
            //Console.WriteLine();

            //TypeInWhite("Börjar på J");            
            //list = list.Where(y => y.StartsWith("J")).ToList();
            //foreach (var person in list)
            //{
            //    Console.WriteLine(person);
            //}
            //Console.WriteLine();

            //TypeInWhite("Börjar på J i versaler");
            //list = list.Where(y => y.StartsWith("J")).ToList();
            //foreach (var person in list)
            //{
            //    Console.WriteLine(person.ToUpper());
            //}
            //Console.WriteLine();

        }
    }
}
