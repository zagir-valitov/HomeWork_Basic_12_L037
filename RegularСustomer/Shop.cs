using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
