// TODO: Declare and initialize a CD and a DVD object.

// TODO: Call each CD and DVD method to verify that they work as expected.
using SpinningDiscs;

public class Program
{

    static void Main()
    {
        /*
        CD cd = new CD(1.00, 2.5, "Poker face", ".mp3 lady gaga");
        cd.SpinDisc();
        cd.IncreaseSpinVelocity(2.00);
        cd.DecreaseSpinVelocity(4.00);

        //System.Console.WriteLine(cd.ReportInformation());
        System.Console.WriteLine(cd.ReadData());
        cd.playContent();
        cd.StoreData("new justin bieber");
        cd.extractData();

        cd.StoreData("new whatever");
        System.Console.WriteLine(cd.ReadData());
        cd.IncreaseSpinVelocity(20.0);
        System.Console.WriteLine(cd.ReportInformation());
        cd.extractData();
    

        List<Spinnable> listSpinnables = new List<Spinnable>{
                new CD(1.00, 2.0, "Poker face", ".mp3 pokerface"),
                new DVD(1.00, 2.0, "Wedding tape", ".mp4 wedding")
            };

        listSpinnables.ForEach(disc => disc.IncreaseSpinVelocity(1.00));
    
    */

        List<ISpinnable> listSpinnables = new List<ISpinnable>{
                new CD(1.00, 2.0, "Poker face", ".mp3 pokerface"),
                new DVD(1.00, 2.0, "Wedding tape", ".mp4 wedding")
            };

        listSpinnables.ForEach(disc => System.Console.WriteLine(disc.ReportInformation()));

        CD cd = new CD(1.00, 2.5, "Poker face", ".mp3 lady gaga");
        System.Console.WriteLine(cd.spinnableMethod());

    }
}