
// Variables (Variabler) - En behållare för att lagra data (av en given typ)

// Variabler måste deklareras innan de kan användas i C#

using System;

int x;
int y = 3;
double z = 3.45;
char letterA = 'A';      // Char literal values surrounded by singe quotes ''
string name = "Melvin";  // String literal values surrounded by double quotes ""
bool isEnabled = true;


// Data types (Datatyper) - Anger vilken typ av data vi lagrar i t.ex en variabel.
// t.ex int, double, char, string, bool

// Deklarerade variabler
// t.ex x, y, z, letterA, name, isEnabled

// Literal values
// t.ex 3, 3.45, 'a', "Melvin", true
// Litteral valuese Kan använda sig av suffix för att avgöra typen på det "hårdkodade" värdet.
// t.ex 1.0f är float-värdet medan 1.0 är double-värdet.

// C# är ett statiskt typat språk: Innan koden kompileras måste datatypen för varje enskild variabel vara känd.

// C# är ett starkt typat språk: Om man försöker sätta in data av felaktig typ i en variabel så resulterar det i ett kompileringsfel.
// name = 3; <-- Ger ett kompileringsfel

// C# är ett typsäkert språk:
// Man kan bara utföra operationer som en given datatyp tillåter 
Console.WriteLine(y + 3);
// Console.WriteLine(isEnabled + 3); <-- Otillåten operation mellan bool och int.

// byte myByte = 300;
short myShort = 300;
// byte myOtherByte = -2;
sbyte mySignedByte = -2;


// Implicit (underförstått) typade variabler. - Med keyword 'var' så avgör kompilatorn datatyp.
var myVariable = 5;   // Int
// myVariable = 5.3;  // Låst till Int
var myDecimal = 5.3m; // Decimal
var myFloat = 5.3f;   // Float
var myDouble = 5.3;   // Double

// Explicit(uttryckligen) typade variabler. - Vi har uttryckligen i koden angett att datatype på myInt är 'int'.
int myInt;   // Likvärdig med Int32 myInt; ('Int32' är namnet på .NET-typen, och 'int' är C# alias för 'Int32'.)


// Scope - En variables (ett objekts) livstid (lifetime).
// Class-scope, Method-scope & Block-scope


// Block-Scope
bool myBool = false;

if (isEnabled)
{
    bool myOtherBool = true;

    if (1==1)
    {
        myBool = true;
        bool myThirdBool = true;

        Console.WriteLine(myBool);
        Console.WriteLine(myOtherBool);
        Console.WriteLine(myThirdBool);

    }

    Console.WriteLine(myBool);
    Console.WriteLine(myOtherBool);
    Console.WriteLine(myThirdBool);
}

Console.WriteLine(myBool);
Console.WriteLine(myOtherBool);
Console.WriteLine(myThirdBool);