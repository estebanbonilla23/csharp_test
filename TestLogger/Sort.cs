using System.Diagnostics;

namespace Store
{
    public class Sort
    {

        internal static List<Product> getProductSorted(List<Product> list, string sortKey, Boolean ascending)
        {
            List<Product> sortedList = new List<Product>();

            

            switch (sortKey)
            {
                case "name":
                    if (ascending) {
                        sortedList = list.OrderBy(o => o.name).ToList();
                     }
                    else
                    {
                        sortedList = list.OrderByDescending(o => o.name).ToList();
                    }
                    
                    break;
                case "price":
                    if (ascending)
                    {
                        sortedList = list.OrderBy(o => o.price).ToList();
                    }
                    else
                    {
                        sortedList = list.OrderByDescending(o => o.price).ToList();
                    }
                    break;
                case "stock":
                    if (ascending)
                    {
                        sortedList = list.OrderBy(o => o.stock).ToList();
                    }
                    else
                    {
                        sortedList = list.OrderByDescending(o => o.stock).ToList();
                    }
                    break;
                default:
                    Debug.WriteLine(String.Format("invalid option: {0}", sortKey));
                    break;
            }
            return sortedList;
        }
    }
}
