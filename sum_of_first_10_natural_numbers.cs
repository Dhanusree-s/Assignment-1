using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class sum_of_first_10_natural_numbers
    {
        public static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The Sum is : {sum}");
            Console.ReadKey();
        }
    }
}
