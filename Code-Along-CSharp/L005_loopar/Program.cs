
//string name = string.Empty;

//while (name != "melvin")
//{
//    Console.Write("¨Gissa ditt namn: ");
//    name = Console.ReadLine().ToLower();
//}
//Console.WriteLine("DU GISSADE RÄTT!");



//string name = string.Empty;

//do
//{
//    Console.Write("¨Gissa ditt namn: ");
//    name = Console.ReadLine().ToLower();
//} while (name != "melvin");

//Console.WriteLine("DU GISSADE RÄTT!");

//int i = 0;
//while (i < 10)
//{
//    i++;
//    Console.WriteLine(i);

//    if (i > 5) break;    // break avslutar loopen helt
//}


for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
    if (i == 5)
    {     
        break;
    }
}

for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        continue;
        Console.WriteLine(i);
    }
}



//int j = 1;
//while (i <= 10)
//{
//    j++;
//    if (j == 5) continue;   // Continue avlsuta pågående iteration (varv) i loopen och fortsätta på nästa varv
//    Console.WriteLine(j);
//}

//for (int j = 10; j >= 1; j--)
//{
//    Console.WriteLine(j);
//}
