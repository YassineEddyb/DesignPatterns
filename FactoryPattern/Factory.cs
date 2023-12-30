
abstract public class PizzaStoreFactory
{
    public Pizza orderPizza(string type)
    {
        Pizza pizza;
        pizza = createPizza(type);
        pizza.prepare();
        pizza.cut();
        pizza.box();
        return pizza;
    }

    protected abstract Pizza createPizza(string type);
}

public class NYPizzaStore : PizzaStoreFactory
{
    protected override Pizza createPizza(string item)
    {
        if (item == "cheese")
            return new NYStyleCheesePizza();
        else if (item == "veggie")
            return new NYStyleVeggiePizza();
        else return null;
    }
}

public class ChicagoPizzaStore : PizzaStoreFactory
{
    protected override Pizza createPizza(string item)
    {
        if (item == "cheese")
            return new ChicagoStyleCheesePizza();
        else if (item == "veggie")
            return new ChicagoStyleVeggiePizza();
        else return null;
    }
}