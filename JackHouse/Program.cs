using JackHouse;
using System.Collections.Immutable;

Console.WriteLine(" ---- Home work 12. Lyrics: This is the House That Jack Built ----");

var poem = new List<string>();
//ImmutableList<string> t = ["abcd"];

var part1 = new Part1();
var part2 = new Part2();
var part3 = new Part3();
var part4 = new Part4();
var part5 = new Part5();
var part6 = new Part6();
var part7 = new Part7();
var part8 = new Part8();
var part9 = new Part9();

//part9.AddPart(part8.Poem);
//part8.AddPart(part7.Poem);
//part7.AddPart(part6.Poem);
//part6.AddPart(part5.Poem);
//part5.AddPart(part4.Poem);
//part4.AddPart(part3.Poem);
//part3.AddPart(part2.Poem);
//part2.AddPart(part1.Poem);
//part1.AddPart(poem);

//List<string> list = new List<string>();
//list.AddRange(part1.Poem);
//list.AddRange(part3.Poem);
//list.AddRange(part5.Poem);
//list.AddRange(part7.Poem);
//list.AddRange(part9.Poem);
//foreach (var part in list) 
//{
//    Console.WriteLine(part);
//}

//part1.AddPart(t);

part1.AddPart(poem);
part2.AddPart(part1.Poem);
part3.AddPart(part2.Poem);
part4.AddPart(part3.Poem);
part5.AddPart(part4.Poem);
part6.AddPart(part5.Poem);
part7.AddPart(part6.Poem);
part8.AddPart(part7.Poem);
part9.AddPart(part8.Poem);

foreach (var part in part9.Poem)
{
    Console.WriteLine(part);
}

;