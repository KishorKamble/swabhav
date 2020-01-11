using System;

namespace RectangleEncapsuleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectanlge objsmall = new Rectanlge();
            objsmall.SetHeight(-200);
            objsmall.SetWidth(105);
            //Console.WriteLine("Height="+ objsmall.GetHeight());
            //Console.WriteLine("Widht=" + objsmall.GetWidth());
            //Console.WriteLine("Small Area " + objsmall.CalculteArea());

            PrintInfo(objsmall);

            Console.WriteLine();
            Console.WriteLine();

            Rectanlge objBig = new Rectanlge();
            objBig.SetHeight(8);
            objBig.SetWidth(19873677);
            //Console.WriteLine("Height=" + objBig.GetHeight());
            //Console.WriteLine("Widht=" + objBig.GetWidth());
            //Console.WriteLine("Big Area " + objBig.CalculteArea());
            PrintInfo(objBig);

            Rectanlge objTemp = objBig;
            Console.WriteLine(objTemp.GetWidth());
            Console.WriteLine(objBig.GetWidth());

            objTemp.SetWidth(90);
            Console.WriteLine(objTemp.GetWidth());
            Console.WriteLine(objBig.GetWidth());

            Console.WriteLine(objTemp.GetHashCode());

            objTemp = null;
            Console.WriteLine(objBig.GetWidth());
            //Console.WriteLine(objTemp.GetWidth());
            
            Console.ReadLine();
        }

        public static void PrintInfo(Rectanlge temp)
        {

            Console.WriteLine("Height=" + temp.GetHeight());
            Console.WriteLine("Widht=" + temp.GetWidth());
            Console.WriteLine("Area " + temp.CalculteArea());
            Console.WriteLine(temp.GetHashCode());

        }
    }
}
