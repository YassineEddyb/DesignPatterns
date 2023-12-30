using System;

abstract class Beverage
{
    public string desc = "Unknown coffee";

    public string getDescription()
    {
        return desc;
    }

    public void display()
    {
        Console.WriteLine("- " + this.getDescription() + " : " + this.cost() + "$");
    }

    public abstract double cost();
}


class Espresso : Beverage
{
    public Espresso()
    {
        desc = "Espresso coffee";
    }


    public override double cost()
    {
        return 1.99;
    }
}

class HouseBlend : Beverage
{
    public HouseBlend()
    {
        desc = "House Blend coffee";
    }


    public override double cost()
    {
        return 1.05;
    }
}
