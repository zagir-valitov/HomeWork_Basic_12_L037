using System.Collections.Immutable;

namespace JackHouse;

internal class Part8
{
    public List<string> Poem { get; set; } = ["" +
        "А это ленивый и толстый пастух,\n" +
        "Который бранится с коровницей строгою,\n" +
        "Которая доит корову безрогую,\n" +
        "Лягнувшую старого пса без хвоста,\n" +
        "Который за шиворот треплет кота,\n" +
        "Который пугает и ловит синицу,\n" +
        "Которая часто ворует пшеницу,\n" +
        "Которая в тёмном чулане хранится\n" +
        "В доме,\n" +
        "Который построил Джек.\n"];

    public Part8() { }
    public Part8(IEnumerable<string> partPoem)
    {
        Poem.Clear();
        Poem.AddRange(partPoem);
    }
    public void AddPart(IEnumerable<string> sourceStrings)
    {
        Poem = sourceStrings.ToImmutableList().AddRange(Poem).ToList();
    }
}
