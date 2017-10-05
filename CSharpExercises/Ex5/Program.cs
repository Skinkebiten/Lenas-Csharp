using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Ex5
{
    class Program
    {


        // Uppgift 5.2 ----------------------------------

        //static string GenerateString(string repeatme, int cycles)
        //{
        //    string result = "";

        //    Stopwatch stopwatch = new Stopwatch();
        //    stopwatch.Start();

        //    for (int i = 0; i < cycles; i++)
        //    {
        //        result = result + repeatme;

        //    }
        //    stopwatch.Stop();
        //    TimeSpan ts = stopwatch.Elapsed;

        //    //string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
        //    // ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

        //    string hej = $"{cycles} \t\t {ts}";
        //    Console.WriteLine(hej);

        //    return result;
        //}

        //static void WorkWithObjects()
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("STRING TEST");
        //    Console.ResetColor();
        //    Console.WriteLine();

        //    string repeatme = "Tennis anyone?";

        //    GenerateString(repeatme, 50);
        //    GenerateString(repeatme, 500);
        //    GenerateString(repeatme, 5000);
        //    GenerateString(repeatme, 50000);
        //}

        //public static string GenerateString_StringBuilder(string repeatme, int cycles)
        //{

        //    Stopwatch stopwatch2 = new Stopwatch();
        //    stopwatch2.Start();

        //    StringBuilder sb = new StringBuilder();
        //    //sb.Append(repeatme2.Length * cycles2).Insert(0, repeatme2, cycles2).ToString();

        //    for (int i = 0; i < cycles; i++)
        //    {
        //        sb.Append(repeatme);
        //    }

        //    stopwatch2.Stop();
        //    TimeSpan ts = stopwatch2.Elapsed;


        //    string hej = $"{cycles} \t\t {ts}";
        //    Console.WriteLine(hej);

        //    return sb.ToString();
        //}

        //public static void WorkWithObjectsStringB()
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("STRINGBUILDER TEST");
        //    Console.ResetColor();
        //    Console.WriteLine();

        //    string repeatme = "Tennis anyone?";            

        //    GenerateString_StringBuilder(repeatme, 50);
        //    GenerateString_StringBuilder(repeatme, 500);
        //    GenerateString_StringBuilder(repeatme, 5000);
        //    GenerateString_StringBuilder(repeatme, 50000);
        //}
        //------------------------------------

        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        //Uppgift 5.4

        public static string fruit = "apple";
        public static int age = 25;
        public static DateTime now = DateTime.Now;
        
        static void ChangeFruit(string fruit)
        {
            fruit = "Lemon";
        }

        static void ChangeAge(int age)
        {
            age = 30;
        }

        static void ChangeDate(DateTime date)
        {
            date = DateTime.Today;
        }

        static void ChangePoint_Struct(Point_Struct point)
        {
            point.X = 3;
            point.Y = 4;
        }

        static void Main(string[] args)
        {
            //Uppgift 5.4

            Point_Struct point = new Point_Struct();
            point.X = 8;
            point.Y = 9;

            Console.WriteLine("Before: \t\t Fruit: " + fruit);
            ChangeFruit(fruit);
            Console.WriteLine("After: \t\t\t Fruit: " + fruit);
            Console.WriteLine();

            Console.WriteLine("Before: \t\t Age: " + age);
            ChangeAge(age);
            Console.WriteLine("After: \t\t\t Age: " + age);
            Console.WriteLine();

            Console.WriteLine("Before: \t\t now: " + now);
            ChangeDate(now);
            Console.WriteLine("After: \t\t\t now: " + now);
            Console.WriteLine();

            Console.WriteLine("Before: \t\t Point_Struct: " + point.X + ", " + point.Y);
            ChangePoint_Struct(point);
            Console.WriteLine("After: \t\t\t Point_Struct: " + point.X + ", " + point.Y);
            Console.WriteLine();


            // Uppgift 5.2---------------------
            //WorkWithObjects();
            //WorkWithObjectsStringB();
            //---------------------------------------

            //---------5.5-------------------
            //log.Info("Big blue eyes");
            //log.Info("Pointy nose");
            //log.Info("Chasing mice");
            //log.Info("And digging holes");
            //Console.WriteLine("Hit enter");
            //Console.ReadLine();
            //---------------------------------


            //Uppgift 5.3

            //Point point = new Point();
            //point.X = 2;
            //point.Y = 6;

            //Console.WriteLine("Before: \t\t Point: " + point.X + ", " + point.Y);

            //ChangePoint(point);

            //Console.WriteLine("After: \t\t\t Point: " + point.X + ", " + point.Y);
            //Console.WriteLine();

            //StringBuilder sb = new StringBuilder();
            //sb.Append("Let's go dancing!");

            //Console.WriteLine("Before: \t\t StringBuilder: " + sb.ToString());

            //ChangeStringBuilder(sb);
            //Console.WriteLine("After: \t\t\t StringBuilder: " + sb.ToString());
            //Console.WriteLine();

        }


        //Uppgift 5.3

        //static void ChangePoint(Point point)
        //{
        //    point.X = 8;
        //    point.Y = 1;
        //}

        //static void ChangeStringBuilder(StringBuilder sb)
        //{
        //    sb.Append("Yes, that would be great!");
        //}

    }

    // Uppgift 5.2 

    //string repeatme = "Tennis anyone?";
    //int cycles = 5;

    //string manyResult = GenerateString_StringBuilder(repeatme, cycles);
    //Console.WriteLine(manyResult);

    //manyResult = manyResult + repeatme;

    //Stopwatch stopwatch = new Stopwatch();
    //stopwatch.Start();
    //Thread.Sleep(10000);
    //stopwatch.Start();
    //TimeSpan ts = stopwatch.Elapsed;

    //string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
    //    ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

    //Console.WriteLine("Run time " + elapsedTime);






}

