# Wordle Challenge

## Overview

In this challenge, you will practice writing for loops to iterate over
characters in a string to create a game of Wordle!

## Play the Game

Before starting, play the game by running `dotnet run --project Wordle` from the
base directory.

### Rules

* The game randomly selects a 5 letter word from the `words.txt` file.
* The player attempts to guess the word in 6 or fewer guesses.
* If the player enters an invalid word, the guess does not count. Note: only
  words from the words.txt file are considered valid.
* After each guess, the guess is highlighted with green and yellow letters.
* Green letters indicate the letter is in the correct position
* Yellow letters indicate the letter is in the word but not in the correct
  position

## Tasks

In this challenge, you will implement two methods: `GuessWriter.Write` and
`GuessChecker.Check`. It is recommended that you implement `GuessWriter` first
as it will make testing your `GuessChecker` easier.

### Enable DEBUG in `Program.cs`

Start by setting the `DEBUG` variable to `true` in your `Program.cs`. This
causes the chosen word to be displayed at the start of the game. This is helpful
for debugging.

```csharp
// Set DEBUG to true to see the randomly selected word while playing
bool DEBUG = true;
```

### Implement GuessWriter

GuessWriter is used to display the player's guess with the correct colors.

By default, the program is using a working implementation of the GuessWriter.

Start by updating `Program.cs` to use your solution. This is done by commenting
out the following line:

```csharp
// TODO: 1st: Complete GuessWriter.cs
writer = new GuessWriterSolution(); // TODO: Comment this line to use your solution
```

Next, open the `GuessWriter.cs` file and implement the `GuessWriter.Write`
method:


```csharp
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
```

**Note:** This method uses `GuessChecker.Check` to retrieve an array of colors
to use when displaying the guess.

**Hint:** Write a for loop that iterates through each letter in guess and
changes the foreground color

### Implement GuessChecker

GuessChecker is used to generate the colors that should be displayed for each
letter of a player's guess.

By default, the program is using a working implementation of the GuessChecker.

Start by updating `Program.cs` to use your solution. This is done by commenting
out the following line:

```csharp
// TODO: 2nd: Complete GuessChecker.cs 
checker = new GuessCheckerSolution(); // TODO: Comment this line to use your solution
```

Next, open the `GuessChecker.cs` file and implement the `GuessChecker.Guess`
method:

```csharp
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
```

**Hints**: 
* Write a for loop that iterates over each character in word.
* If word[index] matches guess[index] then colors[index] should be ConsoleColor.Green
* Use word.Contains to check if a character is in the word