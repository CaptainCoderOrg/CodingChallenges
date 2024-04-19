// Clears the terminal
Console.Clear();

// Console.WriteLine displays text to the console
Console.WriteLine("Welcome to Mad Takes!");
Console.WriteLine("Press enter to start!");

// Console.ReadLine pauses the program and waits for the user to type something
// and press enter
Console.ReadLine();

// Console.Write displays text but keeps the cursor on the same line.
Console.Write("Enter an ");

// You can change the color of the text using Console.ForegroundColor
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("ADJECTIVE");

// You can rest to the default color using the Console.ResetColor() method.
Console.ResetColor();
Console.Write(": ");

// You can save the user's input using a variable.
string adjective = Console.ReadLine()!;


Console.Write("Enter a ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("NOUN");
Console.ResetColor();
Console.Write(": ");
string noun = Console.ReadLine()!;

Console.Write("Enter a ");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write("NOISE");
Console.ResetColor();
Console.Write(": ");
string noise = Console.ReadLine()!;

Console.Write("Enter an ");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("ANIMAL");
Console.ResetColor();
Console.Write(": ");
string animal = Console.ReadLine()!;

Console.WriteLine("Ready? Press enter to continue.");
Console.ReadLine();

// adjective MacDonald had a noun, E-I-E-I-O
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(adjective);
Console.ResetColor();
Console.Write(" Macdonald had a ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(noun);
Console.ResetColor();
Console.WriteLine(", E-I-E-I-O");

// and on that noun  he had an animal, E-I-E-I-O
Console.Write("and on that ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(noun);
Console.ResetColor();
Console.Write(" he had an ");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(animal);
Console.ResetColor();
Console.WriteLine(", E-I-E-I-O");

// with a noise noise here
Console.Write("with a ");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write($"{noise} {noise}");
Console.ResetColor();
Console.WriteLine(" here");

// and a noise noise there
Console.Write("and a ");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write($"{noise} {noise}");
Console.ResetColor();
Console.WriteLine(" there");

// here a noise, there a noise,
Console.Write("here a ");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write(noise);
Console.ResetColor();
Console.Write(", there a ");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write(noise);
Console.ResetColor();
Console.WriteLine(",");

// everywhere a noise noise,
Console.Write("everywhere a ");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write($"{noise} {noise}");
Console.ResetColor();
Console.WriteLine(",");

// adjective Macdonald had a noun, E-I-E-I-O
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(adjective);
Console.ResetColor();
Console.Write(" Macdonald had a ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(noun);
Console.ResetColor();
Console.WriteLine(", E-I-E-I-O");