using System;
using System.Collections.Generic;

public class MenuItem
{
    string name;
    string description;
    double price;
    public MenuItem(string name, string description, double price)
    {
        this.name = name;
        this.description = description;
        this.price = price;
    }

    public string getName()
    {
        return name;
    }

    public string getDescription()
    {
        return description;
    }

    public double getPrice()
    {
        return price;
    }
}

public interface Menu
{
    Iterator createIterator();
}

public class PancakeHouseMenu : Menu
{
    List<MenuItem> menuItems;
    public PancakeHouseMenu()
    {
        menuItems = new List<MenuItem>();

        addItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs and toast", 2.99);
        addItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", 2.99);
    }
    public void addItem(string name, string description, double price)
    {
        MenuItem menuItem = new MenuItem(name, description, price);
        menuItems.Add(menuItem);
    }

    public Iterator createIterator()
    {
        return new PancakeHOuseMenuIterator(menuItems);
    }
}

public class DinerMenu : Menu
{
    static int MAX_ITEMS = 2;
    int numberOfItems = 0;
    MenuItem[] menuItems;

    public DinerMenu()
    {
        menuItems = new MenuItem[MAX_ITEMS];
        addItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", 2.99);
        addItem("BLT", "Bacon with lettuce & tomato on whole wheat", 2.99);
        // a couple of other Diner Menu items added here
    }

    public void addItem(string name, string description, double price)
    {
        MenuItem menuItem = new MenuItem(name, description, price);
        if (numberOfItems >= MAX_ITEMS)
        {
            Console.WriteLine("Sorry, menu is full! Can't add item to menu");
        }
        else
        {
            menuItems[numberOfItems] = menuItem;
            numberOfItems = numberOfItems + 1;
        }
    }

    public Iterator createIterator()
    {
        return new DinnerMenuIterator(menuItems);
    }
}

