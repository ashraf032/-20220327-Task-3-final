using System;
using System.Linq;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Xais olunur 9 reqemli bir eded daxil edin");
            string fourdigit = Console.ReadLine();
            if (fourdigit.Length == 9)
            {
                char[] charedstr = fourdigit.ToCharArray();
                int[] integeredstr = charedstr.Select(i => int.Parse(i.ToString())).ToArray();
                string num1 = integeredstr[0].ToString();
                string num2 = integeredstr[2].ToString();
                string num3 = integeredstr[4].ToString();
                string num4 = integeredstr[6].ToString();
                string num5 = integeredstr[8].ToString();


                //final
                Console.WriteLine("--------");
                Console.WriteLine($"Netice : {num1+num2+num3+num4+num5}");
            }
            else
            {
                Console.WriteLine("Xais olunur 9 reqemli eded daxil edin!!!");
            }
        }
    }
}
