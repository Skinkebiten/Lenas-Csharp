using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public string RectString { get; set; }


        public Rectangle(double w, double h)
        {
            Width = w;
            Height = h;
            
        }

        public static double AskForBase()
        {
            Console.WriteLine("Enter base of rectangle: ");
            double rectangleBaseInput = Convert.ToDouble(Console.ReadLine());
            return rectangleBaseInput;
        }

        public static double AskForHeight()
        {
            Console.WriteLine("Enter height of rectangle: ");
            double rectangleHeightInput = Convert.ToDouble(Console.ReadLine());
            return rectangleHeightInput;
        }

        public override double CalculateArea()
        {
            return (Height * Width);
        }

        public override string ToString()
        {
            return $"Rectangle \t {CalculateArea():F2}";
            //return $"I'm a rectangle with an area of {CalculateArea()}.";
        }
    }
}
