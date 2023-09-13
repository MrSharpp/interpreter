using System.IO;
using Interpreter;

public class Bingo
{
    static bool hadError = false;
    public static void Main(string[] args)
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
        string source = System.Text.Encoding.UTF8.GetString(content);
        Console.Write(source);
        run(source);
    }

    static void run(string source)
    {
        Scanner scanner = new Scanner(source);
        List<Token> tokens = scanner.scanTokens();

        foreach (Token token in tokens)
        {
            Console.WriteLine(token);
        }
    }

    public static void error(int line, string message)
    {
        report(line, "", message);
    }

    private static void report(int line, string where, string message)
    {
        Console.WriteLine("[line " + line + "] Error" + where + ": " + message);
        hadError = true;
    }
}