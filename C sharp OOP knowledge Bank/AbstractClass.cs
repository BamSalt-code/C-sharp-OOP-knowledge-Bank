using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* C# allows both classes and functions to be declared abstract using the abstract keyword. 
 * You can't create an instance of an abstract class. 
 * An abstract member has a signature but no function body and they must be overridden 
 * in any non-abstract derived class. Abstract classes exist primarily for inheritance.
*/

namespace C_sharp_OOP_knowledge_Bank
{
    //abstract class
    public abstract class Employess
    {
        //abstract method with no implementation
        public abstract void displayData();
    }

    //derived class
    public class cashiers : Employess
    {
        //abstract class method implementation
        public override void displayData()
        {
            Console.WriteLine("Cashier's class method");
        }
    }
}
