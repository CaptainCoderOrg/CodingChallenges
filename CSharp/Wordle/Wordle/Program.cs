// Set DEBUG to true to see the randomly selected word while playing
bool DEBUG = false;
string[] words = File.ReadAllLines("words.txt");
GuessChecker checker = new GuessChecker();
ResultWriter writer = new ResultWriter();

do
{
    Play(checker, writer);
} while (PlayAgain());

void Play(IGuessChecker checker, IResultWriter writer)
{
    Console.Clear();
    Console.WriteLine("Can you guess the 5 letter word?");
    string word = words[Random.Shared.Next(0, words.Length)].ToUpper().Trim();
    int guesses = 6;
    bool isWon = false;
    if (DEBUG)
    {
        Console.WriteLine($"The correct word is: {word}");
    }

    do
    {
        Console.WriteLine($"Guesses remaining: {guesses}");
        Console.Write("Guess: ");
        string guess = Console.ReadLine()!.ToUpper();

        if (guess.Length != word.Length)
        {
            Console.WriteLine("Invalid word.");
            continue;
        }

        SymbolResult[] results = checker.CheckGuess(word, guess);
        writer.Write(results);

        isWon = guess == word;
        guesses--;

    } while (guesses > 0 && isWon == false);

    if (isWon)
    {
        Console.WriteLine("You won!");
    }
    else
    {
        Console.WriteLine($"Oh no! The word was: {word}");
    }
}

bool PlayAgain()
{
    Console.WriteLine();
    Console.WriteLine("1. Play again");
    Console.WriteLine("2. Quit");
    Console.Write("Make a choice: ");
    string choice = Console.ReadLine()!;
    if (choice == "1") { return true; }
    if (choice == "2") { return false; }
    Console.WriteLine("Invalid choice.");
    return PlayAgain();
}
