using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Xais olunur 6 reqemli bir eded daxil edin");
            string fourdigit = Console.ReadLine();
            if (fourdigit.Length == 6)
            {
                char[] charedstr = fourdigit.ToCharArray();
                int[] integeredstr = charedstr.Select(i => int.Parse(i.ToString())).ToArray();
                int sum = 0;
                for (int i = 0; i < integeredstr[2]; i++)
                {
                    sum += integeredstr[i];
                }
                
                Console.WriteLine("--------");
                Console.WriteLine($"Netice : {sum}");
            }
            else
            {
                Console.WriteLine("Xais olunur 6 reqemli eded daxil edin!!!");
            }
        }
    }
}
