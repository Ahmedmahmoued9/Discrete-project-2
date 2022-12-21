using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Discrete_Mathematics_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, sum = 0;
            Console.Write("Enter the  start number :");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the end number:");
            int end = int.Parse(Console.ReadLine());
            // first loop to determine the start and end number taken from user
            for (int number = start; number <= end; number++)
            {
                // seconed to determine the divider start and end 
                for (int divider = 1; divider <= end; divider++)
                {
                    // first condition to make sure that "number" can be divided on the "divider" and "number" don't equal "divider" 
                    if (number % divider==0 && number != divider)
                    {
                        // here we add the dividers 
                        sum += divider;
                    }
                }
                //seconed condition to make sure the sum of dividers equal the givein number
                if (sum == number)
                {
                    Console.WriteLine("is perfect number : "+number);
                }
                // reset "sum" to start from the beginning
                sum = 0;
            }
        }
    }
}
