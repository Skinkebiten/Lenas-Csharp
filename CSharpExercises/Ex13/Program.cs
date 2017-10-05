using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapeList = new List<Shape>();
            


            Console.Write("Enter radius of circle: ");
            double circleRadiusInput = Convert.ToDouble(Console.ReadLine());

            Circle circ = new Circle(circleRadiusInput);

            //circ.GetRadius(circleRadiusInput);
            //double circleArea = circ.GetCircleArea();
            //circ.CircleString(circleArea);

            shapeList.Add(circ);

            foreach (var shape in shapeList)
            {
                Console.WriteLine(shape);
            }


            //StringBuilder builder = new StringBuilder();
            //foreach (var shape in shapeList)
            //{
            //    builder.Append(shape);
            //}
            //string result = builder.ToString();
            //Console.WriteLine(result);
        }
    }
}
