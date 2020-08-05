using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 8, 3);
            Console.WriteLine(dt.ElapsedTime());
            Console.WriteLine();

            string text = "Zézinho da tapioca, caiu na rampa";
            Console.WriteLine(text.Cut(20));


        }
    }
}
