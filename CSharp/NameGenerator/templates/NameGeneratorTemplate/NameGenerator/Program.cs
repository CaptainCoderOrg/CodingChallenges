// Example:

// Loads all names from the lists/human-names.txt file into an
// array called names
string[] names = File.ReadAllLines("lists/human-names.txt");

// Randomly generates an index within the names array
int randomIx = Random.Shared.Next(names.Length);

// Retrieves the name at the specified index
string randomName = names[randomIx];

// Displays the name to the terminal
Console.WriteLine(randomName);

// TODO:

// 1. Complete the Person class (Person.cs)
// 2. Complete the PersonGenerator class (PersonGenerator.cs)
// Then...

// Write a program that:
// 1. Prompt the user if they want a human or fantasy name
// 2. Prompts the user if they would like to generate a villain
// 3. Generates 10 random names and displays them using the FullInfo() method
// 4. Asks the user if they would like to generate more names
// 5. If yes, go to 3. Otherwise, the program exits