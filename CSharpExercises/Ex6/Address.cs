using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex6
{
    class Address
    {

        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string City { get; set; }

        string zipCode = "";

        public string ZipCode
        {
            get
            {
                return zipCode;
            }
            set
            {
                if (Regex.IsMatch(value, @"\d\d\d \d\d"))
                {
                    zipCode = value;
                    //Console.WriteLine("Det funkar!");
                }




                //if (value == "Lena")
                //{

                //}
                //else
                //{
                //    zipCode = value;
                //}

                //string regZip = @"\d{3}\s*\d{2}";


                //bool IsZipCode(string ZipCode)
                //{
                //    bool validZipCode = true;
                //    if ((!Regex.Match(ZipCode, regZip).Success))
                //    {
                //        validZipCode = false;
                //    }
                //    return validZipCode;
                //}

            }
        }

        //public string ZipCode(string zipCode)
        //{


        //Regex regex = new Regex(@"\d{3}[ ]?\d{2}");      /Funkar inte
        //Match matchZip = regex.Match(zipCode);
        //if (matchZip.Success)
        //{
        //    string validZip = (matchZip.Value);
        //    return validZip;
        //}

        //Console.WriteLine("Ask for zip: ");
        //string zipCode = Console.ReadLine();

        //Regex regex = new Regex(@"\d{3}\s*\d{2}");
        //Match matchZip = regex.Match(zipCode);
        //if (matchZip.Success)
        //{
        //    Console.WriteLine(zipCode);

        //}

        //else
        //{
        //    Console.WriteLine("Invalid zip code. Format must be e.g. 123 45.");
        //}






        //}

        public string FullStreet
        {
            get
            {
                return $"{Street} {StreetNumber}";
            }
        }



        //public override string ToString()
        //{
        //return $"Street \t\t\t {Street} \nStreet number \t\t {StreetNumber} \nCity \t\t\t {City} \nZip Code \t\t {ZipCode} \nFull street \t\t {FullStreet}";

        //Console.WriteLine($"Street number: \t\t {StreetNumber}");
        //}
    }

}

