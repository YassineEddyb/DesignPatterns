/*
    The Facade Pattern provides a unified interface to a
    set of interfaces in a subsystem. Facade defines a 
    higherlevel interface that makes the subsystem 
    easier to use.
*/

public class Porgram
{
    public static void Main()
    {
        Drink drink = new Drink();
        MainCourse mainCourse = new MainCourse();
        SideDish sideDish = new SideDish();

        Facade facade = new Facade(drink, mainCourse, sideDish);
        facade.prepareMeal("juice", "pizza", "salad");
    }
}