using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArraysApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle[] manyRectangle = new Rectangle[3];
            manyRectangle[0] = new Rectangle(10, 20);
            manyRectangle[1] = new Rectangle(30, 40);
            manyRectangle[2] = new Rectangle(50, 60);

            foreach(Rectangle rectangle in manyRectangle )
            {
                PrintInfo(rectangle);
                //PrintInfo(rectangle);
            }
                                 
            Console.ReadLine();
        }

        public static void PrintInfo(Rectangle rect)
        {
            Console.WriteLine("Width - " + rect.Width);
            Console.WriteLine("Height - " + rect.Height);
            Console.WriteLine("Area - " + rect.Area);
          
            Console.WriteLine("");
        }
    }
}
