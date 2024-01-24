public class TicTacToe
{
    public char[] Board;
    public int CurrentPlayer;

    /// <summary>
    /// Initializes the Board to contain the positions 0, 1, 2, 3, 4, 5, 6, 7, and 8.
    /// Initializes the CurrentPlayer to 1.
    /// </summary>
    public TicTacToe()
    {
        Board = new char[]{'0', '1', '2', '3', '4', '5', '6', '7', '8'};
        CurrentPlayer = 1;
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
        if (position < 0 || position > 8) { return false; }
        if (Board[position] == 'X' || Board[position] == 'O') { return false; }
        Board[position] = CurrentPlayer == 1 ? 'X' : 'O';
        return true;
    }

    /// <summary>
    /// Returns true if the current player has won the game and false otherwise.
    /// Hint: You may find it helpful to write several smaller methods:
    /// CheckTopRow, CheckMidRow, CheckBottomRow, CheckLeftCol, CheckMidCol,
    /// CheckRightCol, CheckDiagOne, CheckDiagTwo
    /// </summary>
    public bool CheckWin()
    {
        char symbol = CurrentPlayer == 1 ? 'X' : 'O';
        return HasWon(symbol);
    }

    public bool HasWon(char symbol)
    {
        return CheckTopRow(symbol) || 
               CheckMidRow(symbol) || 
               CheckBottomRow(symbol) || 
               CheckLeftCol(symbol) || 
               CheckMidCol(symbol) || 
               CheckRightCol(symbol) ||
               CheckDiagOne(symbol) ||
               CheckDiagTwo(symbol);
    }
    private bool CheckTopRow(char symbol) =>    CheckMatch(symbol, 0, 1, 2);
    private bool CheckMidRow(char symbol) =>    CheckMatch(symbol, 3, 4, 5);
    private bool CheckBottomRow(char symbol) => CheckMatch(symbol, 6, 7, 8);
    private bool CheckLeftCol(char symbol) => CheckMatch(symbol, 0, 3, 6);
    private bool CheckMidCol(char symbol) => CheckMatch(symbol, 1, 4, 7);
    private bool CheckRightCol(char symbol) => CheckMatch(symbol, 2, 5, 8);
    private bool CheckDiagOne(char symbol) => CheckMatch(symbol, 0, 4, 8);
    private bool CheckDiagTwo(char symbol) => CheckMatch(symbol, 2, 4, 6);

    private bool CheckMatch(char symbol, int ix0, int ix1, int ix2)
    {
        return Board[ix0] == Board[ix1] && Board[ix1] == Board[ix2] && Board[ix2] == symbol;
    }

    /// <summary>
    /// Returns true if the current game is a draw. A game is a draw if
    /// CheckWin() is false and no more moves can be made.
    /// </summary>
    public bool CheckDraw()
    {
        if (CheckWin()) { return false; }
        foreach(char ch in Board)
        {
            if (ch != 'X' && ch != 'O') { return false; }
        }
        return true;
    }

    /// <summary>
    /// Switches the current player.
    /// </summary>
    public void SwitchPlayer()
    {
        CurrentPlayer = CurrentPlayer == 1 ? 2 : 1;
    }
}