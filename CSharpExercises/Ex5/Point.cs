using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Point
    {

        public int X { get; set; }
        public int Y { get; set; }


        void ChangePoint(Point point)
        {
            point.Y = 7;
            point.X = 4;
        }
    }
}

