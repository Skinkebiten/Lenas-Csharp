using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {


        static void Main(string[] args)
        {

                       



            //Uppgift 3.8

            //Console.Write("Enter a number between 1-20: ");
            //int inputNumber = int.Parse(Console.ReadLine());


            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i > 7)
            //    {
            //       continue; // Continue loopar upp till 7 (då if-påståendet blir sant) sedan går den vidare (continue), finns den inte med loopar den upp till 10

            //    }                
            //    Console.WriteLine(i); //Om inne i if-måsvingar loopar 7-10, utanför 1-7
            //}

            //while (inputNumber <= 20)
            //{
            //    Console.WriteLine(inputNumber++);
            //    //continue;
            //}


            //Uppgift 3.7

            //Console.Write("Enter a number: ");
            //int yourNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.Green;

            //string Hej = (yourNumber >= 20) ? "It is higer or equal to 20." : "It is lower than 20.";

            //Console.WriteLine(Hej);

            //Console.ResetColor();


            //if(yourNumber >=20)
            //{
            //    Hej = "Positive";
            //} else
            //{
            //    Hej = "Negative";
            //}

            //Uppgift 3.6

            //Console.Write("Skriv ett tal: ");
            //int tal = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Skriv ett tal vi ska jämföra ditt första tal med: ");
            //int jamfor = Convert.ToInt32(Console.ReadLine());

            //if (tal < jamfor)
            //{
            //    Console.WriteLine("Ditt tal var samma eller längre än {0}...", jamfor);
            //}
            //else if (tal > jamfor)
            //{
            //    Console.WriteLine("Ditt tal var högre än {0}!", jamfor);
            //}
            //else
            //    Console.WriteLine("Ditt tal är {0}!", jamfor);

            //Console.Write("Nu ska vi leka gissa talet! Vilket tal tänker jag på mellan 1-100?: ");
            //int talForslag = Convert.ToInt32(Console.ReadLine());

            //while (talForslag != 39)
            //{
            //    if (talForslag < 39)
            //    {
            //        Console.WriteLine("Fel, gissa igen men på ett högre tal: ");
            //        string nastaTal = Console.ReadLine();
            //        talForslag = Convert.ToInt32(nastaTal);
            //    }
            //    else if (talForslag > 39)
            //    {
            //        Console.WriteLine("Fel, gissa igen men på ett lägre tal: ");
            //        string nastaTal = Console.ReadLine();
            //        talForslag = Convert.ToInt32(nastaTal);
            //    }

            //}
            //Console.WriteLine("Grattis, du gissade rätt!");






            //UPPGIFT 3.4 och 3.5

            //Console.Write("Enter names in a list (like Lisa,Maria,Peter): " );
            //string givenNames = Console.ReadLine();

            //char[] removeChar = {','};
            //string[] totalNames = givenNames.Split(removeChar);

            ////Console.WriteLine("Original text: '{0}'", givenNames);           
            ////Console.WriteLine("{0} words in text:", totalNames.Length);

            //Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.Green;

            //foreach(string withLastname in totalNames)
            //{
            //    if (withLastname == "Zelda") break;
            //    Console.WriteLine(withLastname + " Boman");
            //}
            //Console.ResetColor();
            //Console.WriteLine();


            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //Console.Write("Times to repeat: ");
            //int times = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();

            //Console.ForegroundColor = ConsoleColor.Green;

            //for (int i = 0; i < times; i++)
            //{
            //    Console.WriteLine("Your name is " + name);
            //}

            //Console.ResetColor();
            //Console.WriteLine();




            //Console.Write("Enter your name: ");
            //string name2 = Console.ReadLine();

            //Console.Write("How many rows: ");
            //int row = Convert.ToInt32(Console.ReadLine());

            //Console.Write("How many columns: ");
            //int column = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine();

            //Console.ForegroundColor = ConsoleColor.Green;

            //string[,] karta = new string[row, column];


            //for (int i = 0; i < row; i++)
            //{

            //    for (int j = 0; j < column; j++)
            //    {
            //        karta[i, j] = name2;

            //        Console.Write(name);
            //    }
            //    Console.WriteLine();
            //}

            //Console.ResetColor();
            //{

            //}


            //Console.Write("When did you go to bed yesterday? ");
            //int bedTime = Convert.ToInt32(Console.ReadLine());

            //Console.Write("When did you wake up? ");
            //int wakeUp = Convert.ToInt32(Console.ReadLine());

            //int sleepTime = ((24 + wakeUp) - bedTime);   


            //if (sleepTime < 7)
            //{ 
            //    Console.WriteLine("You only slept for " + sleepTime + " hours. Go back to bed!");
            //}

            //else if (sleepTime == 8)
            //{
            //    Console.WriteLine("You have slept well. (" + sleepTime + " hours)");
            //}

            //else if (sleepTime > 9)
            //{
            //    Console.WriteLine("You have slept " + sleepTime + " hours. Thats a lot!");
            //}

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //Console.Write("Times to repeat: ");
            //int times = Convert.ToInt32(Console.ReadLine());

            //int totalTime = times - 1;

            //string name2 = $"Your name is {name}";

            //while (totalTime >= 0) 
            //{
            //    Console.WriteLine("Your name is {0}", name);
            //    Console.WriteLine("Your name is " + name);
            //    Console.WriteLine(name2);
            //    totalTime--;
            //}

            //while (true)
            //{
            //    if (totalTime >= 0)
            //    {
            //        Console.WriteLine(name2);
            //        totalTime--;
            //    }

            //}


        }
    }
}
