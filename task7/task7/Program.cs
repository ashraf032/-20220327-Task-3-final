using System;
using System.Linq;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Xais olunur 4 reqemli bir eded daxil edin");
            string fourdigit = Console.ReadLine();
            string paste = "8";
            if (fourdigit.Length == 4)
            {
                char[] charedstr = fourdigit.ToCharArray();
                int[] integeredstr = charedstr.Select(i => int.Parse(i.ToString())).ToArray();
                string num1 = integeredstr[0].ToString();
                string num2 = integeredstr[1].ToString();
                string num3 = integeredstr[2].ToString();
                string num4 = integeredstr[3].ToString();

                int intprs1 = int.Parse(num1);
                int intprs2 = int.Parse(num2);
                int intprs3 = int.Parse(num3);
                int intprs4 = int.Parse(num4);


                //final
                Console.WriteLine("--------");
                Console.WriteLine($"Netice :{paste}{intprs4}{intprs3}{intprs2}{intprs1}{paste}");
            }
            else
            {
                Console.WriteLine("Xais olunur 4 reqemli eded daxil edin!!!");
            }
        }
    }
}
