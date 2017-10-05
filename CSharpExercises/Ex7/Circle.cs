using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public string CircleText { get; set; }
        

        public Circle(double r)
        {
            Radius = r;
            
        }


        public static double AskForRadiance()
        {
            Console.Write("Enter radius of circle: ");
            double circleRadiusInput = Convert.ToDouble(Console.ReadLine());
            return circleRadiusInput;
        }

        public override double CalculateArea()
        {
            return Radius * Radius * Math.PI;

            //double calculateCircle = AskForRadiance();
            //double circleArea = circleRadiusInput * circleRadiusInput * Math.PI;
            //return circleArea;
        }

        public override string ToString()
        {
            return $"Circle \t\t {CalculateArea():F2}";
            //return $"I'm a circle with a radius of {Radius}.";
        }

    }
}
