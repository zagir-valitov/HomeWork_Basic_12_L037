using System.Collections.Immutable;

namespace JackHouse;

internal class Part2
{
    public List<string> Poem { get; set; } = ["" +
        "А это пшеница,\n" +
        "Которая в тёмном чулане хранится\n" +
        "В доме,\n" +
        "Который построил Джек.\n"];

    public Part2() { }
    public Part2(IEnumerable<string> partPoem)
    {
        Poem.Clear();
        Poem.AddRange(partPoem);
    }
    public void AddPart(IEnumerable<string> sourceStrings)
    {
        Poem = sourceStrings.ToImmutableList().AddRange(Poem).ToList();        
    }
}
