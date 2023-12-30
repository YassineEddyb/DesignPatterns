
public interface Command
{
    void execute();
    void undo();
}

public class LightOnCommand : Command
{
    Light light;

    public LightOnCommand(Light light)
    {
        this.light = light;
    }

    public void execute()
    {
        light.on();
    }
    public void undo()
    {
        light.off();
    }
}

public class OpenGarageCommand : Command
{
    Garage garage;

    public OpenGarageCommand(Garage garage)
    {
        this.garage = garage;
    }

    public void execute()
    {
        garage.open();
    }
    public void undo()
    {
        garage.close();
    }
}