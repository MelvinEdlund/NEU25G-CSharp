
//foreach (var s in GetString())
//{
//    Console.WriteLine(s);
//}


//IEnumerable<string> GetString()
//{
//    yield return "First";
//    yield return "Second";
//    yield return "Third";
//}

IEnumerable<int> GenerateWithoutYield()
{
    var list = new List<int>();
    for (int i = 0; i < 100_000_000; i++)
    {
        list.Add(i);
    }

    return list;
}

IEnumerable<int> GenerateWithYield()
{
    for (int i = 0; i < 100_000_000; i++)
    {
        yield return i;
    }
}

foreach (var i in GenerateWithYield().Skip(10).Take(5))
{
    Console.WriteLine(i);
}




