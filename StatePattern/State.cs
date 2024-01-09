using System;

public interface State
{
    void insertQuarter();
    void ejectQuarter();
    void turnCrank();
    void dispense();
}


public class NoQuarterState : State
{
    GumballMachine gumballMachine;

    public NoQuarterState(GumballMachine gumballMachine)
    {
        this.gumballMachine = gumballMachine;
    }
    public void insertQuarter()
    {
        Console.WriteLine("You inserted a quarter");
        gumballMachine.setState(gumballMachine.getHasQuarterState());
    }
    public void ejectQuarter()
    {
        Console.WriteLine("You haven't inserted a quarter");
    }
    public void turnCrank()
    {
        Console.WriteLine("You turned, but there's no quarter");
    }
    public void dispense()
    {
        Console.WriteLine("You need to pay first");
    }
}

public class SoldOutState : State
{
    GumballMachine gumballMachine;

    public SoldOutState(GumballMachine gumballMachine)
    {
        this.gumballMachine = gumballMachine;
    }
    public void insertQuarter()
    {
        Console.WriteLine("The gumball is sold out");
    }
    public void ejectQuarter()
    {
        Console.WriteLine("The gumball is sold out");
    }
    public void turnCrank()
    {
        Console.WriteLine("The gumball is sold out");
    }
    public void dispense()
    {
        Console.WriteLine("The gumball is sold out");
    }
}

public class SoldState : State
{
    GumballMachine gumballMachine;

    public SoldState(GumballMachine gumballMachine)
    {
        this.gumballMachine = gumballMachine;
    }
    public void insertQuarter()
    {
        Console.WriteLine("Please wait, we're already giving you a gumball");
    }
    public void ejectQuarter()
    {
        Console.WriteLine("Sorry, you already turned the crank");
    }
    public void turnCrank()
    {
        Console.WriteLine("Turning twice doesn't get you another gumball!");
    }
    public void dispense()
    {
        Console.WriteLine("A gumball comes rolling out the slot");
        gumballMachine.setCount((prevCount) => prevCount - 1);

        if (gumballMachine.getCount() == 0)
        {
            Console.WriteLine("Oops, out of gumballs!");
            gumballMachine.setState(gumballMachine.getSoldOutState());
        }
        else
            gumballMachine.setState(gumballMachine.getNoQuarterState());
    }
}


public class HasQuarterState : State
{
    GumballMachine gumballMachine;

    public HasQuarterState(GumballMachine gumballMachine)
    {
        this.gumballMachine = gumballMachine;
    }
    public void insertQuarter()
    {
        Console.WriteLine("You can't insert another quarter");
    }
    public void ejectQuarter()
    {
        Console.WriteLine("Quarter returned");
        gumballMachine.setState(gumballMachine.getNoQuarterState());
    }
    public void turnCrank()
    {
        Console.WriteLine("You turned...");
        gumballMachine.setState(gumballMachine.getSoldState());
    }
    public void dispense()
    {
        Console.WriteLine("You need to turn the crank");
    }
}