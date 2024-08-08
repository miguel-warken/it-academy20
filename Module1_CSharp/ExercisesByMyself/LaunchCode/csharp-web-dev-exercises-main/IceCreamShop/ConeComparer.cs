using IceCreamShop;

public class ConeComparer : IComparer<Cone>
{

    public ConeComparer()
    {

    }

    public int Compare(Cone c1, Cone c2)
    {
        double diff = c1.Cost - c2.Cost;
        if (diff == 0) return 0;
        else if (diff > 0) return 1;
        else return -1;
    }
}