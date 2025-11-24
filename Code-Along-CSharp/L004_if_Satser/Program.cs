Console.WriteLine("Enter your name: ");
string name = Console.ReadLine().ToLower();

if (name == "melvin")
{
    Console.WriteLine("Du heter Melvin");
}
else if (name == "sebbe")
{
    Console.WriteLine("Du heter Sebbe");
}
else if (name == "sören")
{
    Console.WriteLine("Du heter Sören");
}
else
{
    Console.WriteLine("Byt namn!");
}


    Console.WriteLine();


switch(name)
{
    case "melvin":
        Console.WriteLine("Du heter Melvin");
        break;
    case "sebbe":
        Console.WriteLine("Du heter Sebbe");
        break;
    case "sören":
        Console.WriteLine("Du heter Sören");
        break;
    default: 
        Console.WriteLine("Byt namn!");
        break;
}


//  string lastName = (name == "melvin" ? "Edlund" :"unknown");    <--- Ternery operator:

string lastName;

if (name == "melvin")
{
    lastName = "Edlund";
}
else if (name == "sebbe")
{
    lastName = "Breuker";
}
else
{
    lastName = "Unknown";
}

Console.WriteLine(lastName);