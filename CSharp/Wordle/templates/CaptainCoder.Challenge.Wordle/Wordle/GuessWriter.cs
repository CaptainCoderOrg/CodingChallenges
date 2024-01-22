public class GuessWriter : IGuessWriter
{
    /// <summary>
    /// Given the correct word, the player's guess, and an IGuessChecker, writes
    /// the player's guess to the terminal.
    /// </summary>
    public void Write(string word, string guess, IGuessChecker checker)
    {
        ConsoleColor[] colors = checker.Check(word, guess);
        //TODO: Refactor to use a for loop

        Console.ForegroundColor = colors[0];
        Console.Write(guess[0]);

        Console.WriteLine(" Not Implemented!");

        // After finishing, reset the console color
        Console.ResetColor();
    }
}