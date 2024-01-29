# Name Generator

In this challenge, you will be tasked with creating a class that can generate
names from files containing components of that name.

## Run the Example

Start by running the example: `dotnet Example/NameGenerator.dll`

## Run Your Solution

You should run your solution from the root of the project using `dotnet run
--project NameGenerator`. Initially, this will display a single random name in
the console.

## The Lists Files

In the `lists` directory are several files that contain names, adjectives, and
professions. You will use these to generate the components of each name.

## How to Read a File and Randomly generate an item:

The following code is at the beginning of your Program.cs file. It demonstrates
how to read a text file into an array of strings. You can use this array to
randomly select an item from that array and display it in the console.

```csharp
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
```

## Tasks


### Person Class

Start by creating a `Person` class in the `Person.cs` file.

A Person has 3 properties: Name, Adjective, and Profession.

A Person has two methods:

```csharp
// Returns the adjective and profession of the person
public string Title();

// Returns a string with the format "Name the Adjective Profession" for example
// Bob the Brilliant Barbarian
public string FullInfo();
```

When you're finished, you can test your solution with the following code snippet:

```csharp
Person bob = new Person("Bob", "Brilliant", "Barbarian");
Console.WriteLine(bob.FullInfo());
// Should output: Bob the Brilliant Barbarian
```

### PersonGenerator Class

A PersonGenerator class is used to randomly generate a Person class. It has 3 properties:

* string[] Names, string[] Adjectives, and string[] Professions

Each of these contains the possible names, adjectives and professions that can be used.

A PersonGenerator has one method:

```csharp
// Generates a person initializing their Name, Adjective, and Profession randomly
// using the options present in this generator.
public Person Generate();
```

You can use the following code snippet as a test to check if you have implemented the class properly:


```csharp
string[] names = ["Bob", "Brenda", "Billy"];
string[] adjectives = ["Smart", "Funny"];
string[] professions = ["Walrus", "Clown", "Juggler", "Teacher"];
PersonGenerator generator = new PersonGenerator(names, adjectives, professions);
Person person = generator.Generate();
Console.WriteLine(person.FullInfo());
```

Each time you run the above code, you should get a randomly generate person.

### Interactive Program

The final task is to create an interactive program that allows a user to generate names using different lists.

Write a program that:

1. Prompt the user if they want a human or fantasy name
   * `human-names.txt` / `fantasy-names.txt`
   * `professions.txt` / `fantasy-jobs.txt` 
2. Prompts the user if they would like to generate a villain
   * `nice-adjectives.txt` /  `villian-adjectives.txt`
3. Generates 10 random names and displays them using the FullInfo() method 
4. Asks the user if they would like to generate more names
5. If yes, go to 3. Otherwise, the program exits