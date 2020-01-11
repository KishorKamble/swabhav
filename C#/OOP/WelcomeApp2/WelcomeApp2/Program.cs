using System;
namespace WelcomeApp2
{
    class Program
    {
        static void Main(string[] arguments)
        {

            Console.WriteLine(arguments.Length);

            //for (int i = 0; i < args.Length; i++)
            //{
            //    Console.WriteLine("Hello -" + args[i].ToString());
            //}

            foreach(string argument in arguments)
            {
                Console.WriteLine("Hello -" + argument );

            }

            Console.Read();   
        }
    }
}
