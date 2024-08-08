using IceCreamShop;

Case menu = new Case();
List<Flavor> availableFlavors = menu.Flavors;
List<Cone> availableCones = menu.Cones;

// TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
//  field.
FlavorComparer fc = new FlavorComparer();
//Sort using MY comparer that implements ICompare
availableFlavors.Sort(fc);
System.Console.WriteLine("\nOrdered Flavors by ascending allergens number:");
foreach (Flavor flavor in availableFlavors)
{
    System.Console.WriteLine(flavor.Name + " -> " + flavor.Allergens.Count);
}

// TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
//  field.
ConeComparer cc = new ConeComparer();
availableCones.Sort(cc);
System.Console.WriteLine("Ordered Cones by ascending cost:\n");
foreach (Cone cone in availableCones)
{
    System.Console.WriteLine(cone.Name + " -> " + cone.Cost.ToString());
}
// TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.