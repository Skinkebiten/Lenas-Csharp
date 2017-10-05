using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Ex8
{
    class LenaExceptions : Exception
    {
    }


    class Program
    {








        static void Main(string[] args)
        {
            //8.3

            while (true)
            {
                Console.Write("Enter a list of animals (use comma as a separator): ");
                string animalAnswer = Console.ReadLine();

                char[] separator = { ',' };
                string[] animalArray = animalAnswer.Split(separator);


                bool exceptionthrown = false;
                while (!exceptionthrown)
                {

                    try
                    {

                        foreach (var animal in animalArray)
                        {

                            if (animal.Length < 2)
                            {
                                throw new Exception("Animal name must contain more than two letters.");
                            }
                            else if (animal.Length > 20)
                            {
                                throw new Exception("Animal name is too long.");
                            }
                            else if (animal.All(Char.IsDigit))
                            {
                                throw new Exception("Animal name must contains letters");
                            }
                            else if (!animal.All(Char.IsLetter))
                            {
                                throw new Exception("Animal contain invalid letters.");
                            }
                            else if (animal.All(Char.IsWhiteSpace))
                            {
                                throw new Exception("No animal entered.");
                            }
                        }
                    }
                    catch (Exception wrong)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(wrong.Message);
                        Console.WriteLine();
                        Console.ResetColor();
                        exceptionthrown = true;


                    }
                    break;
                }
                
                if (exceptionthrown == true)
                {
                    continue;
                }
                else if (exceptionthrown == false)
                {
                    Console.WriteLine();
                    Console.WriteLine($"There are {animalArray.Length} animals in the list.");
                    Console.WriteLine();
                    break;
                }
            }


            //----------------------------

            //bool exceptionthrown = false;
            //while (!exceptionthrown)
            //{
            //    try
            //    {
            //        // Do magic here
            //    }
            //    catch (Exception)
            //    {
            //        exceptionthrown = true;
            //        throw;
            //    }
            //}

            //8.3?


            //Console.Write("Enter a list of animals (use comma as a separator): ");
            //animalAnswer = Console.ReadLine();

            //int countAnimals = animalArray.Length;
            //Console.WriteLine($"There are {countAnimals} animals in the list.");

            //----------------------------

            //Uppgift 8.2

            //Console.Write("Enter a file name: ");
            //string fileName = Console.ReadLine();

            //try
            //{
            //    File.Create(fileName);

            //}
            //catch (UnauthorizedAccessException a)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine(a.Message.ToString());
            //    //Console.WriteLine("You are not authorized to create this file.");
            //    Console.ResetColor();
            //}

            //try
            //{
            //    File.CreateText(fileName);
            //}
            //catch (Exception)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("You are not authorized to create this textfile.");
            //    Console.ResetColor();
            //}

            //try
            //{
            //    System.IO.Directory.CreateDirectory(fileName);
            //}
            //catch (DirectoryNotFoundException)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("You are not authorized to create this folder.");
            //    Console.ResetColor();
            //}

            //try
            //{
            //    File.CreateText(fileName);
            //}
            //catch (InvalidDataException data)
            //{

            //    Console.WriteLine(data.Message.ToString());
            //}


            // Uppgift 8.1

            //Console.WriteLine("The chocolate contains 24 pieces.");
            //Console.Write("How many want to share?: ");
            //decimal people = Convert.ToDecimal(Console.ReadLine());



            //try
            //{
            //    decimal pieces = 24 / people;
            //    Console.WriteLine($"Everyone gets {pieces} pieces.");

            //}
            ////catch (DevodeByZeroException ex Exception)
            ////{
            ////    Console.WriteLine("Fel!");

            ////}
            //catch (Exception)
            //{
            //    Console.WriteLine();
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Zero people can't devide a chocolate.");
            //    Console.ResetColor();                
            //}
        }
    }
}
