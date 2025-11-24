
string text = string.Empty;
text = "Hello world!";

int textLength = text.Length;

Console.WriteLine($"text = {text}\n");
Console.WriteLine($"Text.Length -> {text.Length}");

Console.WriteLine($"text.ToLower() -> {text.ToLower()}");
Console.WriteLine($"text.ToUpper() -> {text.ToUpper()}");
Console.WriteLine($"text.StartsWith(\"Hello\") -> {text.StartsWith("Hello")}");
Console.WriteLine($"text.StartsWith(\"hello\") -> {text.StartsWith("hello")}");
Console.WriteLine($"text.EndsWith(\"world!\") -> {text.EndsWith("world!")}");
Console.WriteLine($"text.EndsWith('!') -> {text.EndsWith('!')}");
Console.WriteLine($"text.Contains(\"orl\") -> {text.Contains("orl")}");
Console.WriteLine($"text.Replace('l', '-') -> {text.Replace('l', '-')}");
Console.WriteLine($"text.Remove(7) -> {text.Remove(7)}");
Console.WriteLine($"text.Remove(7,3) -> {text.Remove(7, 3)}");
Console.WriteLine($"text.Substring(7) -> {text.Substring(7)}");
Console.WriteLine($"text.Substring(7,3) -> {text.Substring(7, 3)}");
Console.WriteLine($"text.Insert(7, \"<-->\") -> {text.Insert(7, "<-->")}");
Console.WriteLine($"text.IndexOf('o') -> {text.IndexOf('o')}");
Console.WriteLine($"text.LastIndexOf('o') -> {text.LastIndexOf('o')}");

Console.WriteLine();

text = "       Hello world!       ";

Console.WriteLine($"text = {text}\n");

Console.WriteLine($"text.Trim() -> \"{text.Trim()}\"");
Console.WriteLine($"text.TrimStart() -> {text.TrimStart()}");
Console.WriteLine($"text.TrimEnd() -> {text.TrimEnd()}");

text = "This is a sample text";
Console.WriteLine($"\ntext = \" {text}\"");
Console.WriteLine("text.Split()");

string[] words = text.Split(' ');

foreach (string word in words)
{
    Console.WriteLine(word);
}


string.Join('-', words);
Console.WriteLine($"\nstring.Join('-', words) -> \"{string.Join('-', words)}\"");
Console.WriteLine($"\nstring.Join(\", \", words) -> \"{string.Join(", ", words)}\"");
Console.WriteLine($"\nstring.Join(\" \", words) -> \"{string.Join(" ", words)}\"");


Console.WriteLine("\n *** Char methods *** \n");

char myChar = 'A';
Console.WriteLine($"myChar = '{myChar}'\n");

Console.WriteLine($"char.IsUpper(myChar) -> \"{char.IsUpper(myChar)}\"");
Console.WriteLine($"char.IsLower(myChar) -> \"{char.IsLower(myChar)}\"");
Console.WriteLine($"char.ToUpper(myChar) -> \"{char.ToUpper(myChar)}\"");
Console.WriteLine($"char.ToLower(myChar) -> \"{char.ToLower(myChar)}\"");
Console.WriteLine($"char.IsDigit('R') -> \"{char.IsDigit('R')}\"");
Console.WriteLine($"char.IsDigit('7') -> \"{char.IsDigit('7')}\"");
Console.WriteLine($"char.IsLetter('R') -> \"{char.IsLetter('R')}\"");
Console.WriteLine($"char.IsLetter('7') -> \"{char.IsLetter('7')}\"");
Console.WriteLine($"char.IsLetterOrDigit('R') -> \"{char.IsLetterOrDigit('R')}\"");
Console.WriteLine($"char.IsLetterOrDigit('7') -> \"{char.IsLetterOrDigit('7')}\"");

Console.WriteLine($"char.IsWhiteSpace(' ') -> \"{char.IsWhiteSpace(' ')}\"");


