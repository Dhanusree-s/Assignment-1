using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class SUM
    {
        static void Main(string[] args)
        {
            int N = 1213, Sum = 0, r;
            while (N != 0)
            {
                r = N % 10;
                Sum = Sum + r;
                N = N / 10;
            }
            Console.WriteLine("Sum = " + Sum);
            Console.ReadKey();
        }

    }
}
