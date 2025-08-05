using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_positive__negative_or_zero
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int Value = 0;

            Console.WriteLine("enter a values: ");
            Value = Convert.ToInt32(Console.ReadLine());
            
            if (Value > 0)
            {
                Console.WriteLine($"{Value} is positive");
            }
            else if (Value < 0)
            {
                Console.WriteLine($"{Value} is negative");
            }

            else
            {
                Console.WriteLine("value is zero");
       
            }

            Console.ReadKey();













        }
    }
}
