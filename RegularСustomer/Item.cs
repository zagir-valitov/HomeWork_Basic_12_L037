namespace RegularСustomer;

internal class Item
{
    private static int _count;
    public int Id { get; set; }
    public string? Name { get; set; }

    public Item(string? name)
    {
        Name = name;
        _count++;
        Id = _count;
    }
}
