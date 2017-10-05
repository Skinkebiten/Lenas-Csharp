using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Cube
    {
        double height;
        double width;
        double depth;

        public Cube(double height2, double width2, double depth2)
        {
            height = height2;
            width = width2;
            depth = depth2;
        }


        public string WriteVolume()
        {
            double result = height * width * depth;
            string volume = $"The volume of the cube is {result}.";
            return volume;
        }
    }
}
