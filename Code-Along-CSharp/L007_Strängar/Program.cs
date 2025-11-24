
// Strängar går att indexera. De fungerar i princip som en read-only array av Char.

string myString = ("Hello World!");

// Få ut längden på myString som ett heltal
Console.WriteLine(myString.Length);

Console.WriteLine("Loopa igenom bokstav för bokstav med hjälp av index");

for (int i = 0; i < myString.Length; i++)
{
    Console.Write(myString[i]);
    if (i < myString.Length - 1)
    {
        Console.Write("-");
    }
}
Console.WriteLine();
Console.WriteLine(myString[4]);

Console.WriteLine("Loopa igenom bokstav för bokstav med foreach");


foreach (char letter in myString)
{
    Console.Write(letter);
}

// Escape sequences - backslash \ följt av vissa andra tecken har specifika betydelser
// '\n' - new line
// '\t' - tab
// '\"' - double quote (")
// '\\' - backslash (\)

// Verbatim string literal, startar med @
Console.WriteLine(@"C:\Users\Melvin\Desktop");

// Interpolation strings
Console.WriteLine($"Hello {5+5} World");
