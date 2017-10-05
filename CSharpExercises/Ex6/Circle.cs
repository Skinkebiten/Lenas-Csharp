using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Circle
    {

        //double x;
        //double y;
        //double radius;


        //public Circle(double _x, double _y, double _radius)
        //{
        //    x = _x;
        //    y = _y;
        //    radius = _radius;
        //}


        //public override string ToString()
        //{
        //    return string.Format($"I'm a circle with x={x}, y={y}, and radius={radius}");
        //}


        //UPPGIFT 6.1 och 6.2

        public string Name { get; set;}
        public double Radius { get; set;}


        public Circle(string name2, double radius2)
        {
            Name = name2;
            Radius = radius2;
        }
        
        public double GetArea(double radius2)
        {
            double getArea = radius2 * radius2 * 3.14;
            return getArea;
        }


        public string SayHello()
        {
            return $"I'm a circle with the name {Name}!";            
        }


        public string WriteArea()
        {
            double getArea = Radius * Radius * 3.14;
            string stringArea = $"My name is {Name}. I have a radius of {Radius} and an area of {getArea}.";
            return stringArea;
        }
    }
}
