public class Termometer
{
    private double temperature;
    public Termometer()
    {
        temperature = 0.0;
    }
    public double Temperature
    {
        get { return temperature; }
    }
    public void increase(double t)
    {
        temperature += t;
    }
    public void decrease(double t)
    {
        temperature -= t;
    }
}