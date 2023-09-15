// See https://aka.ms/new-console-template for more information
using NeedHelp.Enitites;

var tableIn = new List<TableIn>()
{
    new TableIn(){ Col1 = 10, Col2 = 2, Col3 = 1 },
    new TableIn(){ Col1 = 4, Col2 = 7, Col3 = 2 },
    new TableIn(){ Col1 = 10, Col2 = 2, Col3 = 1 },
    new TableIn(){ Col1 = 6, Col2 = 4, Col3 = 3 },
    new TableIn(){ Col1 = 5, Col2 = 5, Col3 = 3 },
    new TableIn(){ Col1 = 4, Col2 = 7, Col3 = 2 }
};

Console.WriteLine("Col1\tCol2\tCol3\t");
Console.WriteLine("--------------------");
foreach (var row in tableIn)
    Console.WriteLine($"{row.Col1}\t{row.Col2}\t{row.Col3}");

var tableOut = tableIn.OrderBy(x => x.Col1)
                      .GroupBy(x => $"{x.Col1}-{x.Col2}-{x.Col3}")
                      .Select(x => new TableOut() { Col1 = x.Key, Col2 = x.Count() });

Console.WriteLine("Col1\tCol2");
Console.WriteLine("------------");
foreach (var row in tableOut)
    Console.WriteLine($"{row.Col1}\t{row.Col2}");
     