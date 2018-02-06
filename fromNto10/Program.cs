using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fromNto10
{
    class Program
    {
        static int Stepen(int osnova, int pokazatel)
        {
            int stepen = 1;
            for (int i = 0; i < pokazatel; i++)
            {
                stepen = stepen * osnova;
                
            }
            return stepen;
        }
        static void Main(string[] args)
        {
            int[] num1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = num1[0]; //broinaSistema
            string number = num1[1].ToString(); //chislo
            int length = number.Length;
            int result = 0;

            for (int i = 0; i < length; i++)
            {
                int cifra = int.Parse(number[i].ToString());
                result = result + cifra * Stepen(num, length-1-i);
            }
            Console.WriteLine(result);
        }
    }
}
