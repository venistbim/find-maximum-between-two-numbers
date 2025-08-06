using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace check_Leap_Year
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int year = 0;  

            Console.Write("enter a value :");
            year = Convert.ToInt32(Console.ReadLine());

            
            int divBy4 = (year % 4);
            int notdivBy100 = (year % 100);
            int divBy400 = (year % 400);


            #region
            ///check nested if*/
            //if (divBy4 == 0)
            //{

            //    if (notdivBy100 != 0)
            //    {
            //        if (notdivBy400 == 0)
            //        {
            //            Console.WriteLine("its a leap year");

            //        }

            //    }

            //}

            //else
            //{
            //    Console.WriteLine("its a not a leap year");

            //}


            //Console.ReadKey();
            #endregion





            //if else method

            if ((divBy4 == 0) && (notdivBy100 != 0 || divBy400 == 0))
            {

                Console.WriteLine($"{year} - is a leap year");

            }

            else 
            {

            Console.WriteLine("not a leap year");
            
            }



            Console.ReadKey();  


        }
    }
}
