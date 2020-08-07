using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class ListFilterer
{
    public static IEnumerable<int> GetIntegersFromList1 (List<object> listOfItems)
    {
        return listOfItems.Where (x => x is int).Select (x => (int) x);
    }

    public static IEnumerable<int> GetIntegersFromList2 (List<object> listOfItems)
    {
        return listOfItems.OfType<int> ();
    }
}