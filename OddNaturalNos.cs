using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SampleApp
{
    class OddNaturalNos
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the n number ");
            int n = Convert.ToInt32(Console.ReadLine());
            int counter = 0, sum = 0;

            for (int i = 0; counter != n
            ; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                    counter++;
                    sum = sum + i;
                }

            }
            Console.WriteLine("\n The sum of Odd the natural numbers is : {0}", sum);
            Console.ReadLine();
        }
    }
}
