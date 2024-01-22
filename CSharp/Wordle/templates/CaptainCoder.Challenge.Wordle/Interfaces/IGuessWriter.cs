/// <summary>
/// Provides a method for writing the result of a player's guess in a game of wordle.
/// </summary>
public interface IGuessWriter
{
    /// <summary>
    /// Given the correct word, the player's guess, and an IGuessChecker, writes
    /// the player's guess to the terminal.
    /// </summary>
    public void Write(string word, string guess, IGuessChecker checker);
}