public class ResultWriter : IResultWriter
{
    public void Write(SymbolResult[] results)
    {
        foreach (SymbolResult result in results)
        {
            Console.ForegroundColor = Color(result);
            Console.Write($"{result.Symbol}");
        }
        Console.ResetColor();
        Console.WriteLine();
    }

    private ConsoleColor Color(SymbolResult result)
    {
        if (result.IsCorrect) { return ConsoleColor.Green; }
        if (result.IsInWord) { return ConsoleColor.Yellow; }
        return ConsoleColor.Gray;
    }
}