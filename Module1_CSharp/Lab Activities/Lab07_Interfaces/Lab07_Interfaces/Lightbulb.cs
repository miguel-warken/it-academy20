public class Lightbulb : IBinaryState
{
    private bool isOn;
    private int voltage;
    private int power;

    public Lightbulb(int v, int p)
    {
        isOn = false;
        voltage = v;
        power = p;
    }

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