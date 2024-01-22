public class GuessCheckerSolution : IGuessChecker
{
    public SymbolResult[] CheckGuess(string word, string guess)
    {
        SymbolResult[] results = new SymbolResult[word.Length];

        for (int ix = 0; ix < guess.Length && ix < word.Length; ix++)
        {
            if (word[ix] == guess[ix])
            {
                results[ix] = new SymbolResult(guess[ix], true, true);
            }
            else if (word.Contains(guess[ix]))
            {
                results[ix] = new SymbolResult(guess[ix], false, true);
            }
            else
            {
                results[ix] = new SymbolResult(guess[ix], false, false);
            }
        }
        
        return results;
    }

}