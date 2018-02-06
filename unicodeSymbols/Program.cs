using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unicodeSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int[] kod = new int[str.Length];
            int i = 0;
            foreach (var item in str)
            {
                kod[i] = (int)item;
                Console.Write("\\u{0:x4}", kod[i]);
                i++;
            }
            
        }
    }
}
