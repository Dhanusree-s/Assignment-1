using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class While
    {
        public static void Main(string[] args)
        {
            int i = 0;
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            while (i < array.Length)
            {
                Console.WriteLine(i);
                i++;
            }




            Console.WriteLine(" Press Enter Key To Exit ....");
            Console.ReadLine();
        }
    }
}