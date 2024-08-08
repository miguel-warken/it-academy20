namespace Lab07_Interfaces;
class Program
{
    static void Main(string[] args)
    {
        IBinaryState[] list = new IBinaryState[3];
        list[0] = new Lightbulb(110, 60);
        list[0].turnOn();
        list[1] = new ElectricTermometer();
        list[2] = new Remote();
        list[2].turnOff();
        for (int i = 0; i < 3; i++)
        {
            System.Console.WriteLine(list[i].State);
        }
    }
}
