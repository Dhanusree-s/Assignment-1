using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
    {
    class SWITCH
    {
        static void Main(string[] args)
        {

            char grade = 'A';
            switch (grade)
            {
                case 'A':
                    {
                        Console.WriteLine("EXCELLENT");
                        break;
                    }

                case 'B':
                    {
                        Console.WriteLine("WELL DONE");
                        break;
                    }

                case 'C':
                    {
                        Console.WriteLine("GOOD");
                        break;
                    }
                case 'D':
                    {
                        Console.WriteLine("BETTER TO TRY AGAIN");
                        break;
                    }

                case 'F':
                    {
                        Console.WriteLine("FAILED");
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
        
}
