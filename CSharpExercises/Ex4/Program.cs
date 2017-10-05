using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {

        public static char AskUserForSeparator()
        {
            char separator;
            bool parsesuccess = false;

            do
            {
                Console.Write("Which separator do you want to use (default is comma) ? ");
                string answer = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(answer))
                {
                    answer = ",";
                }
                parsesuccess = char.TryParse(answer, out separator);
            } while (!parsesuccess);
            return separator;
        }

        public static bool AskUserForErrorMessage()
        {
            bool wantError = false;

            Console.Write("Do you want to see error messages (default is yes) ? ");
            string answer = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(answer))
            {
                answer = "yes";
            }
            answer = answer.ToLower();

            if (answer == "yes")
            {
                wantError = true;
            }

            else if (answer == "no")
            {
                wantError = false;
            }
            return wantError;
        }

        //bool validAnswer = false;
        //bool wantErrorMessage = false;
        //do
        //{
        //    Console.Write("Do you want to see error messages (default is yes) ? ");
        //    string answer = Console.ReadLine();
        //    if (string.IsNullOrWhiteSpace(answer))
        //    {
        //        answer = "yes";
        //    }
        //    answer = answer.ToLower();

        //    if (answer == "yes")
        //    {
        //        wantErrorMessage = true;
        //        validAnswer = true;
        //    }
        //    else if (answer == "no")
        //    {
        //        wantErrorMessage = false;
        //        validAnswer = true;
        //    }
        //    else
        //    {
        //        validAnswer = false;
        //    }

        //} while (!validAnswer);

        //return wantErrorMessage;
        //}

        public static string GetInputFromUser() //Tar in alla namn från användaren
        {
            Console.Write("Enter a list of names: ");
            string inputNames = Console.ReadLine();
            return inputNames;
        }


        public static string[] CreateArrayOfPeople(string inputNames, char separator) //Tar bort komma och gör ickesvar till null
        {
            if (inputNames == "")
            {
                return null;
            }

            string[] peopleArray = inputNames.Split(separator);
            return peopleArray;
        }

        static void CleanUpArray(string[] peopleArray) //Tar bort alla blanksteg
        {
            for (int i = 0; i < peopleArray.Length; i++)
            {
                peopleArray[i] = peopleArray[i].Trim();


            }
        }



        static bool PeopleArrayIsValid(string[] peopleArray) //Skickar felmeddelande om null, kort namn eller siffra
        {
            if (peopleArray == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The list don't contain any names");
                Console.ResetColor();
                return false;
            }

            foreach (var person in peopleArray)
            {
                if (person.Length < 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A person can only have 2-9 letters");
                    Console.ResetColor();
                    return false;
                }
                else if (person.All(Char.IsDigit))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A name only contains letters");
                    Console.ResetColor();
                    return false;
                }

            }
            return true;
        }

        static bool PeopleArrayIsValidNoError(string[] peopleArray) //Skickar felmeddelande om null, kort namn eller siffra
        {
            if (peopleArray == null)
            {

                return false;
            }

            foreach (var person in peopleArray)
            {

                if (person.Length < 2)
                {

                    return false;
                }
                else if (person.All(Char.IsDigit))
                {

                    return false;
                }

            }
            return true;
        }

        static void RespondToUser(string[] peopleArray) // Skriver ut namnen på skärmen
        {
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < peopleArray.Length; i++)
            {
                Console.WriteLine($"***SUPER-{peopleArray[i].ToUpper()}***");

            }
            Console.ResetColor();
        }


        //string[] list = listOfNames.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        //    // Report to user

        //    if (list.Length == 0)
        //    {
        //        ch.WriteGreen("No people in the list");
        //        return;
        //    }

        //    foreach (string person in list)
        //    {
        //        ch.WriteGreen($"***SUPER-{person.ToUpper()}***");
        //    }





        static void Main(string[] args)
        {
            char separat = AskUserForSeparator();
            bool errorMessage = AskUserForErrorMessage();


            while (errorMessage == false)
            {
                string namesMain = GetInputFromUser();

                string[] arrayMain = CreateArrayOfPeople(namesMain, separat);

                bool isValid = PeopleArrayIsValidNoError(arrayMain);

                while (isValid == false)
                {
                    namesMain = GetInputFromUser();

                    arrayMain = CreateArrayOfPeople(namesMain, separat);

                    CleanUpArray(arrayMain); //Tar bort blanksteg. Den har gjort sitt jobb, låt vara.

                    isValid = PeopleArrayIsValidNoError(arrayMain);
                }

                CleanUpArray(arrayMain); //Tar bort blanksteg. Den har gjort sitt jobb, låt vara.
                RespondToUser(arrayMain);
                break;
            }

            while (errorMessage == true)
            {
                string namesMain = GetInputFromUser();

                string[] arrayMain = CreateArrayOfPeople(namesMain, separat);

                bool isValid = PeopleArrayIsValid(arrayMain);

                while (isValid == false)
                {
                    namesMain = GetInputFromUser();

                    arrayMain = CreateArrayOfPeople(namesMain, separat);

                    CleanUpArray(arrayMain); //Tar bort blanksteg. Den har gjort sitt jobb, låt vara.

                    isValid = PeopleArrayIsValid(arrayMain);
                }

                CleanUpArray(arrayMain); //Tar bort blanksteg. Den har gjort sitt jobb, låt vara.
                RespondToUser(arrayMain);
                break;

            }



            //isValid = PeopleArrayIsValid(arrayMain);


            //while (errorMessage == true)
            //{
            //    bool isValid = PeopleArrayIsValid(arrayMain);

            //    while (isValid == false)
            //    {
            //        namesMain = GetInputFromUser();

            //        arrayMain = CreateArrayOfPeople(namesMain, separat);

            //        CleanUpArray(arrayMain); //Tar bort blanksteg. Den har gjort sitt jobb, låt vara.

            //        isValid = PeopleArrayIsValid(arrayMain);
            //    }
            //}











        }
    }
}
