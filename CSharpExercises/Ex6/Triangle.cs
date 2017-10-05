using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Triangle
    {

        double x;
        double y;
        double baselength;
        double height;

        public Triangle(double _x, double _y, double _baselength, double _height)
        {
            x = _x;
            y = _y;
            baselength = _baselength;
            height = _height;
        }

        public override string ToString()
        {
            return string.Format($"I'm a triangle with x={x}, y={y}, baselength={baselength} and height={height}");
        }
    }
}
