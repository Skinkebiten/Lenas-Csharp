using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Rectangle
    {
        double x;
        double y;
        double width;
        double height;

        public Rectangle(double _x, double _y, double _width, double _height)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;

        }

        public override string ToString()
        {
            return string.Format($"I'm a rectangle with x={x}, y={y}, width={width} and height={height}");
        }
    }
}
