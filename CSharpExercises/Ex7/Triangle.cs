using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Triangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public string TriString { get; set; }


        public Triangle(double w, double h)
        {
            Width = w;
            Height = h;
            
        }

        //public static double AskForBase()
        //{
        //    Console.WriteLine("Enter base of triangle: ");
        //    double triangleBaseInput = Convert.ToDouble(Console.ReadLine());
        //    return triangleBaseInput;
        //}

        //public static double AskForHeight()
        //{
        //    Console.WriteLine("Enter height of rectangle: ");
        //    double rectangeHeightInput = Convert.ToDouble(Console.ReadLine());
        //    return rectangeHeightInput;
        //}

        public override double CalculateArea()
        {
            return (Height * Width) / 2;            
        }

        public override string ToString()
        {
            return $"Triangle \t {CalculateArea():F2}";
            //return $"I'm a triangle with a area of {CalculateArea()}.";
        }
    }
}
