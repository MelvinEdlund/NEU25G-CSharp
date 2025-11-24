// Key word new används för att skapa ett nytt objekt (en instans av en klass):
// 1 - Allokerar minne för att lagra objektet.
// 2 - Skapar objektet på den platsen i minnet, med default värden.
// 3 - Kör konstruktorn 
// 4 - Returnerar en referens till det nya objektet.

Person myPerson = new Person("mel", 24);

//Person myOtherPerson = new Person() { name = "Seb", age = 69 }; // Age är private
// var anders = new("Anders"); // Fungerar inte man kan inte använda var tillsammans med new()

var myOtherPerson = new Person();

Person myThirdPerson = new Person("Maria");

Person myFourthPerson = new("Kalle");

Console.WriteLine();


class Person
{
    public string name = string.Empty;
    private int age = 0;
    
    public Person()
    {
        this.name = "My Person";
        this.age = 18;
    }
    public Person(string name)
    {
        this.name = name;
    }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

}

