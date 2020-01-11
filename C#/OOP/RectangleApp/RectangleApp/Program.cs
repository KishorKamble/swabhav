using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectanlge small = new Rectanlge();
            small.width = 10;
            small.height = 20;
            Console.WriteLine("width area  = " + small.width);
            Console.WriteLine("Height  = " + small.height);
            Console.WriteLine("Small area  = " + small.CalculteArea());

            Console.WriteLine();
            Console.WriteLine();
       

            Rectanlge big = new Rectanlge();
            big.width = 100;
            big.height = 200;
            Console.WriteLine("width area  = " + big.width);
            Console.WriteLine("Height  = " + big.height);
            Console.WriteLine("Big area " + big.CalculteArea());

            Console.ReadLine();
                
        }
    }
}
