using System;
using System.Linq;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("3 alti reqemli ve 1 yeddi reqemli eded daxil edin");
            Console.WriteLine("Birinci ededi daxil et");
            string num = Console.ReadLine();
            Console.WriteLine("Ikinci ededi daxil et");
            string num2 = Console.ReadLine();
            Console.WriteLine("Ucuncu ededi daxil et");

            string num3 = Console.ReadLine();
            Console.WriteLine("Dorduncu ededi daxil et");

            string num4 = Console.ReadLine();
            if (num.Length== 6 && num2.Length == 6 && num3.Length == 6 && num4.Length == 7)
            {
                char[] charedstr1 = num.ToCharArray();
                char[] charedstr2 = num2.ToCharArray();
                char[] charedstr3 = num3.ToCharArray();
                char[] charedstr4 = num4.ToCharArray();

                int[] integeredstr1 = charedstr1.Select(i => int.Parse(i.ToString())).ToArray();
                int[] integeredstr2 = charedstr2.Select(i => int.Parse(i.ToString())).ToArray();
                int[] integeredstr3 = charedstr3.Select(i => int.Parse(i.ToString())).ToArray();

                string int1str1 = integeredstr1[0].ToString();
                string int1str2 = integeredstr1[1].ToString();
                string int1str3 = integeredstr1[2].ToString();

                string int1sum = int1str1 + int1str2 + int1str3;
                int intparse = int.Parse(int1sum);

                string int2str1 = integeredstr2[0].ToString();
                string int2str2 = integeredstr2[1].ToString();
                string int2str3 = integeredstr2[2].ToString();

                string int2sum = int2str1 + int2str2 + int2str3;
                int intparse2 = int.Parse(int2sum);


                string int3str1 = integeredstr3[0].ToString();
                string int3str2 = integeredstr3[1].ToString();
                string int3str3 = integeredstr3[2].ToString();

                string int3sum = int3str1 + int3str2 + int3str3;
                int intparse3 = int.Parse(int3sum);

                int[] integeredstr4 = charedstr4.Select(i => int.Parse(i.ToString())).ToArray();


                string int4str1 = integeredstr4[3].ToString();
                string int4str2 = integeredstr4[4].ToString();
                string int4str3 = integeredstr4[5].ToString();
                string int4str4 = integeredstr4[6].ToString();

                string int4str5 = integeredstr4[0].ToString();
                string int4str6 = integeredstr4[1].ToString();
                string int4str7 = integeredstr4[2].ToString();

                int strtoint1 = int.Parse(int4str5);
                int strtoint2 = int.Parse(int4str6);
                int strtoint3 = int.Parse(int4str7);

                int multistrtoint = strtoint1 * strtoint2 * strtoint3; 


                string int4sum = int4str1 + int4str2 + int4str3 + int4str4;
                int intparse4 = int.Parse(int4sum);


                int total = intparse + intparse2 + intparse3+ intparse4 - multistrtoint;

                double total60perc = total * 0.6;

                string total60perctostr = total60perc.ToString() + "60";

                double result1 = double.Parse(total60perctostr);

                double final = result1 - (result1 * 0.18);
                
                Console.WriteLine("--------");
                Console.WriteLine($"Netice : {final}");
            }
            else
            {
                Console.WriteLine("Sherte uygun eded daxil edin!!!");
            }
        }
    }
}
