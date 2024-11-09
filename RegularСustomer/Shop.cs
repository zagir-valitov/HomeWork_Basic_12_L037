using System.Collections.ObjectModel;

namespace RegularСustomer;

internal class Shop
{
    public ObservableCollection<Item> Products = [];

    public void Add(string? productName)
    {
        Products.Add(new Item(productName));
    }
    public void Remove(int productId)
    {
        foreach (Item item in Products)
        {
            if (item.Id == productId)
            {
                Products.Remove(item);
                break;
            }
        }
    }
}
