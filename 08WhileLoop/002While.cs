﻿namespace CSharpProgrammingBasics._08WhileLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _002While
    {
        internal static void Start()
        {
            string command = Console.ReadLine(); //wash

            while (command != "stop")
            {
                Console.WriteLine("Wash!");
                command = Console.ReadLine();      // continue
            }
        }
    }
}