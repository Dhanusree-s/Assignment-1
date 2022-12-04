using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp

{
    class largestof3numbers
    {
        static void Main(string[] args)
        {
            int[] num = { 12, 13, 18 };
            int biggestNum;

            biggestNum = num.Max();

            Console.WriteLine("The largest number out of {0}, {1}, and {2} is {3}.", num[0], num[1], num[2], biggestNum);
            Console.ReadKey();
        }
    }
}
