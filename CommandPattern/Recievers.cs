using System;

public class Light
{

    public Light() { }

    public void on()
    {
        Console.WriteLine("light is on");
    }

    public void off()
    {
        Console.WriteLine("light is off");
    }
}

public class Garage
{

    public Garage() { }

    public void open()
    {
        Console.WriteLine("garage is open");
    }

    public void close()
    {
        Console.WriteLine("garage is close");
    }
}