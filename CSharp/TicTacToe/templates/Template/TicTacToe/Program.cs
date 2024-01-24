// See https://aka.ms/new-console-template for more information


TicTacToe game = new ();

// While the game has not been one and the game is not a draw
while(!game.CheckWin() && !game.CheckDraw())
{
    Console.Clear();
    Console.WriteLine("TicTacToe\n");
    Console.WriteLine(game.Stringify());

    char currentSymbol = 'X';
    if (game.CurrentPlayer == 2)
    {
        currentSymbol = 'O';
    }

    Console.WriteLine($"It is {currentSymbol}'s turn.");
    int position = GetPosition();

    if (!game.MakeMove(position))
    {
        // If the move is not valid, display an error message.
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid move! Press enter to continue.");
        Console.ResetColor();
        Console.ReadLine();
    }
    else if (game.CheckWin())
    {
        // If the game has been won, display a win message
        Console.WriteLine($"{currentSymbol} Wins!");
        Console.WriteLine(game.Stringify());
    }
    else if (game.CheckDraw())
    {
        // If the game is a draw, display a draw message
        Console.WriteLine($"The game is a draw!");
        Console.WriteLine(game.Stringify());
    }
    else
    {
        // Switch players
        game.SwitchPlayer();
    }
}

int GetPosition()
{
    Console.Write("Where go? ");
    if(int.TryParse(Console.ReadLine(), out int position))
    {
        return position;
    }
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Invalid move!");    
    Console.ResetColor();
    return GetPosition();
}
