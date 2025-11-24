
Console.WriteLine("*** Path ***\n");

Console.WriteLine($"Path.VolumeSeparatorChar -> {Path.VolumeSeparatorChar}");
Console.WriteLine($"Path.DirectorySeparatorChar -> {Path.DirectorySeparatorChar}\n");

string path = Path.Combine("c:", "users", "medlu", "downloads", "infotext.txt");
Console.WriteLine($"Path.Combine -> {path}\n");

// path = @"c:\users\medlu\downloads\music.mp3";

Console.WriteLine($"Path.GetFileName(Path) -> {Path.GetFileName(path)}");
Console.WriteLine($"Path.GetFileNameWithoutExtension(Path) -> {Path.GetFileNameWithoutExtension(path)}");
Console.WriteLine($"Path.GetExtension(Path) -> {Path.GetExtension(path)}");
Console.WriteLine($"Path.GetDirectoryName(Path) -> {Path.GetDirectoryName(path)}");
Console.WriteLine($"Path.GetPathRoot(Path) -> {Path.GetPathRoot(path)}");
Console.WriteLine($"Path.GetFullPath(Path) -> {Path.GetFullPath(path)}\n");

Console.WriteLine($"Path.Exists(Path) -> {Path.Exists(path)}\n");

Console.WriteLine("*** Directory ***\n");

path = @"c:\users\medlu\documents";
Console.WriteLine($"Path -> {path}\n");

Console.WriteLine($"Directory.Exists(Path) -> {Directory.Exists(path)}");
Console.WriteLine($"Directory.GetDirectoryRoot(Path) -> {Directory.GetDirectoryRoot(path)}");
Console.WriteLine($"Directory.GetParent(Path) -> {Directory.GetParent(path)}\n");

Console.WriteLine("Directory.GetDirectories(path): ");
foreach (string subdir in Directory.GetDirectories(path))
{

Console.WriteLine($"{subdir}");
}

Console.WriteLine("\nDirectory.GetFiles(path, \"*txt\"): ");
foreach (string filepath in Directory.GetFiles(path, "*txt"))
{
    Console.WriteLine(filepath);
}

string newPath = Path.Combine(path, "newFolder", "test", "csharp");
Console.WriteLine($"\nCreate folder: {newPath}\n");

Directory.CreateDirectory(newPath);

string removePath = Path.Combine(path, "newFolder");
Console.WriteLine($"\nDelete folder: {removePath}\n");

//Removes directory only if empty otherwise throw exception
//Directory.Delete(removePath);

//Removes directory and all subdirectories and files without asking
//Directory.Delete(removePath, true);

