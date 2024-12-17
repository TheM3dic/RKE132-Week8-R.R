string path = @"E:\data\";
string fileName = "chuck.txt";
string[] lines = File.ReadAllLines(Path.Combine(path, fileName));


ShowFileContent(lines);

static string ShowFileContent(string[] fileContentArray)
{
    int i = 0
;
    foreach ( line in fileContentArray)
    {
        Console.WriteLine($"{i}. {ShowFileContent}");
        i++;
    }
}