
public class Adapter : Duck
{
    Turkey turkey;

    public Adapter(Turkey turkey)
    {
        this.turkey = turkey;
    }

    public void fly()
    {
        for (var i = 0; i < 5; i++)
            turkey.fly();
    }

    public void quack()
    {
        turkey.gobble();
    }
}