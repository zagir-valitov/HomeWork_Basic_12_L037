using System.Collections.Immutable;

namespace JackHouse;

internal class Part5
{
    public List<string> Poem { get; set; } = ["" +
        "Вот пёс без хвоста,\n" +
        "Который за шиворот треплет кота,\n" +
        "Который пугает и ловит синицу,\n" +
        "Которая часто ворует пшеницу,\n" +
        "Которая в тёмном чулане хранится\n" +
        "В доме,\n" +
        "Который построил Джек.\n"];

    public Part5() { }
    public Part5(IEnumerable<string> partPoem)
    {
        Poem.Clear();
        Poem.AddRange(partPoem);
    }
    public void AddPart(IEnumerable<string> sourceStrings)
    {
        Poem = sourceStrings.ToImmutableList().AddRange(Poem).ToList();
    }
}
