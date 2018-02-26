using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestDel
{
    public class TriangleArea
    {
        static public double Area(double a, double b, double c)
        {
            if(a <= 0 || b <= 0 || c <= 0 )
                throw (new Exception("Error: Invalid side length!"));

            double x = 0, y = 0, z = 0;

            if (a > b && a > c)
            {
                z = a;
                x = b;
                y = c;
            }
            else if (b > a && b > c)
            {
                z = b;
                x = a;
                y = c;
            }
            else if (c > a && c > b)
            {
                z = c;
                x = b;
                y = a;
            }
            else
            {
                throw (new Exception("Error: Hypotenuse not found!"));
            }

            if (z * z != a * a + b * b)
            {
                if (z > x + y)
                    throw (new Exception("Error: Incorrect triangle!"));
                else
                    throw (new Exception("Error: Triangle is not rectangular!"));
            }

            return x * y * 1/2;
        }
    }
}
