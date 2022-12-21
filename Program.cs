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
                // seconed to determine the Divisor start and end 
                for (int Divisor = 1; Divisor <= end; Divisor++)
                {
                    // first condition to make sure that "number" can be divided on the "Divisor" and "number" don't equal "Divisor" 
                    if (number % Divisor == 0 && number != Divisor)
                    {
                        // here we add the Divisor 
                        sum += Divisor;
                    }
                }
                //seconed condition to make sure the sum of Divisor equal the given number
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
