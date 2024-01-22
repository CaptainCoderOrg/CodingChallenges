// Set DEBUG to true to see the randomly selected word while playing
bool DEBUG = false;

IGuessChecker checker = new GuessChecker();
IGuessWriter writer = new GuessWriter();

// TODO: 1st: Complete GuessWriter.cs
writer = new GuessWriterSolution(); // TODO: Comment this line to use your solution

// TODO: 2nd: Complete GuessChecker.cs 
checker = new GuessCheckerSolution(); // TODO: Comment this line to use your solution

string[] words = LoadWords();

do
{
    Play();
} while (PlayAgain());

void Play()
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
        Console.Write($"Guesses remaining: {guesses} | Guess: ");
        string guess = Console.ReadLine()!.ToUpper();

        if (!words.Contains(guess))
        {
            Console.WriteLine("Invalid word.");
            continue;
        }

        writer.Write(word, guess, checker);

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

string[] LoadWords() => File.ReadAllLines("words.txt").Select(word => word.Trim().ToUpper()).ToArray();