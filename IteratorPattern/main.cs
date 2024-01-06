/*
    The Iterator Pattern provides a way to
    access the elements of an aggregate object
    sequentially without exposing its underlying
    representation.
*/


using System;
using System.Collections.Generic;

public class Waitress
{
    Menu pancakeHouseMenu;
    Menu dinerMenu;
    public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
    {
        this.pancakeHouseMenu = pancakeHouseMenu;
        this.dinerMenu = dinerMenu;
    }
    public void printMenu()
    {
        Iterator pancakeIterator = pancakeHouseMenu.createIterator();
        Iterator dinerIterator = dinerMenu.createIterator();

        Console.WriteLine("MENU\n----\nBREAKFAST");
        printMenu(pancakeIterator);
        Console.WriteLine("\nLUNCH");
        printMenu(dinerIterator);
    }
    private void printMenu(Iterator iterator)
    {
        while (iterator.hasNext())
        {
            MenuItem menuItem = iterator.next();
            Console.WriteLine(menuItem.getName() + ", ");
            Console.WriteLine(menuItem.getPrice() + " -- ");
            Console.WriteLine(menuItem.getDescription());
        }
    }
    // other methods here
}

public class Porgram
{
    public static void Main()
    {
        PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
        DinerMenu dinerMenu = new DinerMenu();

        Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);
        waitress.printMenu();

    }
}