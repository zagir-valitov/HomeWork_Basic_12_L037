using RegularСustomer;

Console.WriteLine(" ---- Home work 12. Regular customer ----\n");


var shop = new Shop();
var customer1 = new Customer();
shop.Products.CollectionChanged += customer1.OnItemChanged;

do
{
    Console.WriteLine("\nList of products:");
    foreach (var item in shop.Products)
    {
        Console.WriteLine($"ID: {item.Id}\tName: {item.Name}");
    }
    Console.Write(
        "\n-----------------------------" +
        "\nА - add product" +
        "\nD - remove product by ID" +
        "\nX - exit" +
        "\n-----------------------------" +
        "\nEnter command: ");
    string? command = Console.ReadLine();
    if (command == "A")
    {
        Console.WriteLine("\nEnter product name to add:");
        command = Console.ReadLine();
        shop.Add(command);
    }
    else if (command == "D")
    {
        Console.WriteLine("\nEnter product ID to delete: ");
        command = Console.ReadLine();
        shop.Remove(Convert.ToInt32(command));
    }
    else if (command == "X")
    {
        Console.WriteLine("Exit!");
        break;
    }
}
while (true);

//shop.Add("Tomato");
//shop.Remove(1);
