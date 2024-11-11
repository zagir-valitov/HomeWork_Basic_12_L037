using System.Collections.Immutable;

namespace JackHouse;

internal class Part6
{
    public List<string> Poem { get; set; } = ["" +
        "А это корова безрогая,\n" +
        "Лягнувшая старого пса без хвоста,\n" +
        "Который за шиворот треплет кота,\n" +
        "Который пугает и ловит синицу,\n" +
        "Которая часто ворует пшеницу,\n" +
        "Которая в тёмном чулане хранится\n" +
        "В доме,\n" +
        "Который построил Джек.\n"];

    public Part6() { }
    public Part6(IEnumerable<string> partPoem)
    {
        Poem.Clear();
        Poem.AddRange(partPoem);
    }
    public void AddPart(IEnumerable<string> sourceStrings)
    {
        Poem = sourceStrings.ToImmutableList().AddRange(Poem).ToList();
    }
}
