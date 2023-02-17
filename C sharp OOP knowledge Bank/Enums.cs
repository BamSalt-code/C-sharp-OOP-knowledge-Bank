using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

/*
An enum is a special "class" that represents a group of constants 
(unchangeable/read-only variables).
To create an enum, use the enum keyword (instead of class or interface), 
and separate the enum items with a comma:
*/

namespace C_sharp_OOP_knowledge_Bank
{
    internal class Enums
    {
        enum Level
        {
            Low,
            Medium,
            High
        }

        /*
        static void Main(string[] args)
        {
            Level myVar = Level.Medium;
            switch (myVar)
            {
                case Level.Low:
                    Console.WriteLine("Low level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium level");
                    break;
                case Level.High:
                    Console.WriteLine("High level");
                    break;
            }
        }
        */
    }
}
