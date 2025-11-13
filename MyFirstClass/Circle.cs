using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClass
{
    internal class Circle
    {
        public int radius;

        public static double PI = 3.14159;

        public double Circumfrence()
        {
            return 2 * PI * radius;
        }
    }
}
