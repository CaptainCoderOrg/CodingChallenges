// This example demonstrates how to use Console.ReadKey() 
// to read and respond to a single key press

Console.Clear();
while(true)
{
    Console.WriteLine("Press any key to display information");
    Console.WriteLine("Press Escape to Exit");
    Console.WriteLine("Press Tab to show a special message");
    // Use Console.ReadKey() to read a key from the keyboard
    // It returns a ConsoleKeyInfo type which contains information
    // about the keypress
    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
    
    // If you want to show the key as it is typed,
    // you can use Console.ReadKey(false);

    // You can use the `Key` property of the result to access
    // the ConsoleKey enumerated type which can be used to make
    // decisions
    ConsoleKey key = keyInfo.Key;
    Console.WriteLine($"You pressed: {key}");

    if (key is ConsoleKey.Escape)
    {
        break; // Break exits the loop
    }

    if (key is ConsoleKey.Tab)
    {
        Console.WriteLine("You are special!");
    }
}
