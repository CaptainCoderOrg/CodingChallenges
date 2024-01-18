/// <summary>
/// Represents a Board in the Defuse game.
/// </summary> 
public class Board 
{
    /// <summary>
    /// The sequence of characters that is being guessed.
    /// </summary> 
    public char[] Code { get; }

    /// <summary>
    /// The characters that can be guessed
    /// </summary>
    public char[] Options { get; }

    /// <summary>
    /// A list containing previous guesses
    /// </summary>
    public List<char[]> History { get; }

    /// <summary>
    /// The maximum number of guesses that are allowed
    /// </summary>
    public int MaxGuesses { get; }

    /// <summary>
    /// The number of guesses that have been made
    /// </summary>
    public int Guesses => History.Count;

    /// <summary>
    /// The number of guesses remaining
    /// </summary>
    public int GuessesRemaining => MaxGuesses - Guesses;
    
    /// <summary>
    /// Constructs a board with the specified code, maximum number of guess, and options.
    /// </summary>
    public Board(char[] code, int maxGuesses, char[] options)
    {
        Code = code;
        Options = options;
        MaxGuesses = maxGuesses;
        History = new List<char[]>();
    }

    /// <summary>
    /// Adds the specified guess to the board and returns true if the guess matches the code.
    /// </summary>
    public bool Guess(char[] guess)
    {
        History.Add(guess);
        return guess.SequenceEqual(Code);
    }


    /// <summary>
    /// Generates a random password of the specified length using the specified options.
    /// </summary>
    public static char[] GeneratePassword(int length, char[] options)
    {
        char[] clone = [.. options];
        Random.Shared.Shuffle(clone);
        return [.. clone.Take(length)];
    }
}