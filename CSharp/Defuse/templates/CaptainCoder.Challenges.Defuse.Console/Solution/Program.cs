// Set DEBUG to true to display the correct code while playing.
bool DEBUG = false;

Console.Clear();
CheckTerminalSize();
Console.WriteLine("Welcome to Defuse!");
string difficulty = ShowMenu("Select Difficulty", ["Easy", "Normal", "Hard"]);

BoardPrinter printer = InitializePrinter();
Board board = InitializeBoard(difficulty);
GuessChecker checker = new GuessChecker();
do
{
    Play();
} while(PlayAgain());


void Play()
{
    bool won = false;
    while (won is false && board.GuessesRemaining > 0)
    {
        Console.Clear();
        printer.PrintBoard(board, checker, 0, 0);
        Console.WriteLine();
        if (DEBUG) { Console.WriteLine($"Code: {string.Join("", board.Code)}"); }
        char[] guess = GetGuess(board.Options, []);
        won = board.Guess(guess);
    }

    Console.Clear();
    printer.PrintBoard(board, checker, 0, 0);

    if (won)
    {
        Console.WriteLine("Congratulations you guessed the code!");
    }
    else
    {
        Console.Write("You were unable to defuse the bomb. The code was: ");
        foreach (char ch in board.Code)
        {
            Console.ForegroundColor = printer.Color(ch);
            Console.Write($"{ch} ");
        }
        Console.ResetColor();
        Console.WriteLine();
    }
}

bool PlayAgain()
{
    string response = ShowMenu("Would you like to play again?", ["Easy", "Normal", "Hard", "Quit"]);
    if (response == "Quit")
    {
        return false;
    }
    board = InitializeBoard(response);
    return true;
}

char[] GetGuess(char[] options, List<char> guess)
{
    Console.CursorLeft = 0;
    Console.Write("Enter Guess: ");
    foreach (char ch in guess)
    {
        Console.ForegroundColor = printer.Color(ch);
        Console.Write($"{ch} ");
    }
    Console.Write("   ");
    Console.CursorLeft -= 3;
    Console.ResetColor();
    ConsoleKeyInfo key = Console.ReadKey();
    if (key.Key == ConsoleKey.Backspace && guess.Count > 0) { guess.RemoveAt(guess.Count - 1); }
    else if (key.Key == ConsoleKey.Enter && guess.Count == board.Code.Length)
    {
        return [.. guess];
    }
    char input = char.ToUpper(key.KeyChar);
    if (options.Contains(input) && guess.Count < board.Code.Length)
    {
        guess.Add(input);
    }
    return GetGuess(options, guess);
}


string ShowMenu(string prompt, string[] options)
{
    int choice = 1;
    foreach (string option in options)
    {
        Console.WriteLine($"{choice}. {option}");
        choice++;
    }
    Console.Write($"{prompt}: ");
    string input = Console.ReadLine()!;
    if (int.TryParse(input, out int ix) && ix >= 1 && ix - 1 < options.Length)
    {
        return options[ix - 1];
    }
    Console.WriteLine("Invalid choice.");
    return ShowMenu(prompt, options);
}

BoardPrinter InitializePrinter()
{
    BoardPrinter printer = new();
    printer.SetColor('A', ConsoleColor.Red);
    printer.SetColor('B', ConsoleColor.Green);
    printer.SetColor('C', ConsoleColor.Blue);
    printer.SetColor('D', ConsoleColor.Yellow);
    printer.SetColor('E', ConsoleColor.Magenta);
    printer.SetColor('F', ConsoleColor.DarkGray);
    printer.SetColor('G', ConsoleColor.Cyan);
    printer.SetColor('H', ConsoleColor.White);
    return printer;
}

Board InitializeBoard(string difficulty)
{
    char[] options = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H'];
    int length = 4;
    int maxGuesses = 10;

    if (difficulty == "Easy")
    {
        options = ['A', 'B', 'C', 'D', 'E', 'F'];
        length = 3;
        maxGuesses = 12;
    }

    if (difficulty == "Hard")
    {
        options = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H'];
        length = 6;
    }

    char[] code = Board.GeneratePassword(length, options);

    return new Board(code, maxGuesses, options);
}

void CheckTerminalSize()
{
    while (Console.WindowHeight < 20) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Your terminal is not tall enough.");
        Console.WriteLine("Ctrl + C to exit");
        Console.WriteLine("Press enter to try again.");
        Console.ReadLine();
    }
    Console.ResetColor();
    Console.Clear();
}