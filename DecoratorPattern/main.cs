/*
    The Decorator Pattern attaches additional
    responsibilities to an object dynamically.
    Decorators provide a flexible alternative to
    subclassing for extending functionality.
*/

using System;

class Program
{
    static void Main()
    {
        Beverage beverage = new Espresso();
        beverage = new Mocha(beverage);
        beverage = new Whip(beverage);
        beverage.display();

        Beverage beverage2 = new HouseBlend();
        beverage2 = new Mocha(beverage2);
        beverage2 = new Mocha(beverage2);
        beverage2 = new Whip(beverage2);
        beverage2.display();
    }
}