
abstract class Decorator : Beverage
{
    public Beverage beverage;

    public abstract string getDescription();
}

class Mocha : Decorator
{
    public Mocha(Beverage beverage)
    {
        this.beverage = beverage;
        desc = this.beverage.getDescription() + " Mocha";
    }

    public override double cost()
    {
        return this.beverage.cost() + 0.20;
    }
}

class Whip : Decorator
{
    public Whip(Beverage beverage)
    {
        this.beverage = beverage;
        desc = this.beverage.getDescription() + " Whip";
    }

    public override double cost()
    {
        return this.beverage.cost() + 0.40;
    }
}