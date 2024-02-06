public class SimpleMenu
{
    public string Prompt;
    public string[] Items;

    public SimpleMenu(string prompt, string[] items)
    {
        Prompt = prompt;
        Items = items;
    }

    public string GetChoice()
    {
        Console.WriteLine(Prompt);
        int ix = 1;
        foreach (string item in Items)
        {
            Console.WriteLine($"{ix}. {item}");
            ix++;
        }
        
        Console.Write($"Choose: ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= Items.Length)
        {
            return Items[choice - 1];
        }
        Console.WriteLine("Invalid choice!");
        return GetChoice();
    }
}