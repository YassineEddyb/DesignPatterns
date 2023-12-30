using System;

public class Pizza
{
    protected string name;

    public string getName()
    {
        return name;
    }

    public void prepare()
    {
        Console.WriteLine("preparing " + name + " pizza");
    }

    public void cut()
    {
        Console.WriteLine("Cutting " + name + " pizza");
    }

    public void box()
    {
        Console.WriteLine("Boxing " + name + " pizza");
    }
}

public class NYStyleCheesePizza : Pizza
{
    public NYStyleCheesePizza()
    {
        name = "NY Style Cheese Pizza";
    }
}

public class NYStyleVeggiePizza : Pizza
{
    public NYStyleVeggiePizza()
    {
        name = "NY Style Veggie Pizza";
    }
}

public class ChicagoStyleCheesePizza : Pizza
{
    public ChicagoStyleCheesePizza()
    {
        name = "Chicago Style Cheese Pizza";
    }
}

public class ChicagoStyleVeggiePizza : Pizza
{
    public ChicagoStyleVeggiePizza()
    {
        name = "Chicago Style Veggie Pizza";
    }
}