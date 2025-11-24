

Func<int, int> square = x => x * x;
Action<int> printInt = i => Console.WriteLine(i);

printInt(square(5));

//static int Square(int x)
//{
//    return x * x;
//}

PrintResults(x => x * 2);

Console.WriteLine();

PrintResults(x => x % 2);

Console.WriteLine();

PrintResults(n =>
{
	int sum = 0;
	for (int i = 0; i < n; i++)
	{
		sum += i;
	}
	return sum;
});

static void PrintResults(Func<int, int> func)
{
	for (int i = 1; i <= 10; i++)
	{
        Console.WriteLine($"{i}: {func(i)}");
	}
}

Console.WriteLine();

//Func<Person, int, bool> isLegal = (person, legalAge) => person.Age >= legalAge;

//Console.WriteLine(isLegal(new Person() { Age = 15 }, 18));
//class Person
//{
//	public int Age { get; set; }
//}

Action<int, int, int> addNum = (a, b, c) => Console.WriteLine($"{a}, {b}, {c} = {a + b + c}");

addNum(5, 10, 15);

Console.WriteLine();

Func<double, double, double> volymCylinder = (r, h) => double.Round(r * r * Math.PI * h, 2);

Console.WriteLine(volymCylinder(2, 10));



