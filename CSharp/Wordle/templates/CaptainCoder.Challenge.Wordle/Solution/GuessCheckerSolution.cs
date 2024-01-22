public class GuessCheckerSolution : IGuessChecker
{
    public ConsoleColor[] Check(string word, string guess)
    {
        ConsoleColor[] results = new ConsoleColor[word.Length];
        for (int ix = 0; ix < results.Length; ix++)
        {
            if (word[ix] == guess[ix])
            {
                results[ix] = ConsoleColor.Green;
            }
            else if (word.Contains(guess[ix]))
            {
                results[ix] = ConsoleColor.Yellow;
            }
            else
            {
                results[ix] = ConsoleColor.Gray;
            }
        }
        return results;
    }

}