public class Remote : IBinaryState
{
    private bool isOn = false;

    public void turnOn()
    {
        isOn = true;
    }

    public void turnOff()
    {
        isOn = false;
    }

    public BinaryState State
    {
        get
        {
            if (isOn) return BinaryState.ON;
            else return BinaryState.OFF;
        }
    }
}