# Defuse Challenge

Defuse is a digital adaptation of the classic game [Mastermind](https://en.wikipedia.org/wiki/Mastermind_(board_game)).

## Play It

From the root directory of this project, run `dotnet Example/Defuse.dll` to play a working version of Defuse.

### Rules

* At the start of the game, the computer generates a random code. 
* The code must contain distinct letters. For example, `A A B` is
  not a valid code because it has 2 `A`s.
* The code length changes with difficulty Easy: 3, Normal: 4, Hard: 6
* Each turn, the player attempts to guess the code
* The results of the guess are displayed to the right of the board
  * A red asterisk indicates that one of the letters is correct AND in the correct position
  * A white asterisk indicates that one of the letters is correct but is NOT in the correct position.
* If a player guesses the code, they win.
* If a player fails to guess the code within the allotted number of guesses, they lose and the code is revealed.

## Overview

In this challenge, you must implement the `GuessChecker.cs` class which is used
to show the result of each guess. You should not modify any other files*.

```csharp
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
        // TODO: Implement CorrectSymbols
        // HINT: You can use code.Contains() to check if a character is in the array
        // HINT: Use a foreach loop to check if each character in guess is contained in code
        return 0;
    }
}
```

## Tests / Debugging

* A small number of tests have been provided for you in the `Tests` project. You
  can use these to give yourself confidence that your implementation is correct.

* At the top of `Program.cs`, you can modify the `bool DEBUG = false` to `true`.
  Doing so will display the randomly generated code. This can be helpful for
  testing your solution.
