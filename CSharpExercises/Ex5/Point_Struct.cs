using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    struct Point_Struct
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

