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
                int num1 = integeredstr[0]; //tek
                int num2 = integeredstr[1];
                int num3 = integeredstr[2];//tek
                int num4 = integeredstr[3];
                int num5 = integeredstr[4];//tek
                int num6 = integeredstr[5];
                int num7 = integeredstr[6];//tek
                int num8 = integeredstr[7];
                int num9 = integeredstr[8];//tek

                int groupcouplesum = num2 + num4 + num6 + num8;
                Console.WriteLine();
                Console.WriteLine(groupcouplesum);
                int groupsinglesum = num1 + num3+ num5 + num7 + num9;
                Console.WriteLine();
                Console.WriteLine(groupsinglesum);

                //final
                Console.WriteLine("--------");
                Console.WriteLine($"Netice : {groupcouplesum + groupsinglesum}");
            }
            else
            {
                Console.WriteLine("Xais olunur 9 reqemli eded daxil edin!!!");
            }
        }
    }
}
