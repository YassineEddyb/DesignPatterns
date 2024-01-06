
public class Facade
{
    Drink drink;
    MainCourse mainCourse;
    SideDish sideDish;

    public Facade(Drink drink, MainCourse mainCourse, SideDish sideDish)
    {
        this.drink = drink;
        this.mainCourse = mainCourse;
        this.sideDish = sideDish;
    }

    public void prepareMeal(string drink, string mainCourse, string sideDish)
    {
        this.drink.prepareDrink(drink);
        this.mainCourse.prepareMainCourse(mainCourse);
        this.sideDish.prepareSideDish(sideDish);
    }
}