/// <summary>
/// A utility class that calculates the result of a guess.
/// </summary>
public class GuessChecker
{
    /// <summary>
    /// Given a code sequence, and a guess, returns the number of characters in the
    /// guess that have the correct symbol and the correct position.
    /// </summary>
    public int Correct(char[] code, char[] guess)
    {
        int matches = 0;
        // TODO: Implement Correct
        // HINT: Use a for loop to iterate through each index of code and compare it to guess
        return matches;
    }
    
    /// <summary>
    /// Given a code sequence, and a guess, returns the number of characters in the
    /// guess that are in the code but are not in the correct position.
    /// </summary>
    public int CorrectSymbols(char[] code, char[] guess)
    {
        int matches = 0;
        // TODO: Implement CorrectSymbols
        // HINT: You can use code.Contains() to check if a character is in the array
        // HINT: Use a foreach loop to check if each character in guess is contained in code
        // HINT: Do not count characters that are in the correct position
        return matches - Correct(code, guess);
    }
}