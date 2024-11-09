using RegularСustomer;

Console.WriteLine(" ---- Home work 12. Regular customer ----\n");


var shop = new Shop();
var customer1 = new Customer();
shop.Products.CollectionChanged += customer1.OnItemChanged;

do
{
    Console.WriteLine("\nList of products:");
    if (shop.Products.Count == 0)
    {
        Console.WriteLine(" !!!Empty!!!");
    }
    else
    {
        foreach (var item in shop.Products)
        {
            Console.WriteLine($"ID: {item.Id}\tName: {item.Name}");
        }
    }    

    Console.Write(
        "\n-----------------------------" +
        "\nА - add product" +
        "\nD - remove product by ID" +
        "\nX - exit" +
        "\n-----------------------------" +
        "\nEnter command: ");

    string? inputLine = Console.ReadLine();
    if (inputLine == "A")
    {
        Console.WriteLine("\nEnter product name to add:");
        inputLine = Console.ReadLine();
        shop.Add(inputLine);
    }
    else if (inputLine == "D")
    {
        Console.WriteLine("\nEnter product ID to delete: ");
        inputLine = Console.ReadLine();
        shop.Remove(Convert.ToInt32(inputLine));
    }
    else if (inputLine == "X")
    {
        Console.WriteLine("Exit!");
        break;
    }
}
while (true);
