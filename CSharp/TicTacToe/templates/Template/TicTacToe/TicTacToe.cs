public class TicTacToe
{
    /// <summary>
    /// Represents the state of the TicTacToe board. A single digit representing
    /// 0, 1, 2, 3, 4, 5, 6, 7, 8 represents an unoccupied position. An X represents
    /// a move made by player 1. An O represents a move made by player 2.
    /// </summary> 
    public char[] Board;

    /// <summary>
    /// Represents the which player is currently making a move
    /// </summary>
    public int CurrentPlayer;

    /// <summary>
    /// Initializes the Board to contain the positions 0, 1, 2, 3, 4, 5, 6, 7, and 8.
    /// Initializes the CurrentPlayer to 1.
    /// </summary>
    public TicTacToe()
    {
        // TODO: Initialize Board to contain the digits '0' to '8'
        // TODO: Initialize CurrentPlayer to be 1
    } 

    /// <summary>
    /// Displays the TicTacToe board in the console:
    /// For example, an empty board would look like this:

    /// 0 | 1 | 2
    /// --|---|--
    /// 3 | 4 | 5
    /// --|---|--
    /// 6 | 7 | 8

    ///  If player 1 moves in position 4, the board would then look like this:

    ///  0 | 1 | 2
    ///  --|---|--
    ///  3 | X | 5
    ///  --|---|--
    ///  6 | 7 | 8

    ///  If player 2 moves in position 0, the board would then look like this:

    ///  O | 1 | 2
    ///  --|---|--
    ///  3 | X | 5
    ///  --|---|--
    ///  6 | 7 | 8
    /// </summary>
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

    /// <summary>
    /// Returns true if the current game is a draw. A game is a draw if
    /// CheckWin() is false and no more moves can be made.
    /// </summary>
    public bool CheckDraw()
    {
        // TODO: Implement check draw
        return false;
    }

    /// <summary>
    /// Switches the current player.
    /// </summary>
    public void SwitchPlayer()
    {
        // TODO: Implement switch player
    }
}