using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppTryParseTry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welk getal?");
            string invoer = Console.ReadLine();
        
            int getal;
            bool succes = false;
            while (!succes)
            {
                if()
                ChangeValue(invoer, out getal);
                Console.WriteLine("Getal {0} heeft nu een int value", getal);

            }
          

        }

        static void ChangeValue(string invoer, out int getal)
        {
            Int32.TryParse(invoer, out getal);
        }
    }
}
