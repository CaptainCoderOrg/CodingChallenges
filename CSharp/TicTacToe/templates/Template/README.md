# TicTacToe Challenge

## Overview

In this challenge, you will finish an implementation of a TicTacToe game.

## Example Solution

You can play a completed version of the game by running `dotnet
Example/TicTacToe.dll` from the root directory.

## Running the Program

From the base directory, you can run your solution with `dotnet run --project TicTacToe`

## Overview

A `TicTacToe` class file has been provided for you that has two public fields:

```csharp
    /// <summary>
    /// Represents the state of the TicTacToe board. A single digit representing
    /// '0', '1', '2', '3', '4', '5', '6', '7', '8' represents an unoccupied position. An X represents
    /// a move made by player 1. An O represents a move made by player 2.
    /// </summary> 
    public char[] Board;

    /// <summary>
    /// Represents the which player is currently making a move
    /// </summary>
    public int CurrentPlayer;
```

Additionally a `Stringify` method has been provided for you which returns a
string representation of the board that is displayed in the terminal during
game play.

```csharp
    public string Stringify()
    {
        string asString = string.Empty;
        asString += $"{Board[0]} | {Board[1]} | {Board[2]}\n";
        asString += $"--|---|--\n";
        asString += $"{Board[3]} | {Board[4]} | {Board[5]}\n";
        asString += $"--|---|--\n";
        asString += $"{Board[6]} | {Board[7]} | {Board[8]}";
        return asString;
    }
```

## Tasks

It is recommended that you complete the tasks in this order. Unit test have been
provided to give you confidence that you've implemented each part correctly.

### 1. Constructor

```csharp
/// <summary>
/// Initializes the Board to contain the positions 0, 1, 2, 3, 4, 5, 6, 7, and 8.
/// Initializes the CurrentPlayer to 1.
/// </summary>
public TicTacToe()
{
    // TODO: Initialize Board to contain the digits '0' to '8'
    // TODO: Initialize CurrentPlayer to be 1
} 
```

Tests: `initializes_with_board_of_numbers` and `initializes_with_CurrentPlayer_1`

### 2. Switch Player

```csharp
/// <summary>
/// Switches the current player.
/// </summary>
public void SwitchPlayer()
{
    // TODO: Implement switch player
}
```

Test: `SwitchPlayer_should_change_CurrentPlayer`

### 3. MakeMove

```csharp
/// <summary>
/// Makes a move for the current player at the specified position. Returns
/// true if the move was successful, and false if the cell is already
/// occupied or out of bounds.
/// </summary>
public bool MakeMove(int position)
{
    // TODO: Implement make move
    return false;
}
```

Test: `MakeMove_should_return_false_when_occupied`, `MakeMove_should_return_false_if_invalid_location`, `MakeMove_should_place_X_when_CurrentPlayer_is_1`, and `MakeMove_should_place_O_when_CurrentPlayer_is_2`

### 4. CheckWin

```csharp
/// <summary>
/// Returns true if the current player has won the game and false otherwise.
/// Hint: You may find it helpful to write several smaller methods:
/// CheckTopRow, CheckMidRow, CheckBottomRow, CheckLeftCol, CheckMidCol,
/// CheckRightCol, CheckDiagOne, CheckDiagTwo
/// </summary>
public bool CheckWin()
{
    // TODO: Implement check win
    return false;
}
```

Tests: `top_row_win_player_1`, `mid_row_win_player_2`, `bottom_row_win_player_1`, `left_column_win_player_2`, `center_column_win_player_1`, `right_column_win_player_2`, `left_diag_win_player_1`, `right_diag_win_player_2`, `right_diag_no_win_player_1`,

    
### 5. CheckDraw

```csharp
/// <summary>
/// Returns true if the current game is a draw. A game is a draw if
/// CheckWin() is false and no more moves can be made.
/// </summary>
public bool CheckDraw()
{
    // TODO: Implement check draw
    return false;
}
```

Tests: `check_is_draw`, `check_not_a_draw_when_won`, `check_not_draw2`, `check_not_draw`