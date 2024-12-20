﻿namespace CSharpProgrammingBasics._01FirstSteps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class StrongNumber
    {    
        public static void Start()
        {
            int num = int.Parse(Console.ReadLine());
            int tempNum = num;
            int totalFactorialSum = 0;

            while (tempNum > 0)
            {
                int digit = tempNum % 10;
                tempNum /= 10;
                int currentFactorialSum = 1;

                for (int i = 1; i <= digit; i++)
                {
                    currentFactorialSum *= i;
                }

                totalFactorialSum += currentFactorialSum;
            }

            if (num == totalFactorialSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}