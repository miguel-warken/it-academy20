using System.Drawing;

public class FilledColoredCircle : ColoredCircle
{
    private Color filledInColor;

    public Color FilledColored { get { return filledInColor; } set { filledInColor = value; } }

    public FilledColoredCircle(double x, double y, double r, Color c) : base(x, y, r, c) { filledInColor = c; }

    public FilledColoredCircle() : this(0, 0, 0, Color.Black) { }
}