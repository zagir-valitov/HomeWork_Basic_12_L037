using System.Collections.Specialized;

namespace RegularСustomer;

internal class Customer
{
    public void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add:
                if (e.NewItems?[0] is Item newProduct)
                {
                    Console.WriteLine($"Added {newProduct.Name} on {DateTime.Now}");
                }
                break;
            case NotifyCollectionChangedAction.Remove:
                if (e.OldItems?[0] is Item oldProduct)
                {
                    Console.WriteLine($"Product removed: {oldProduct.Name}");
                }
                break;
        }
    }
}
