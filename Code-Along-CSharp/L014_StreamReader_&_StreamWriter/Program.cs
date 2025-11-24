
//Console.WriteLine($"Current Directory: {Directory.GetCurrentDirectory()}");
//Directory.SetCurrentDirectory(@"c:\");

//var path = @"C:\Users\medlu\source\repos\NEU25G_Code_Along\L013_Path_and_Directory\Program.cs";


//using (StreamReader reader = new StreamReader(path))
//{
//    //Console.WriteLine(reader.ReadToEnd());


//    while (!reader.EndOfStream)
//    {
//        Console.Write((char)reader.Read());
//        Thread.Sleep(50);
        
//    }
//}

using (var writer = new StreamWriter("myFile.txt"))
{
    writer.Write("Hello");
    writer.Write("World");

}