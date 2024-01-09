using System;

public class GumballMachineTestDrive
{
    public static void Main()
    {
        GumballMachine gumballMachine = new GumballMachine(2);

        Console.WriteLine("Number of Gumballs : " + gumballMachine.getCount());
        gumballMachine.insertQuarter();
        gumballMachine.insertQuarter();
        gumballMachine.turnCrank();


        Console.WriteLine("Number of Gumballs : " + gumballMachine.getCount());
        gumballMachine.insertQuarter();
        gumballMachine.ejectQuarter();
        gumballMachine.turnCrank();


        Console.WriteLine("Number of Gumballs : " + gumballMachine.getCount());
        gumballMachine.insertQuarter();
        gumballMachine.turnCrank();


        Console.WriteLine("Number of Gumballs : " + gumballMachine.getCount());
        gumballMachine.insertQuarter();
        gumballMachine.turnCrank();
    }
}