
Person myPerson = new("Mel") { FirstName = "Melvin" };
// myPerson.FirstName = "Bertil"; - FirstName kan inte sättas här eftersom den använder accesorn init iställe för set.
Console.WriteLine(myPerson.Name);

myPerson.Name = "Seb";
Console.WriteLine(myPerson.Name);
//Console.WriteLine(myPerson.name);
//myPerson.name = "Melvin Edlund"; // fungerar inte om myPerson.name är private
//Console.WriteLine(myPerson.GetName());

//myPerson.SetName("Melvin");
//Console.WriteLine(myPerson.name);

//myPerson.Name = "Sebbe";
//Console.WriteLine(myPerson.Name);

myPerson.Age = 25;
var myInt = myPerson.Age;

Console.WriteLine(myPerson.Length);

Console.WriteLine(myPerson.LastName);

class Person
{
    private string name = string.Empty;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value.Length > 10)
            {
                throw new ArgumentException();
            }
            this.name = value;
        }
    }
    // Backing field till Age, privat och börjar med _
    private int _age = 0;
    // Property (Code snippet = 'propfull')
    public int Age
    {
        get { return this._age; }
        set { this._age = value; }
    }

    // Auto-property (code snippet = 'prop')
    public double Length { get; set; } = 1.85; // Autoproperty har en dold backing-field men den kan ta ett initialt värde: i detta fall 1.85.

    public string FirstName { get; init; } // Kan bara sättas i konstruktorn eller i samband med new() sedan är den read only.

    public string LastName { get; private set; } = "Edlund"; // Publikt/Externt är den readonly men internt i klassen är den read/write.

    // Konstruktor
    public Person(string name)
    {
        this.name = name;
    }
    

    public string GetName()
    {
        return this.name;
    }
    public void SetName(string newName)
    {
        if (newName.Length>10)
        {
            throw new ArgumentException();
        }
        this.name = newName;

    }
}

