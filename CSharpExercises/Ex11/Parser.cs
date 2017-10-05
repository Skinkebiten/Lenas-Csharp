using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex11
{
    public class Parser
    {
        public List<Person> CreateListOfNames(string fileName)
        {
            string[] stringsOfPersonInfo = System.IO.File.ReadAllLines(fileName);
            stringsOfPersonInfo = stringsOfPersonInfo.Where(w => w != stringsOfPersonInfo[0]).ToArray();
            List<Person> listOfPersons = new List<Person>();
            string[] personArray = new string[3];
            foreach (var row in stringsOfPersonInfo)
            {
                char separator = ',';
                string[] part = row.Split(separator);
                Person person = new Person();
                
                string genderFromList = part[4];
                int ageFromList = Convert.ToInt32(part[5]);
                                
                Gender gender = (Gender)Enum.Parse(typeof(Gender), genderFromList);
                
                person.FirstName = part[1];
                person.Age = ageFromList;
                person.Gender = gender;

                listOfPersons.Add(person);
            }
            return listOfPersons;
        }


        //----Uppgift 11.1

        //public List<string> CreateListOfNames(string fileName)
        //{
        //    string[] stringsOfPersonInfo = System.IO.File.ReadAllLines(fileName);
        //    stringsOfPersonInfo = stringsOfPersonInfo.Where(w => w != stringsOfPersonInfo[0]).ToArray();            
        //    List<string> listOfNames = new List<string>();
        //    string[] nameArray = new string[2];
        //    foreach (var row in stringsOfPersonInfo)
        //    {
        //        char separator = ',';
        //        string[] part = row.Split(separator);
        //        nameArray[0] = part[1];
        //        nameArray[1] = part[2];
        //        string bothNames = string.Join(" ", nameArray);

        //        listOfNames.Add(bothNames);              

        //    }
        //    return listOfNames;
        //}


    }
}
