using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] evenNumber = new int[10];

            for (int i = 0; i < 10; i++)
            {
                evenNumber[i] = i * 2;
            }

            for (int i = evenNumber.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(evenNumber[i]);
            }
            Console.ReadKey();
        }
    }
}
