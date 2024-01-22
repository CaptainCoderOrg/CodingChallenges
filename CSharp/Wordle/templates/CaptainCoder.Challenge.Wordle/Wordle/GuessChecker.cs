public class GuessChecker : IGuessChecker
{
    /// <summary>
    /// Given the word that is being guessed and the player's guess. Returns an
    /// array containing 5 console colors representing the correctness of the 
    /// player's guess. 
    /// 
    /// ConsoleColor.Green is a letter that is correct and in the correct position,
    /// ConsoleColor.Yellow is a letter that is in the word but is not in the correct position,
    /// ConsoleColor.White is a letter that is not in the word.
    /// </summary>
    public ConsoleColor[] Check(string word, string guess)
    {
        // TODO: Implement 
        ConsoleColor[] colors = new ConsoleColor[5];
        colors[0] = ConsoleColor.White;
        colors[1] = ConsoleColor.White;
        colors[2] = ConsoleColor.White;
        colors[3] = ConsoleColor.White;
        colors[4] = ConsoleColor.White;
        return colors;
    }

}