using System.Collections.Generic;

public interface Iterator
{
    bool hasNext();
    MenuItem next();
}

public class DinnerMenuIterator : Iterator
{
    MenuItem[] menuItems;
    int position = 0;

    public DinnerMenuIterator(MenuItem[] menuItems)
    {
        this.menuItems = menuItems;
    }

    public bool hasNext()
    {
        if (position < menuItems.Length)
            return true;
        else
            return false;
    }

    public MenuItem next()
    {
        MenuItem menuItem = menuItems[position];
        position++;
        return menuItem;
    }

}

public class PancakeHOuseMenuIterator : Iterator
{
    List<MenuItem> menuItems;
    int position = 0;

    public PancakeHOuseMenuIterator(List<MenuItem> menuItems)
    {
        this.menuItems = menuItems;
    }

    public bool hasNext()
    {
        if (position < menuItems.Count)
            return true;
        else
            return false;
    }

    public MenuItem next()
    {
        MenuItem menuItem = menuItems[position];
        position++;
        return menuItem;
    }
}