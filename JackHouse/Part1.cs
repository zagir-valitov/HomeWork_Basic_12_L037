using System.Collections.Immutable;

namespace JackHouse;

internal class Part1
{
    public List<string> Poem { get; set; } = ["" +
        "Вот дом,\n" +
        "Который построил Джек.\n"];
    public Part1() { }
    public Part1(IEnumerable<string> partPoem)
    {
        Poem.Clear();
        Poem.AddRange(partPoem);
    }
    public void AddPart(IEnumerable<string> sourceStrings)
    {
        Poem = sourceStrings.ToImmutableList().AddRange(Poem).ToList();        
    }
}
