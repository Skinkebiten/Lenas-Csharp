using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Person
    {
    public string FirstName { get; set;}
    public string LastName { get; set; }
    public int Birthday { get; set; }
    public Gender Gender { get; set;}
    public Sport FavoriteSport { get; set; }



    //public Person(string firstN, string LastN, int bDay, string gendr, string fSport)
    //{
    //    firstName = firstN;
    //    lastName = LastN;
    //    birthday = bDay;
    //    gender = gendr;
    //    favoriteSport = fSport;
    //}


    public override string ToString()
    {

            return string.Format($"{FirstName} is a {Gender.Female}. \n{FirstName} likes to play {Sport.Tennis} \n{FirstName} don't like to play {Sport.Hurling}");
            

            //public string AskForSport()
            //{
            //    Console.WriteLine("Enter sport: ");
                
            //}

    }
}
}
