using System;

class Program
{
    static void Main()
    {
        PizzaStoreFactory nyStore = new NYPizzaStore();
        PizzaStoreFactory chicagoStore = new ChicagoPizzaStore();

        Pizza pizza = nyStore.orderPizza("cheese");
        Console.WriteLine("Ethan ordered a " + pizza.getName() + "\n");

        pizza = chicagoStore.orderPizza("cheese");
        Console.WriteLine("Joel ordered a " + pizza.getName() + "\n");
    }
}