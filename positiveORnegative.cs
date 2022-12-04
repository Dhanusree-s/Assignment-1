using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class positiveORnegative
    {
        class sum_of_first_10_natural_numbers
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number > 0)
                {
                    Console.WriteLine("Number is positive");
                }
                else if (number == 0)
                {
                    Console.WriteLine("Number is 0");
                }
                else
                {
                    Console.WriteLine("Number is negative");
                }
                Console.ReadLine();
            }
        }
    }
}





