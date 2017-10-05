using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void AskForShape()
        {
            List<Shape> allShapes = new List<Shape>();

            while (true)
            {
                Console.Write("Select (T)riangle, (R)ectangle (C)ircle or (D)one: ");
                Console.ForegroundColor = ConsoleColor.Green;
                string shapeChoise = Console.ReadLine();
                Console.ResetColor();
                Console.WriteLine();

                if (shapeChoise == "T")
                {
                    Console.Write("Enter width of triangle: ");
                    double triangleWidth = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter height of triangle: ");
                    double triangleHeight = Convert.ToDouble(Console.ReadLine());
                    Triangle triangle = new Triangle(triangleWidth, triangleHeight);
                    allShapes.Add(triangle);
                    Console.WriteLine();
                    continue;
                }
                else if (shapeChoise == "R")
                {
                    Console.Write("Enter width of rectangle: ");
                    double rectangleWidth = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter height of rectangle: ");
                    double rectangleHeight = Convert.ToDouble(Console.ReadLine());
                    Rectangle rectangle = new Rectangle(rectangleWidth, rectangleHeight);
                    allShapes.Add(rectangle);
                    Console.WriteLine();
                    continue;
                }
                if (shapeChoise == "C")
                {
                    Console.Write("Enter radius of circle: ");
                    double circleRadiusInput = Convert.ToDouble(Console.ReadLine());
                    Circle circle = new Circle(circleRadiusInput);
                    allShapes.Add(circle);
                    Console.WriteLine();
                    continue;
                }
                if (shapeChoise == "D")
                {
                    break;
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            double allShapesArea = 0;
            foreach (var shape in allShapes)
            {
                double myshape = shape.CalculateArea();
                Console.WriteLine(shape.ToString());

                allShapesArea += myshape;

            }
            Console.WriteLine();
            Console.WriteLine($"Total Area: \t {allShapesArea:F2}");
            Console.WriteLine();
            Console.ResetColor();
            //Console.WriteLine("Total Area: " + allShapesArea);
        }


        static void Main(string[] args)
        {
            AskForShape();




            //Circle circ = new Circle();
            //circ.AskForRadiance2();
            //Console.WriteLine(circ.CalculateArea());                                    
            //allShapes.Add(circ);




        }
    }
}
