// Commandline utility, just in case you want to test it this way.
class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide a string to check.");
            return;
        }

        string input = args[0];
        var checker = new LeanBracketChecker(); // We could do dependency injection, but that would be silly, dont you think?
        bool result = checker.CheckBracket(input);

        Console.WriteLine($"Input: {input}");
        Console.WriteLine($"Brackets are {(result ? "balanced" : "not balanced")}.");
    }
}
