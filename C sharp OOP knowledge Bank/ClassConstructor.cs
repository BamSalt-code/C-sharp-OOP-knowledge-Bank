using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
A constructor is a specialized function that is used to initialize fields. 
A constructor has the same name as the class.
*/

namespace C_sharp_OOP_knowledge_Bank
{
    
    class build
    {
        // Member Variables
        static private int x;

        //constuctor for static initializing fields
        static build()
        {
            x = 10;
        }
        //method for get  static field
        static public void getData()
        {
            Console.WriteLine(x);
        }
        //Entry point
        
    }

    // class 2 //
    class Car
    {
        public string model;
        public string color;
        public int year;

        // Create a class constructor with multiple parameters
        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
    }


    // Outputs Red 1969 Mustang
}

