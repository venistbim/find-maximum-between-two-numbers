using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisible_by_5_and_11_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {


            
            int value = 0;

            Console.WriteLine("enter a value :");
            value =Convert.ToInt32(Console.ReadLine());

            int divby5 = value % 5;
            int divby11 = value % 11;

            if (divby11 == 0 && divby5 == 0)
            {
                Console.WriteLine("enter a value is divisible by 11 and 5");

            }
            else if (divby5 == 0)
            {

                Console.WriteLine("enter a value is divisible by 5 not by 11");

            }

            else if (divby11 == 0)
            {

                Console.WriteLine("enter a value is divisible by 11 not by 5");

            }

            else
            { 

            Console.WriteLine("enter a value not divisible by 11 and 5");
            
            }





                Console.ReadKey();













        }
    }
}
