using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace If_else_programming_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter first value: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second value :");
            int b = Convert.ToInt32(Console.ReadLine());


            if (a > b)
            {
                Console.WriteLine("a is maximum");

            }
            else if (b > a)
            {
                Console.WriteLine("b is maximum");
            }

            //else if (b == a)

            //{
            //    Console.WriteLine("both are equal");
            //}

            else 
            {
                Console.WriteLine("Invalid input");
            
            }


                Console.ReadLine();




        }
    }
}
