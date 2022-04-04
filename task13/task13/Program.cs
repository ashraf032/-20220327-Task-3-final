using System;
using System.Linq;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Xais olunur 3 dene 5 reqemli eded daxil edin");
            Console.WriteLine("----------------------");
            Console.WriteLine("Birinci ededidaxil edin ");
            Console.WriteLine("----------------------");
            string fivedigit1 = Console.ReadLine();
            Console.WriteLine("Ikinci ededi daxil edin");
            Console.WriteLine("----------------------");
            string fivedigit2 = Console.ReadLine();
            Console.WriteLine("Ucuncu ededi daxil edin");
            Console.WriteLine("----------------------");
            string fivedigit3 = Console.ReadLine();
            if (fivedigit1.Length == 5  && fivedigit2.Length == 5 && fivedigit3.Length == 5)
            {
                char[] charedstr1 = fivedigit1.ToCharArray();
                int[] integeredstr1 = charedstr1.Select(i => int.Parse(i.ToString())).ToArray();
                string num1 = integeredstr1[0].ToString();
                string num5 = integeredstr1[4].ToString();
                //tip
                string tip = num1 + num5;
                //parsing 1
                int tipprs1 = int.Parse(tip);
                char[] charedstr2 = fivedigit2.ToCharArray();
                int[] integeredstr2 = charedstr2.Select(i => int.Parse(i.ToString())).ToArray();
                string number1 = integeredstr2[0].ToString();
                string number5 = integeredstr2[4].ToString();
                // tip2
                string tip2 = num1 + num5;
                //parasing 2
                int tipprs2 = int.Parse(tip2);
                char[] charedstr3 = fivedigit3.ToCharArray();
                int[] integeredstr3 = charedstr3.Select(i => int.Parse(i.ToString())).ToArray();
                string numberstr1 = integeredstr3[0].ToString();
                string numberstr5 = integeredstr3[4].ToString();
                // tip3
                string tip3 = num1 + num5;
                //parasing 3
                int tipprs3 = int.Parse(tip3);
                //sum
                int sum = tipprs1 + tipprs2 + tipprs3;
                //final
                Console.WriteLine("--------");
                Console.WriteLine($"Netice :{sum * 0.5 + sum }"); 
            }
            else
            {
                Console.WriteLine("Xais olunur serte uygun eded daxil edin!!!");
            }
        }
    }
}