
using System.Diagnostics;

static void FunctionA()
{
    Console.WriteLine("This is FunctionA. ");
    FunctionB();
    Console.WriteLine("End of FunctionA. ");
}


static void FunctionB()
{
    Console.WriteLine("This is FunctionB. ");
    FunctionC();
    Console.WriteLine("End of FunctionB. ");
}

static void FunctionC()
{
    Console.WriteLine("This is FunctionC.");
}

FunctionA();

Console.WriteLine();




// En funktion kan ta 0, 1 eller flera imparametrar. 
// Parametrar skrivs kommaseparerade i parantesen efter funktionsnamnet.
// Varje parameter har en datatyp. (Datatypen anges alltså per parameter.)

// En funktions signatur består av namnet på funktionen följt av parametrar i parantesen.
// Man kan ange att en parameter är "Optional" genom att ge den ett default-värde. 
static void MyFunction(string text, int count = 3, int numberOfExclamation = 3)
{
    for (int i = 0; i < count; i++)
    {
        Console.Write(text);
        for (int j = 0; j < numberOfExclamation; j++)
        {
            Console.Write("!");
        }
        Console.WriteLine();
    }
}

//Indata vid funktionsanrop kallas för argument. 
// Agumennt måste matcha funktionens parametrar i antal och datatyper.
// Argument skickas tolkas normalt i samma ordning som parametrarna är angivna.
// Man kan också använda "Named Arugments" för att ange annan ordning, eller hoppa över vissa.

MyFunction("Min text", 5);
MyFunction("Lorem ipsum");
MyFunction("hello", 2, 5);

Console.Write("Skriv text: ");
string text = Console.ReadLine();
Console.WriteLine("Ange hur många utropstecken");
int numberOfExclamation = Int32.Parse(Console.ReadLine());
MyFunction(text, 2, numberOfExclamation);




Uppgift1: Skriv en funktion som tar två heltal int och skriver ut summan av dessa på skärmen.
static void AdditionFunction(int num1, int num2)
{
    Console.WriteLine(num1 + num2);
}
AdditionFunction(5, 2);

Uppgift2: Skriv en funktion som tar två heltal int och skriver ut en sträng "2 * 4 = 8".
using System.Xml;

static void GångerFunction(int x, int y)
{
    Console.WriteLine($"{x} * {y} = {x * y}");
}
Console.Write("Skriv in ett tal. ");
int x = Int32.Parse(Console.ReadLine());

Console.Write("Skriv in ett till tal. ");
int y = Int32.Parse(Console.ReadLine());

GångerFunction(x, y);


En funktion kan returnera 0 eller 1 objekt. 
 Man anger datatypen på objektet som returneras före funktionsnamnet. 
 Alternativt använd "void" om funktionen inte returnerar ett värde.
 Koden (i funktionen) måste ALLTID returnera en matchande datatyp.
static string AddNumbers(int a, int b)
{
    if (a < 10)
    {
        return $"{a} + {b} = {a + b}";
    }
    return "du skrev större än 10";
}

string sum = AddNumbers(13, 5);

Console.WriteLine(sum);

Console.WriteLine(AddNumbers(3, 7));


Uppgift3: Skriv en funktion som tar en char och en int och returnerar en string med tecknet
 upprepat x antal gånger. Skriv sedan ut resultatet på skärmen.
 Ex. GetMultipleChars('a', 5) -> "AAAAA"
static string GetMultipleChars(char tecken, int count)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result += tecken;
    }
    return result;
}
Console.Write("Skriv in ett tecken: ");
char tecken = char.Parse(Console.ReadLine());

Console.Write("Skriv in en siffra: ");
int count = Int32.Parse(Console.ReadLine());


Console.WriteLine(GetMultipleChars(tecken, count));


Uppgift4: Skriv en funktion som tar två heltal 'multiple' och 'length' och returnerar till en int[]
Med längden 'length' där varje element är multiplar av 'multiple'
 Ex. GetMultiples(3, 5); -> int[5] { 3, 6, 9, 12, 15}
 Spara värdet som funktionen returnerar i en variabel, och skriv sedan ut alla värden på skärmen.

static int[] Multiplicera(int multiple, int length)
{
    int[] intArray = new int[length];

    for (int i = 0; i < length; i++)
    {
        intArray[i] = (i + 1) * multiple;
    }
    return intArray;
}
int[] myMultiple = Multiplicera(3, 5);

foreach (var m in myMultiple)
{
    Console.WriteLine(m);
}

Console.WriteLine();

// Keyword 'params' kan användas för att ta in ett okänt antal parametrar av samma datatyp. 
// Man kan bara ha en params och den måste vara sista parametern
static int AddMultipleNumbers(params int[] numbers)
{
	int result = 0;
	for (int i = 0; i < numbers.Length; i++)
	{
		result += numbers[i];
	}
	return result;
}

//int[] myNumbers = new int[] { 1, 3, 7, 5 };
Console.WriteLine(AddMultipleNumbers(1, 3, 7, 5));


// Exempel på hur man kan använda string.Join() för att skriva ut alla element i en array.
Console.WriteLine(string.Join("-", 5, 6, 10, 39, 21));

Console.WriteLine();



// Funktioner märkta med 'static' har inte åtkomst till objekt deklarerade utanför funktionen.
int count = 3;
static void ExampleWithStatic(int count)
{
    Console.WriteLine(count);  // <-- count = 3 kan inte läsas här. den läser 7.
}

void ExampleWithoutStatic()
{
    Console.WriteLine(count);
}

ExampleWithStatic(7);
ExampleWithoutStatic();
