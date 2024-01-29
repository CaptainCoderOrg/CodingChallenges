// TODO:
// Create a Person class that has 3 properties:
// Name, Adjective, and Profession
//
// The constructor should accept 3 matching properties and initialize
// the properties
// 
// Add a method "Title()" which returns a string: "{Adjective} {Profession}"
// Add a method "FullInfo()" which returns a string: "{Name} the {Adjective} {Profession}"

public class Person
{
    public string Name;
    public string Adjective;
    public string Profession;

    public Person(string name, string adjective, string profession)
    {
        Name = name;
        Adjective = adjective;
        Profession = profession;
    }

    public string Title() => $"{Adjective} {Profession}";
    public string FullInfo() => $"{Name} the {Adjective} {Profession}";
}