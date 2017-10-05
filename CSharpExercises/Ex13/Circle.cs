using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    class Circle : Shape
    {
        public double radius { get; set; }
        

        public Circle(double r)
        {
            radius = r;
        }
        
        public double GetCircleArea()
        {
            return (radius * radius * Math.PI);
        }

        //public string circleString;

        public string CircleString(double area)
        {
            return $"I'm a circle with a radius of {area}.";
        }

        public override string ToString()
        {            
            return $"I'm a circle with a radius of {radius}.";
            //return base.ToString();
        }

    }
}
