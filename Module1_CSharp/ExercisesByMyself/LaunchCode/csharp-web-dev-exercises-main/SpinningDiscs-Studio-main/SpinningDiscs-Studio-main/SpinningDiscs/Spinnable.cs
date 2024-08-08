public abstract class Spinnable
{
    private double spinVelocity;
    private double discRadius;
    private string title;
    private List<string> data;

    public double SpinVelocity { get { return spinVelocity; } set { spinVelocity = value; } }

    public double DiscRadius { get { return discRadius; } set { discRadius = value; } }

    public string Title { get { return title; } set { title = value; } }

    public List<string> Data { get { return data; } }

    public Spinnable(double sv, double dr, string t)
    {
        spinVelocity = sv;
        discRadius = dr;
        title = t;
        data = new List<string>();
    }

    //Here I'm writing these methods' bodies because derived classes won't do there any differently

    public void IncreaseSpinVelocity(double inc)
    {
        spinVelocity += inc;
        System.Console.WriteLine($"Speed increased by {inc}! Current speed: {spinVelocity}");
    }

    public void DecreaseSpinVelocity(double inc)
    {
        if (spinVelocity - inc < 0)
        {
            //Stopped
            spinVelocity = 0;
        }
        else
        {
            SpinVelocity -= inc;
        }
        System.Console.WriteLine($"Speed decreased by {inc}! Current speed: {spinVelocity}");

    }

    public virtual string spinnableMethod()
    {
        return "Hello, I am a spinnable disc!";
    }
}