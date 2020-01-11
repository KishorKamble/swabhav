using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramMutable
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int mark = 100;
            ModifySingleMark(mark);
            Console.WriteLine("Display Single Mark " + mark);

            int[] marks = { 10, 20, 30, 40 };
            Console.WriteLine(marks.GetHashCode());
            Console.WriteLine();
            ModifyMarks(marks);
            foreach(int m in marks)
            {
                Console.WriteLine(m);
            }

            Console.ReadLine();
        }

        public static void ModifyMarks(int[] arrMark)
        {
            for (int i = 0; i < arrMark.Length; i++)
            {
                arrMark[i] = 0;
               
            }
            Console.WriteLine(arrMark.GetHashCode());
        }

        public static void ModifySingleMark(int m)
        {
            m = m + 1;
        }
    }
}
