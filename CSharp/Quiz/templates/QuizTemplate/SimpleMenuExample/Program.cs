// See https://aka.ms/new-console-template for more information

int currentChoice = 0;
string[] options = ["Banana", "Apple", "Orange"];
ConsoleKey key;

do 
{
    Console.Clear();
    Console.WriteLine("Which fruit is best?\n");
    
    // Loop through the options and display them
    for (int ix = 0; ix < options.Length; ix++)
    {
        // If the current choice is the option we are displaying
        // change the color
        if (currentChoice == ix)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        Console.WriteLine($"{options[ix]}");
        // Be sure to reset the color
        Console.ResetColor();
    }

    // Display instructions
    Console.WriteLine("\nPress Tab to cycle through options. Press Enter to Select.");
    
    // Read key info
    ConsoleKeyInfo info = Console.ReadKey(true);
    key = info.Key;
    
    // If tab, cycle to next choice
    if (key is ConsoleKey.Tab)
    {
        currentChoice = currentChoice + 1;

        // If choice is too high, go back to 0
        if (currentChoice > 2)
        {
            currentChoice = 0;
        }
    }
} while (key is not ConsoleKey.Enter);

// Display the users choice
Console.WriteLine($"\nYou chose {options[currentChoice]}");
