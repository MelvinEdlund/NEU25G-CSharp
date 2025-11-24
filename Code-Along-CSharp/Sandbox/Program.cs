
////string myString = null;
////string myOtherString = myString?.ToUpper();


//Car myCar = new Car();
//myCar.Engine = new Engine();
//myCar.Engine = null;

////Null conditional ?
////Console.WriteLine(myCar?.Engine?.numberOfCylinders);

//// Null coalescsing operator ?? (Cäljer den vänstra operander om den inte är null, annars den högra)
//Engine myEngine = myCar.Engine ?? new Engine() { numberOfCylinders = 8 };

//Console.WriteLine(myEngine.numberOfCylinders);

//// Arv - "Is A"-relationship

//// Komposition - "Has A"-relationship

//class Car
//{
//    // konstruktor
//    //public Car()
//    //{
//    //    this.Engine = new Engine();
//    //}
//    public string Brand { get; set; }
//    public Engine Engine { get; set; } // = new Engine();
//}

//class Engine
//{
//    public int numberOfCylinders { get; set; } = 6;
//}

// Använd generiska delegat (Func (returvärde), Action (inget returvärde)) för att lösa följande uppgifter
// Func<in T1, in T2 ..., out TResult>
// Action<in T1, in T2, ... >

// Uppgift 1:
// Skapa en funktion som tar två hel tal in, plussar ihop dem och skriver ut resultatet.
// Skapa ett generiskt delegat som pekar på metoden och använd detta för att anropa metoden.

// Uppgift 1:

Action<int, int> addAndPrint = AddNumbers;

addAndPrint(5, 7);

static void AddNumbers(int a, int b)
{
    Console.WriteLine($"Summan av {a} + {b} är {a + b}");
}

Console.WriteLine();
//  Uppgift 2:
// Skapa en funktion som tar en Char och en Int in, samt returnerar en String som innehåller
// bokstaven upprepad det antal gånger som man anger i heltalet. Använd ett generisk delegat
// För att anropa metoden. Skriv ut resultatet.

Func<char, int, string> repeatChar = RepeatChar;

Console.WriteLine(repeatChar('A', 5));

static string RepeatChar (char c, int count)
{
	string result = string.Empty;

	for (int i = 0; i < count; i++)
	{
		result += c;
	}
	return result;
}

Console.WriteLine();
// Uppgift 3: 
// Skriv en funktion som tar två heltal in, multiplicerar dem och skriver ut resultatet.
// Skriv sedan ytterligare en funktion som tar in ett heltal tillsammans med ett delegat till
// en metod som tar två heltal in. Om man skickar in t.ex 3 till denna metoden så ska den ha
// en loop i fån 1 till 10, som varje gång anropar delegatmetoden med (3 , i).
// Prova att anropa metoden dels med funktionen i uppgift 1, dels med funktionen som multiplicerar


Action<int, int> multAndPrint = MultNumbers;

static void MultNumbers (int a, int b)
{
    Console.WriteLine($"Summan av {a} * {b} är {a * b}");
}

static void MultiTable(int number, Action<int, int> delegateMethod)
{
    for (int i = 1; i <= 10; i++)
    {
        delegateMethod(number, i);
    }
}


MultiTable(3, multAndPrint);

Console.WriteLine();

MultiTable(3, addAndPrint);
