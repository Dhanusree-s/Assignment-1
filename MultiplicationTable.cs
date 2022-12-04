using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Please provide a number: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
            }
            Console.ReadLine();
        }

    }
}
