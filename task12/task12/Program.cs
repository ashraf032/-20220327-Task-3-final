using System;
using System.Linq;

namespace task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Xais olunur 2 dene 5 reqemli bir eded daxil edin");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Birinci ededi daxil edin");
            string fivedigit1 = Console.ReadLine();
            Console.WriteLine("Ikinci ededi daxil edin");
            string fivedigit2 = Console.ReadLine();
            if (fivedigit1.Length == 5 && fivedigit2.Length == 5)
            {
                //number one
                char[] charedstr1 = fivedigit1.ToCharArray();
                int[] integeredstr1 = charedstr1.Select(i => int.Parse(i.ToString())).ToArray();
                int num1 = integeredstr1[0];
                int num2 = integeredstr1[1];
                int num3 = integeredstr1[2];
                int num4 = integeredstr1[3];
                int num5 = integeredstr1[4];
                string numstr = integeredstr1[0].ToString();
                //num one total
                int numtotal = num1 + num2 + num3 + num4 + num5;
                //number two
                char[] charedstr2 = fivedigit2.ToCharArray();
                int[] integeredstr2 = charedstr2.Select(i => int.Parse(i.ToString())).ToArray();
                int number1 = integeredstr2[0];
                int number2 = integeredstr2[1];
                int number3 = integeredstr2[2];
                int number4 = integeredstr2[3];
                int number5 = integeredstr2[4];
                //mnum two mult
                int mult = number1 * number2 * number3 * number4 * number5;
                //final
                Console.WriteLine("--------");
                Console.WriteLine($"Netice : {numtotal + mult+ numstr}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Xais olunur serte uygun eded daxil edin!!!");
            }
        }
    }
}
