class Program
{
    public static void Main()
    {
        Duck mallardDuck = new MallardDuck();
        Turkey wildTurkey = new WildTurkey();

        Adapter adapter = new Adapter(wildTurkey);

        testDuck(mallardDuck);
        testDuck(adapter);
    }

    public static void testDuck(Duck duck)
    {
        duck.quack();
        duck.fly();
    }
}