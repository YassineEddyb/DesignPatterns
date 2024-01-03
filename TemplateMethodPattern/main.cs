/*
    The Template Method Pattern defines the skeleton
    of an algorithm in a method, deferring some steps to
    subclasses. Template Method lets subclasses redefine
    certain steps of an algorithm without changing the
    algorithm’s structure
*/

public class Porgram
{


    public static void Main()
    {
        Tea tea = new Tea();
        tea.prepareBeverage();

        Coffee coffee = new Coffee();
        coffee.prepareBeverage();
    }
}