// Example:

// Loads all names from the lists/human-names.txt file into an
// array called names
// string[] names = File.ReadAllLines("lists/human-names.txt");

// Randomly generates an index within the names array
// int randomIx = Random.Shared.Next(names.Length);

// Retrieves the name at the specified index
// string randomName = names[randomIx];

// Displays the name to the terminal
// Console.WriteLine(randomName);

// TODO:

// 1. Complete the Person class (Person.cs)
// 2. Complete the PersonGenerator class (PersonGenerator.cs)
// Then...

// Write a program that:
// 1. Prompt the user if they want a normal or fantasy name
// 2. Prompts the user if they would like to generate a villain
// 3. Generates 10 random names and displays them using the FullInfo() method
// 4. Asks the user if they would like to generate more names
// 5. If yes, go to 3. Otherwise, the program exits
string[] names2 = ["Bob", "Brenda", "Billy"];
string[] adjectives2 = ["Smart", "Funny"];
string[] professions2 = ["Walrus", "Clown", "Juggler", "Teacher"];
PersonGenerator generator2 = new PersonGenerator(names2, adjectives2, professions2);
Person person2 = generator2.Generate();
Console.WriteLine(person2.FullInfo());
Environment.Exit(0);

Console.Clear();
Console.WriteLine("Welcome to Name Generator!");
string nameFile = "lists/human-names.txt";
string adjectiveFile = "lists/nice-adjectives.txt";
string professionFile = "lists/professions.txt";

Console.WriteLine("Select s Generator Style:");
string choice = GetChoice(["Normal", "Fantasy"]);
if (choice == "Fantasy")
{
    nameFile = "lists/fantasy-names.txt";
    professionFile = "lists/fantasy-jobs.txt";
}

Console.WriteLine("Select an Adjective Type:");
choice = GetChoice(["Normal", "Villain"]);
if (choice == "Villain")
{
    adjectiveFile = "lists/villain-adjectives.txt";
}

string[] names = File.ReadAllLines(nameFile);
string[] adjectives = File.ReadAllLines(adjectiveFile);
string[] professions = File.ReadAllLines(professionFile);

PersonGenerator generator = new PersonGenerator(names, adjectives, professions);

do
{
    Console.WriteLine("10 random people: ");
    for (int count = 0; count < 10; count++)
    {
        Person person = generator.Generate();
        Console.WriteLine(person.FullInfo());
    }
    Console.WriteLine("Generate More?");
    choice = GetChoice(["More", "Finished"]);
} while (choice == "More");



string GetChoice(string[] options)
{
    for (int i = 0; i < options.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {options[i]}");
    }
    if (int.TryParse(Console.ReadLine()!, out int choice) && choice >= 1 && choice <= options.Length)
    {
        return options[choice-1];
    }
    else
    {
        Console.WriteLine("Not a valid choice.");
        return GetChoice(options);
    }
}