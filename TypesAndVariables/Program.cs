using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World");
            
            double number5 = 28.4;
            decimal number6 = 42.5m;
            char character = 'A';
            bool condition = true;
            byte number4 = 255;
            short number3 = -32768;
            int number = 2147483647;
            long number2 = 9223372036854775807;
            var number7 = 86;
            // number7 = 'B';
           
            Console.WriteLine("Number is {0}", number);
            Console.WriteLine("Number is {0}", number2);
            Console.WriteLine("Number is {0}", number3);
            Console.WriteLine("Number is {0}", number4);
            Console.WriteLine("Number is {0}", number5);
            Console.WriteLine("Number 7 is {0}", number7);
            Console.WriteLine("Character is {0}", (int)character);
            Console.WriteLine((int)Days.Wednesday);
            Console.ReadLine();
        }
    }
    enum Days
    {
       Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday
    }
}
