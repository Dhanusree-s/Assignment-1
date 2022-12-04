using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class EMP
    {
        static void Main(string[] args)
        {
            string name = "Dhanusree";
            int number = 10;
            string companyname = "NeSTDigital";
            double percentage = 90.90;
            char gender = 'F';
            bool isVerified = true;

            Console.WriteLine("NAME:" + name);
            Console.WriteLine("NUMBER:" + number);
            Console.WriteLine("COMPANY NAME:" + companyname);
            Console.WriteLine("PERCENTAGE:" + percentage);
            Console.WriteLine("GENDER:" + gender);
            Console.WriteLine("IS VERIFIED:" + isVerified);
            Console.ReadLine();
        }
    }
}