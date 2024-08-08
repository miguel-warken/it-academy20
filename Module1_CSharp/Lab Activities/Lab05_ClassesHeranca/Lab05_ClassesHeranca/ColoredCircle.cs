using System.Drawing;

public class ColoredCircle : Circle
{
    private Color myColor;

    public Color Color
    {
        get { return myColor; }
        set { myColor = value; }
    }

    public ColoredCircle()
    {
        myColor = Color.Black;
    }

    public ColoredCircle(double x, double y, double z, Color c) : base(x, y, z)
    {
        myColor = c;
    }

    public override string ToString()
    {
        return base.ToString() + "Cor =" + Color;
    }
}
