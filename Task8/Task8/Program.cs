using System;
using System.Linq;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int numsum;
            Console.WriteLine("Bir eded daxil edin");
            int num = int.Parse(Console.ReadLine());
            number1 = num % 10;
            num = num / 10;
            number2 = num % 10;
            Console.WriteLine(numsum = number1 + number2);
        }
    }
}
