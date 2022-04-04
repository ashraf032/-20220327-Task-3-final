using System;
using System.Linq;


namespace TAsk6
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Xais olunur 8 reqemli bir eded daxil edin");
            string eightdigit = Console.ReadLine();
            if (eightdigit.Length == 8)
            {
                char[] charedstr = eightdigit.ToCharArray();
                int[] integeredstr = charedstr.Select(i => int.Parse(i.ToString())).ToArray();
                string num1 = integeredstr[1].ToString();;
                string num2 = integeredstr[2].ToString();
                string num3 = integeredstr[3].ToString();
                string num4 = integeredstr[4].ToString();
                string num5 = integeredstr[5].ToString();
                string num6 = integeredstr[6].ToString();



                //final
                Console.WriteLine("--------");
                Console.WriteLine($"Netice : {num1+num2+num3+num4+num5+num6}");
            }
            else
            {
                Console.WriteLine("Xais olunur 8 reqemli eded daxil edin!!!");
            }
        }
    }
}
