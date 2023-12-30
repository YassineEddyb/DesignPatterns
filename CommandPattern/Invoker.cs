
public class RemoteControl
{
    Command button;

    public RemoteControl() { }

    public void setCommand(Command command)
    {
        button = command;
    }

    public void buttonPressed()
    {
        button.execute();
    }
    public void undoPressed()
    {
        button.undo();
    }
}