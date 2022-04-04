using System;
using System.Linq;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Xais olunur doqquz reqemli bir eded daxil edin");
            string ninedigit = Console.ReadLine();
            if (ninedigit.Length == 9)
            {
                char[] charedstr = ninedigit.ToCharArray();
                int[] integeredstr = charedstr.Select(i => int.Parse(i.ToString())).ToArray();
                // int index
                int num1 = integeredstr[3];
                int num2 = integeredstr[4];
                int num3 = integeredstr[5];

                //final
                Console.WriteLine("----------");
                Console.WriteLine($"Netice : {num1+num2+num3}");

            }
            else
            {
                Console.WriteLine("Xais olunur 9 reqeemli eded daxil edin");
            }
        }
    }
}
