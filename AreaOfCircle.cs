using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Basic_Program
{
    internal class AreaOfCircle
    {
        static void Main(string[] args)
        {
            float Pi = 3.14F;
            int r = 6;
            float areaofcircle = Pi * r * r;
            Console.WriteLine("Area of Circle=" + areaofcircle);
        }
    }
}
