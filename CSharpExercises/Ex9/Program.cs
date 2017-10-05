using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
    {
        public static string ToUpper(string s)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string bigLetters = s.ToUpper();
            Console.ResetColor();
            return bigLetters;
        }

        public static string Tripple(string s)
        {

            string tripple = s + s + s;
            Console.ResetColor();
            return tripple;
        }

        public static string AddStars(string s)
        {
            //string withStars = "";


            //int length = s.Length;

            string star = String.Join("*", s.Reverse()); ////Skitful kod!



            char[] arr = star.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);


            //foreach (char c in s)                          ///Funkar också men stjärna på slutet 
            //{
            //    withStars = withStars + c + "*";
            //}

            //return withStars;
        }

        public static void AskUserAndRespond(Func<string, string> converter)
        {
            Console.Write("Enter a string to convert: ");
            string answer = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            string namn = converter(answer);
            Console.WriteLine(namn);
            Console.ResetColor();
        }

        //Uppgift 9.3 - Events

        static void WriteLine()
        {
            Console.WriteLine("------------------------------------------");
        }

        static void GiveMeCoffee()
        {
            Console.WriteLine("Jag är sugen på kaffe, kan jag få en kopp?");
        }

        static void SetColorBlue()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }


        static void SetBackgroundYellow()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
        }



        // public delegate void MyAction(); 

        public static event Action spacePressed;


     

        static void Main(string[] args)
        {
            // Uppg. 9.3



            spacePressed += SetColorBlue;
            spacePressed += SetBackgroundYellow;
            spacePressed += WriteLine;
            spacePressed += GiveMeCoffee;
            spacePressed += GiveMeCoffee;

            Console.WriteLine("Press space to invoke methods. Press Q to quit.");
            char answer = Console.ReadKey().KeyChar;

            while (true)
            {
                if (answer == ' ')
                {
                    spacePressed.Invoke();
                    answer = Console.ReadKey().KeyChar;                    
                }
                else if (answer == 'Q')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Felaktigt val. Gör om, gör rätt.");
                    Console.ReadKey();
                    break;
                }
            }





            //--------Uppg 9.1 och 9.2

            //FileSystemWatcher fileSW = new FileSystemWatcher(@"c:\TMP");

            //Console.Write("I'm watching this folder: ");

            //fileSW.Changed += FileSW_Changed;
            //fileSW.Created += FileSW_Created;
            //fileSW.Deleted += FileSW_Deleted;
            //fileSW.Renamed += FileSW_Renamed;
            //fileSW.EnableRaisingEvents = true;
            //while (true)
            //{

            //}

            //AskUserAndRespond(ToUpper);
            //AskUserAndRespond(Tripple);
            //AskUserAndRespond(AddStars);

        }

        //private static void FileSW_Renamed(object sender, RenamedEventArgs e)
        //{
        //    Console.WriteLine("Din fil har nu bytt namn: " + e.FullPath.ToString());
        //}

        //private static void FileSW_Deleted(object sender, FileSystemEventArgs e)
        //{
        //    Console.WriteLine("Din fil är nu radderad: " + e.FullPath.ToString());
        //}

        //private static void FileSW_Created(object sender, FileSystemEventArgs e)
        //{
        //    Console.WriteLine("Din fil har nu skapats: " + e.FullPath.ToString());
        //}

        //private static void FileSW_Changed(object sender, FileSystemEventArgs e)
        //{
        //    Console.WriteLine("Din fil har nu ändrats här: " + e.FullPath.ToString());
        //}
    }
}
