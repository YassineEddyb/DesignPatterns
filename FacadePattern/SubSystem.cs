using System;

public class Drink
{
    public void prepareDrink(string type)
    {
        if (type == "soda")
            Console.WriteLine("Soda is ready");
        if (type == "juice")
            Console.WriteLine("Juice is ready");
        if (type == "Tea")
            Console.WriteLine("Tea is ready");
    }
}

public class MainCourse
{
    public void prepareMainCourse(string type)
    {
        if (type == "pizza")
            Console.WriteLine("Pizza is ready");
        if (type == "sandwich")
            Console.WriteLine("Sandwich is ready");
        if (type == "checken")
            Console.WriteLine("Checken is ready");
    }
}
public class SideDish
{
    public void prepareSideDish(string type)
    {
        if (type == "salad")
            Console.WriteLine("Salad is ready");
        if (type == "soup")
            Console.WriteLine("soup is ready");
    }
}