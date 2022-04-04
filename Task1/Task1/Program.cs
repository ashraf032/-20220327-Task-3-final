using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verilmish 4 reqemli ededin reqemlerinin cemi
            Console.WriteLine("Xais olunur 4 reqemli bir eded daxil edin");
            string fourdigit = Console.ReadLine();

            if (fourdigit.Length==4)
            {
                int number = int.Parse(fourdigit);
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                Console.WriteLine("--------");
                Console.WriteLine($"Netice : {sum}");
            }
            else
            {
                Console.WriteLine("Xais olunur 4 reqemli eded daxil edin!!!");
            }
        }
    }
}
