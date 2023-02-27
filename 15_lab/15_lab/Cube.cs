using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_lab
{
     class Cube
    {
       public  double edgeLength;

       public  Cube()
        {
            edgeLength = 1;
        }

        public  Cube(double length)
        {
            edgeLength = length;
        }

        public  double CalculateVolume()
        {
            return Math.Pow(edgeLength, 3);
        }

        public  double CalculateSurfaceArea()
        {
            return 6 * Math.Pow(edgeLength, 2);
        }

    }
}
