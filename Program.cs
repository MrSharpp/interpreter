using System.IO;

public class Bingo
{
    public static void main(string[] args)
    {
        if (args.Length > 1)
        {
            Environment.Exit(0);
        }
        else if (args.Length == 1)
        {
            runFile(args[0]);
        }
    }

    static void runFile(string path)
    {
        byte[] content = File.ReadAllBytes(path);
        string stringCont = System.Text.Encoding.UTF8.GetString(content);
    }
}