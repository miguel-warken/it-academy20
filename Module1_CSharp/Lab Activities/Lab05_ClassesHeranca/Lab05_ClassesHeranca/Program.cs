using System.Drawing;

namespace Lab05_ClassesHeranca;
class Program
{
    static void Main(string[] args)
    {
        Circle c1 = new Circle();
        //System.Console.WriteLine(c1);
        Circle c2 = new ColoredCircle(2.4, 5, 3, Color.CadetBlue);
        //System.Console.WriteLine(c2 as ColoredCircle);
        // System.Console.WriteLine((c2 as ColoredCircle)?.Color);

        FilledColoredCircle filled = new FilledColoredCircle(1.0, 2.5, 2, Color.LightYellow);


        //System.Console.WriteLine((filled as ColoredCircle)?.ToString());
        //System.Console.WriteLine(filled.FilledColored);

        Circle[] arrCircles = new Circle[3];
        arrCircles[0] = c1;
        arrCircles[1] = c2;
        arrCircles[2] = filled;

        foreach (Circle circle in arrCircles)
        {
            System.Console.WriteLine(circle.ToString());
        }
    }
}
