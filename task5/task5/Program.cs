using System;
using System.Linq;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Xais olunur 6 reqemli bir eded daxil edin");
            string sixdigit = Console.ReadLine();
            if (sixdigit.Length == 6)
            {
                char[] charedstr = sixdigit.ToCharArray();
                int[] integeredstr = charedstr.Select(i => int.Parse(i.ToString())).ToArray();
                string num1 = integeredstr[5].ToString();


                //final
                Console.WriteLine("--------");
                Console.WriteLine($"Netice : {sixdigit + num1} ");

            }
            else
            {
                Console.WriteLine("Xais olunur 6 reqemli eded daxil edin!!!");
            }
        }
    }
}
