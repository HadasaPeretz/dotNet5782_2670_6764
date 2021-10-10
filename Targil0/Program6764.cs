using System;

namespace Targil0
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Welcome6764();
            Welcome2670();
            Console.ReadKey();
        }
        static partial void Welcome2670();
        private static void Welcome6764()
        {
            Console.Write("Enter your name: ");
            string username = Console.ReadLine();
            Console.WriteLine("{0},welcom to my first console apliccation", username);
            Console.ReadKey();
        }
    }
}
