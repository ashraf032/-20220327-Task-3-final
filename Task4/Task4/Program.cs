using System;
using System.Linq;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Xais olunur 5 reqemli bir eded daxil edin");
            string fourdigit = Console.ReadLine();
            if (fourdigit.Length == 5)
            {
                char[] charedstr = fourdigit.ToCharArray();
                int[] integeredstr = charedstr.Select(i => int.Parse(i.ToString())).ToArray();
                int num1 = integeredstr[0];
                int num2 = integeredstr[4];
                int sum = num1 + num2;
                Console.WriteLine("--------");
                Console.WriteLine($"Netice : {sum *= sum}");
            }
            else
            {
                Console.WriteLine("Xais olunur 5 reqemli eded daxil edin!!!");

            }
        }
    }
}
