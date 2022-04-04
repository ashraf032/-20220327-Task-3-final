using System;
using System.Linq;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 uc reqemli, 2 alti reqemli, 1 yeddi reqemli eded daxil edin");
            Console.WriteLine("Birinci ededi daxil et");
            string num1 = Console.ReadLine();
            Console.WriteLine("Ikinci ededi daxil et");
            string num2 = Console.ReadLine();
            Console.WriteLine("Ucuncu ededi daxil et");
            string num3 = Console.ReadLine();
            Console.WriteLine("Dorduncu ededi daxil et");
            string num4 = Console.ReadLine();
            Console.WriteLine("Besinci ededi daxil et");
            string num5 = Console.ReadLine();
            if (num1.Length == 3 && num2.Length == 3 && num3.Length == 6 && num4.Length == 6 && num5.Length == 7)
            {
                int pars1 = int.Parse(num1);
                int pars2 = int.Parse(num2);
                int total1 = pars1 + pars2;
                string total1tostr = total1.ToString();
                char[] chrtotal1 = total1tostr.ToCharArray();
                int[] integeredstr = chrtotal1.Select(i => int.Parse(i.ToString())).ToArray();
                Console.WriteLine("___sinama");
                Console.WriteLine(integeredstr[integeredstr.Length - 1]);
                string intstr1 = integeredstr[integeredstr.Length - 1].ToString();
                string intstr2 = integeredstr[integeredstr.Length - 2].ToString();
                string instrtotal1 = intstr2 + intstr1;
                int strtotaltoint = int.Parse(instrtotal1);
                int pow1 = strtotaltoint * strtotaltoint;
                Console.WriteLine("___sinama");
                Console.WriteLine(pow1);
                string paste1 = num1 + num2;
                int parspast = int.Parse(paste1);
                int total2 = pow1 + parspast;
                char[] chrnum5 = num5.ToCharArray();
                string chrtostrnum5 = chrnum5[chrnum5.Length - 5].ToString() + chrnum5[chrnum5.Length - 4].ToString() + chrnum5[chrnum5.Length - 3].ToString() + chrnum5[chrnum5.Length - 2].ToString() + chrnum5[chrnum5.Length - 1].ToString();
                int parsechrnum5 = int.Parse(chrtostrnum5);
                int total3 = pow1 + parsechrnum5;
                int pars3 = int.Parse(num3);
                int pars4 = int.Parse(num4);
                int sixdigittotal = pars3 + pars4;
                string prssix = sixdigittotal.ToString();
                char[] chrnum6 = prssix.ToCharArray();
                string chartostrsix = chrnum6[chrnum6.Length-3].ToString()+ chrnum6[chrnum6.Length - 2].ToString() + chrnum6[chrnum6.Length - 1].ToString();
                int parssix = int.Parse(chartostrsix);
                int total4 = total3 + parssix;
                int[] chrtostrnumseven = chrnum5.Select(i => int.Parse(i.ToString())).ToArray();
                int totalwar = chrtostrnumseven[0] + chrtostrnumseven[1] + chrtostrnumseven[2] + chrtostrnumseven[3] + chrtostrnumseven[4] + chrtostrnumseven[5] + chrtostrnumseven[6];
                string strnumseven = totalwar.ToString();
                char[] charsevennum = strnumseven.ToCharArray();
                for (int i = 0; i < charsevennum.Length / 2; i++)
                {
                    char tmp = charsevennum[i];
                    charsevennum[i] = charsevennum[charsevennum.Length - i - 1];
                    charsevennum[charsevennum.Length - i - 1] = tmp;
                }
                string sevenresultint = charsevennum[0].ToString() + charsevennum[1].ToString();
                int sevenresulttoint = int.Parse(sevenresultint);
                int total5 = sevenresulttoint + total4;
                string total5tostr = total5.ToString()+"11";
                int total5strtoint = int.Parse(total5tostr);
                string resultnum5toodd = chrnum5[0].ToString() + chrnum5[2].ToString() + chrnum5[4].ToString() + chrnum5[6].ToString();
                int resultnum5oddtoparse = int.Parse(resultnum5toodd);
                int result1 = total5strtoint - resultnum5oddtoparse;
                string result2 = result1.ToString();
                char [] result3 = result2.ToCharArray();
                Console.WriteLine("___sinama");
                Console.WriteLine(result1);
                string result4 = result3[result3.Length - 2].ToString() +"88"+ result3[result3.Length - 1].ToString();
                Console.WriteLine($"-------Son netice:{result4}---------");
            }
        }
    }
}
