/*
    The Command Pattern encapsulates a request as an
    object, thereby letting you parameterize other objects
    with different requests, queue or log requests, and
    support undoable operations.
*/

public class RemoteControlTest
{
    public static void Main()
    {
        RemoteControl remote = new RemoteControl();

        Light light = new Light();
        LightOnCommand lightOn = new LightOnCommand(light);

        remote.setCommand(lightOn);
        remote.buttonPressed();
        remote.undoPressed();

        Garage garage = new Garage();
        OpenGarageCommand openGarage = new OpenGarageCommand(garage);

        remote.setCommand(openGarage);
        remote.buttonPressed();
        remote.undoPressed();
    }
}