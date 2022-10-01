using AlgorithmsLibrary.Sort;

var sorter = new Insertion();
var rnd = new Random();
var seq = new int[rnd.Next(100)];

for (int i = 0; i < seq.Length; i++)
{
    seq[i] = rnd.Next();
}

sorter.Sort(seq);

foreach (var item in seq)
{
    Console.WriteLine(item);
}
