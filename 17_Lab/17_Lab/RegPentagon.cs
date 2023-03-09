using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _17_Lab
{

    [Serializable]
    public class RegPentagon
    {
        public int radius;

        public RegPentagon()
        {
            radius = 1;
        }

        public RegPentagon(int r)
        {

                radius = r;
        }

        public Point[] GetPoints(int centerX, int centerY) {

           

            // Визначаємо координати кутів п'ятикутника
            Point[] points = new Point[5];
            double angle = 0;
            double angleIncrement = 2 * Math.PI / 5;

            for (int i = 0; i < 5; i++)
            {
                int x = (int)Math.Round(centerX + radius * Math.Cos(angle));
                int y = (int)Math.Round(centerY + radius * Math.Sin(angle));
                points[i] = new Point(x, y);
                angle += angleIncrement;
            }

            return points;

        }

    }
}
