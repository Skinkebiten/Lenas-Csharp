using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        //Uppgift 10.3

        //static List<string> ListOfManyNames()
        //{

        //List<string> nameList = new List<string>();
        //Console.WriteLine("Enter name: ");
        //Console.ForegroundColor = ConsoleColor.Green;
        //string input = Console.ReadLine();
        //Console.ResetColor();
        //nameList.Add(input);


        //while (input != "Quit")
        //{
        //    Console.WriteLine("Enter name: ");
        //    input = Console.ReadLine();
        //}

        //if (input == "Quit")
        //{
        //    foreach (var name in nameList)
        //    {
        //        Console.ForegroundColor = ConsoleColor.White;
        //        Console.WriteLine("Name: " + name);
        //        Console.ResetColor();
        //    }
        //}


        //}


        //Uppgift 10.2

        //private static void ThreeNamesWithList()
        //{
        //    Console.Write("Enter your name: ");
        //    string name = Console.ReadLine();
        //    Console.Write("Enter your name: ");
        //    string name2 = Console.ReadLine();
        //    Console.Write("Enter your name: ");
        //    string name3 = Console.ReadLine();

        //    List<string> names = new List<string>();
        //    names.Add(name);
        //    names.Add(name2);
        //    names.Add(name3);

        //    foreach (var row in names)
        //    {
        //        Console.WriteLine("Name: " + row);
        //    }
        //}

        // Uppgift 10.1

        //public static void ThreeNamesWithArray()
        //{

        //Console.Write("Enter your name: ");            
        //string name = Console.ReadLine();
        //Console.Write("Enter your name: ");
        //string name2 = Console.ReadLine();
        //Console.Write("Enter your name: ");
        //string name3 = Console.ReadLine();

        //string[] arrayNames = new string[3];
        //arrayNames[0] = name;
        //arrayNames[1] = name2;
        //arrayNames[2] = name3;

        //foreach (var names in arrayNames)
        //{
        //    Console.WriteLine(names);
        //}

        //Förslag 2

        //for (int i = 0; i < arrayNames.Length; i++)
        //{           
        //    Console.WriteLine(arrayNames[i]);
        //}








        static void Main(string[] args)
        {

            //Uppgift 10.4

            //List<string> nameList = new List<string>();
            //Console.Write("Enter name: ");
            //Console.ForegroundColor = ConsoleColor.Green;
            //string input = Console.ReadLine();
            //Console.ResetColor();
            //nameList.Add(input);

            //while (input != "Quit")
            //{
            //    Console.Write("Enter name: ");
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    input = Console.ReadLine();
            //    Console.ResetColor();
            //    nameList.Add(input);
            //}

            //if (input == "Quit")
            //{
            //    nameList.Sort();
            //    nameList.Remove("Quit");
            //    nameList.RemoveAt(nameList.Count - 1);
            //    nameList.Remove(nameList[0]);

            //    foreach (var name in nameList)
            //    {
            //        Console.ForegroundColor = ConsoleColor.White;
            //        Console.WriteLine("Name: " + name);
            //        Console.ResetColor();
            //    }
            //}

            //Uppgift 10.3

            //List<string> nameList = new List<string>();
            //Console.Write("Enter name: ");
            //Console.ForegroundColor = ConsoleColor.Green;
            //string input = Console.ReadLine();
            //Console.ResetColor();
            //nameList.Add(input);


            //while (input != "Quit")
            //{
            //    Console.Write("Enter name: ");
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    input = Console.ReadLine();
            //    Console.ResetColor();
            //    nameList.Add(input);
            //}

            //if (input == "Quit")
            //{
            //    foreach (var name in nameList)
            //    {
            //        Console.ForegroundColor = ConsoleColor.White;
            //        Console.WriteLine("Name: " + name);
            //        Console.ResetColor();
            //    }
            //}

            //ListOfManyNames();

            //Uppgift 10.1
            //ThreeNamesWithArray();

            // Uppgift 10.2
            //ThreeNamesWithList();









            //Uppgift 10.5 Dictionary - Avklarad!

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            while (true)
            {
                Console.Write("Enter a product id and name (separate witch comma e.g. 10,Apple): ");
                string answer = Console.ReadLine();


                if (string.IsNullOrEmpty(answer))
                {
                    //Console.ForegroundColor = ConsoleColor.Red;
                    //Console.WriteLine("No input entered.");
                    //Console.ResetColor();
                    break;
                }
                else
                {
                    char separator = ',';
                    string[] split = answer.Split(separator);
                    int id = 0;

                    try
                    {
                        id = int.Parse(split[0]);

                    }
                    catch (FormatException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input.");
                        Console.ResetColor();
                        continue;
                    }
                    try
                    {

                        string productName = split[1];


                        if (dictionary.ContainsKey(id))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ID already exsist.");
                            Console.ResetColor();
                        }
                        else if (dictionary.ContainsValue(productName))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Product name already exsist.");
                            Console.ResetColor();
                        }
                        else if (split.Length < 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input");
                            Console.ResetColor();
                        }
                        else
                        {
                            dictionary.Add(id, productName);
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input.");
                        Console.ResetColor();
                        continue;
                    }

                }
            }
            foreach (KeyValuePair<int, string> item in dictionary)
            {
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(item.Key + " " + item.Value);
                Console.ResetColor();
            }
            //_---------------------------------------

            //while true
            //is string is null - break;
            //containsKey

            //------------------Kopia-----------------------

            //Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //while (true)
            //{
            //    Console.Write("Enter a product id and name (separate witch comma e.g. 10,Apple): ");
            //    string answer = Console.ReadLine();


            //    if (string.IsNullOrEmpty(answer))
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        char separator = ',';
            //        string[] split = answer.Split(separator);

            //        int id = int.Parse(split[0]);
            //        string productName = split[1];
            //        if (dictionary.ContainsKey(id))
            //        {

            //            Console.WriteLine("ID already exsist.");
            //        }
            //        else if (dictionary.ContainsValue(productName))
            //        {
            //            Console.WriteLine("Product name already exsist.");
            //        }
            //        else if (split.Length < 2)
            //        {
            //            Console.WriteLine("Invalid input");
            //        }
            //        else
            //        {
            //            dictionary.Add(id, productName);
            //        }
            //    }
            //}
            //foreach (KeyValuePair<int, string> item in dictionary)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine(item.Key + " " + item.Value);
            //    Console.ResetColor();
            //}

            //-------------------------------------------------------








            //Uppgift 3a Grisar med hattar

            //int[] pig = new int[8];
            //pig[1] = 12;

            //Uppgift 3b Feta katter i lådor

            //bool[] box = new bool[5];
            //box[2] = true;
            //box[3] = true;

            //Uppgift 4 Hästar med smeknamn

            //string[][] horse = new string[5][];
            //horse[1] = new string[] { "Scat Daddy", "Go for gin" };

            //Uppgift 5 Spelbräden, bräda 3 har 8 mynt på plats 30,40

            //int[][][] gameBoard = new int[4][][];
            // gameboard [3][100,100]
            //gameboard [3] [30, 40] = 8;
            //gameBoard[2][30][40] = 8;
            //

            //Uppgift 6 Tre skärmar med 300x200 pixlar. Skärm tre pixel 50,100 är magenta

            //string[][][][] screen = new string[3][300][200][4];
            //screen[2][50][100][1] = "Magenta";



            //enum - color var screen new color [3,30,200]
            //screen[1, 50, 100] = Color.Magenta;


        }

    }
}
