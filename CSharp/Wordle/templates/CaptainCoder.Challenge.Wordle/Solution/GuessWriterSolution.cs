public class GuessWriterSolution : IGuessWriter
{
    public void Write(string word, string guess, IGuessChecker checker)
    {
        ConsoleColor[] colors = checker.Check(word, guess);
        for (int ix = 0; ix < guess.Length; ix++)
        {
            Console.ForegroundColor = colors[ix];
            Console.Write(guess[ix]);
        }
        Console.ResetColor();
        Console.WriteLine();
    }
}