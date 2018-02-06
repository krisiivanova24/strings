using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ot10ichna
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = num1[0]; //broinaSistema
            int number = num1[1]; //chisloOtDesetichnaBrSisyema
            List<int> result = new List<int>();
            while (number > 0)
            {
                result.Add(number % num);
                number = number / num;
            }
            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}
