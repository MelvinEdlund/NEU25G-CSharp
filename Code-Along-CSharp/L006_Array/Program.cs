string[] cities = new string[5] {"Stockholm", "Göteborg", "Malmö", "Uppsala", "Umeå"};

cities[2] = "Borås";
Console.WriteLine(cities[0]);
Console.WriteLine(cities[2]);
Console.WriteLine(cities[4]);

Console.WriteLine("\nArray length: " + cities.Length);

Console.WriteLine("\nUse a for loop to print all element of an array:");


for (int i = 0; i < cities.Length; i++)
{
    Console.WriteLine(cities[i]);
}


Console.WriteLine("\nUse a for-each loop to print all element of an array:");

foreach (string city in cities)
{
    Console.WriteLine(city);
}


Console.WriteLine("\n\nUse foreach to print double numbers");
int[] numbers = new int[] { 5, 58, 103, 281 };

foreach (int number in numbers)
{
    Console.WriteLine(number * 2);
}

