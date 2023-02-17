using C_sharp_OOP_knowledge_Bank;
using oops;


// overrides Abstract Class, and goes with cashier class in AbstractClass.cs //
public class managers : Employess
{
    public override void displayData()
    {
        Console.WriteLine("manager's class method");
    }
}
class RunClasses
{
    static void Main(string[] args)
    {
        // basic class example //

        new client().displayData();

        // constructor with parameters //
        Car Ford = new Car("Mustang", "Red", 1969);
        Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);

        // Abstract class instance //
        new cashiers().displayData();
        new managers().displayData();

        // Virtual override activation //
        new myBase().VirtualMethod();
        new myDerived().VirtualMethod();
        //Console.ReadKey();

        // getters and setters //
        Person myObj = new Person();
        myObj.Name = "Liam";
        Console.WriteLine(myObj.Name);
    }
    
}



