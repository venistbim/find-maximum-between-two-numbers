using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_is_even_or_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {


           int value = 0;   

            Console.Write("enter a value :");
            value = Convert.ToInt32(Console.ReadLine());

            int num = value % 2;



            if (num == 0)
            {

                Console.WriteLine($"{value} - is even number");

            }

            else 
            {
                Console.WriteLine($"{value} - is odd number");
            
            }




                Console.ReadKey();

            
        }
    }
}
