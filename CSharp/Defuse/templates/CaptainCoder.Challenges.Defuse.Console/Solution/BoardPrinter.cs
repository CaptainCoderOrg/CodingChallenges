/// <summary>
/// A BoardPrinter is capable of printing a Defuse board to the terminal
/// </summary>
public class BoardPrinter
{
    private readonly Dictionary<char, ConsoleColor> _colors = new();
    private readonly ConsoleColor _default = Console.ForegroundColor;

    /// <summary>
    /// Given a Board, GuessChecker, and position to print the board, displays the board in the terminal
    /// using this BoardPrinters colors
    /// </summary>
    public void PrintBoard(Board board, GuessChecker checker, int left, int top)
    {
        PrintGuesses(board, checker, left, top);
        PrintBorder(board.Code.Length*2 + 1, board.MaxGuesses + 2, top, left);
        Console.WriteLine();
        Console.Write("Options: ");
        foreach (char ch in board.Options)
        {
            Console.ForegroundColor = Color(ch);
            Console.Write($"{ch} ");
        }
        Console.ResetColor();
        Console.WriteLine();
    }

    /// <summary>
    /// Sets the color to be used for a specific character
    /// </summary>
    public void SetColor(char ch, ConsoleColor color) => _colors[ch] = color;

    /// <summary>
    /// Returns the color that is associated with the specified character
    /// </summary>
    public ConsoleColor Color(char ch) => _colors.GetValueOrDefault(ch, _default);

    private void PrintBorder(int width, int height, int left, int top)
    {
        PrintHorizontalLine(width, left, top);
        PrintVerticalLine(height-2, left, top + 1);
        PrintVerticalLine(height-2, left + width + 1, top + 1);
        PrintHorizontalLine(width, left, top + height - 1);
    }

    private void PrintGuesses(Board board, GuessChecker checker, int left, int top)
    {
        for (int row = 0; row < board.MaxGuesses; row++)
        {
            Console.SetCursorPosition(left + 2, top + board.MaxGuesses - row);
            if (board.History.Count <= row) 
            { 
                Console.Write(string.Join(" ", Enumerable.Repeat(".", board.Code.Length)));
            }
            else
            {
                
                foreach (char ch in board.History[row])
                {
                    Console.ForegroundColor = Color(ch);
                    Console.Write($"{ch} ");
                }

                
                Console.SetCursorPosition(left + 4 + 2 * board.Code.Length + 1, top + board.MaxGuesses - row);
                int correct = checker.Correct(board.Code, board.History[row]);
                for (int count = 0; count < correct; count++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("* ");
                }

                int match = checker.CorrectSymbols(board.Code, board.History[row]);
                for (int count = 0; count < match; count++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("* ");
                }
            }
            Console.ResetColor();
        }
    }

    private void PrintHorizontalLine(int width, int left, int top)
    {
        Console.SetCursorPosition(left, top);
        Console.Write("+");
        Console.Write(new string([..Enumerable.Repeat<char>('-', width)]));
        Console.Write("+");
    }

    private void PrintVerticalLine(int height, int left, int top)
    {
        for (int count = 0; count < height; count++)
        {
            Console.SetCursorPosition(left, top + count);
            Console.Write("|");
        }
    }    
}