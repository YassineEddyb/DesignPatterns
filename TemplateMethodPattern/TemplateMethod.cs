using System;

public abstract class CaffeineBeverage
{

    // Template method
    public void prepareBeverage()
    {
        boilWater();
        brew();
        pourInCup();
        if (customerWantsCondiments())
            addCondiments();
    }

    private void boilWater()
    {
        Console.WriteLine("Boiling water");
    }
    private void pourInCup()
    {
        Console.WriteLine("Pouring into cup");
    }

    public abstract void brew();
    public abstract void addCondiments();

    // hook method
    public virtual bool customerWantsCondiments()
    {
        return true;
    }
}

public class Coffee : CaffeineBeverage
{
    public override void brew()
    {
        Console.WriteLine("Dripping coffee through filter");
    }
    public override void addCondiments()
    {
        Console.WriteLine("Adding sugar and milk");
    }

    public override bool customerWantsCondiments()
    {
        return false;
    }
}

public class Tea : CaffeineBeverage
{
    public override void brew()
    {
        Console.WriteLine("Steeping the tea");
    }
    public override void addCondiments()
    {
        Console.WriteLine("Adding mint");
    }
}