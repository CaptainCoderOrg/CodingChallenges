// TODO: 
//
//Complete the Person class before attempting this class.

// Create a PersonGenerator class that has 3 member variables: string[] Names,
// Adjectives, Professions
//
// The constructor should accept 3 parameters and initialize the member
// variables
//
// Write a method Generate() which returns a Person that is constructed
// using randomly selected values from the Names, Adjectives, and Professions 
// arrays.
public class PersonGenerator
{
    public string[] Names;
    public string[] Adjectives;
    public string[] Professions;

    public PersonGenerator(string[] names, string[] adjectives, string[] professions)
    {
        Names = names;
        Adjectives = adjectives;
        Professions = professions;
    }

    public Person Generate()
    {
        string name = Names[Random.Shared.Next(Names.Length)];
        string adjective = Adjectives[Random.Shared.Next(Adjectives.Length)];
        string profession = Professions[Random.Shared.Next(Professions.Length)];
        return new Person(name, adjective, profession);
    }
}