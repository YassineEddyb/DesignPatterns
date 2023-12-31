using System;

public class GumballMachine
{
    State soldOutState;
    State noQuarterState;
    State hasQuarterState;
    State soldState;
    State state;

    int count = 0;
    public GumballMachine(int numberGumballs)
    {
        soldOutState = new SoldOutState(this);
        noQuarterState = new NoQuarterState(this);
        hasQuarterState = new HasQuarterState(this);
        soldState = new SoldState(this);
        this.count = numberGumballs;

        if (numberGumballs > 0)
            state = noQuarterState;
        else
            state = soldOutState;
    }
    public void insertQuarter()
    {
        state.insertQuarter();
    }
    public void ejectQuarter()
    {
        state.ejectQuarter();
    }
    public void turnCrank()
    {
        state.turnCrank();
        state.dispense();
    }
    public void setState(State state)
    {
        this.state = state;
    }
    public void setCount(Func<int, int> fn)
    {
        count = fn(count);
    }

    public int getCount()
    {
        return count;
    }

    public State getSoldOutState()
    {
        return soldOutState;
    }
    public State getHasQuarterState()
    {
        return hasQuarterState;
    }
    public State getSoldState()
    {
        return soldState;
    }
    public State getNoQuarterState()
    {
        return noQuarterState;
    }
}