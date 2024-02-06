public class ArrowKeyMenu
{
    public string Prompt;
    public string[] Items;

    public ArrowKeyMenu(string prompt, string[] items)
    {
        Prompt = prompt;
        Items = items;
    }

    public string GetChoice()
    {
        int choice = 0;
        while (true)
        {
            Console.Clear();
            Console.WriteLine(Prompt);
            Console.WriteLine();

            int ix = 0;

            foreach (string item in Items)
            {
                if (ix == choice)
                {
                    Console.WriteLine($" > {item}");
                }
                else
                {
                    Console.WriteLine($"   {item}");
                }
                ix++;
            }
            
            Console.WriteLine("\n↑ ↓ - Choose | Enter - Select");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key is ConsoleKey.Enter)
            {
                return Items[choice];
            }
            if (key.Key is ConsoleKey.UpArrow)
            {
                choice--;
            }
            if (key.Key is ConsoleKey.DownArrow)
            {
                choice++;
            }
            choice = Math.Clamp(choice, 0, Items.Length - 1);
        }
    }
}