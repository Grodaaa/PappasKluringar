using NeedHelp.Enitites;

var tableIn = new List<TableIn>();

for (int i = 1; i <= 6; i++)
{
    Random rand = new();
    int fav1 = rand.Next(1,5), fav2 = rand.Next(6, 10), fav3 = rand.Next(11, 15);

    tableIn.Add(new TableIn() { Col1 = fav1, Col2 = fav2, Col3 = fav3 });
}

Console.WriteLine("Col1\tCol2\tCol3\t");
Console.WriteLine("--------------------");

foreach (var row in tableIn)
    Console.WriteLine(row.Col1 + "\t" + row.Col2 + "\t" + row.Col3);

var tableOut = tableIn.OrderBy(x => x.Col1)
                      .GroupBy(x => GetGroupId(x))
                      .Select(x => new TableOut() { Col1 = x.Key, Col2 = x.Count() });

Console.WriteLine("Col1\t\tCol2");
Console.WriteLine("------------");
foreach (var row in tableOut)
    Console.WriteLine(row.Col1 + "\t" + row.Col2);

static string GetGroupId(TableIn tableIn)
{
    return string.Format("{0}-{1}-{2}", tableIn.Col1, tableIn.Col2, tableIn.Col3);
}