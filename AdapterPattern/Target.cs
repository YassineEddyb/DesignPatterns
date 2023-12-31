using System;

public interface Duck
{
    void fly();
    void quack();
}

public class MallardDuck : Duck
{

    public void quack()
    {
        Console.WriteLine("Quack qauck");
    }

    public void fly()
    {
        Console.WriteLine("I'm flying");
    }
}