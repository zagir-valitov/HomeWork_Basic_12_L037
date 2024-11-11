using System.Collections.Immutable;

namespace JackHouse_Lyrics;

internal class Part4
{
    public List<string> Poem { get; set; } = [];
    public Part4(List<string> poem)
    {
        Poem.AddRange(poem);
    }

    public void AddPart(List<string> sourceString)
    {
        Poem.AddRange(sourceString);
    }
}
