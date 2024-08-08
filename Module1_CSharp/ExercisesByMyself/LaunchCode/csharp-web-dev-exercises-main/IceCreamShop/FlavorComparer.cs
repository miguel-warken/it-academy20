using IceCreamShop;

public class FlavorComparer : IComparer<Flavor>
{

    public FlavorComparer()
    {

    }
    /* By name
    public int Compare(Flavor f1, Flavor f2)
    {
        return string.Compare(f1.Name, f2.Name);
    }*/

    public int Compare(Flavor f1, Flavor f2)
    {
        double diff = f1.Allergens.Count - f2.Allergens.Count;
        if (diff == 0) return 0;
        else if (diff > 0) return 1;
        else return -1;
    }
}
