Quiz mathQuiz = new Quiz(
    [
        new Question(new ("2 + 7", ["9", "3", "5", "27"]), "9"),
        new Question(new ("8 x 8", ["16", "32", "88", "64"]), "64"),
        new Question(new ("14 ÷ 2", ["12", "7", "142", "8"]), "7"),
        new Question(new ("Solve for X: 3X - 7 = 11", ["3", "5", "6", "9"]), "6"),
        new Question(new ("Solve for Y: 4Y + 8 = 20", ["3", "5", "6", "9"]), "3"),
    ]
);

Quiz historyQuiz = new Quiz(
    [
        new Question(new ("Who was the first President of the United States?", ["Thomas Jefferson", "George Washington", "Abraham Lincoln"]), "George Washington"),
        new Question(new ("What ancient civilization is known for building pyramids?", ["The Romans", "The Greeks", "The Egyptians"]), "The Egyptians"),
        new Question(new ("During which period did the Renaissance primarily occur?", ["14th to 17th century", "11th to 14th century", "17th to 19th century"]), "14th to 17th century"),
        new Question(new ("Who wrote the Declaration of Independence?", ["Benjamin Franklin", "John Adams", "Thomas Jefferson"]), "Thomas Jefferson"),
        new Question(new ("What was the main cause of World War I?", ["The fall of the Berlin Wall", "Assassination of Archduke Franz Ferdinand", "The invasion of Poland"]), "Assassination of Archduke Franz Ferdinand"),
    ]
);

Quiz geographyQuiz = new Quiz(
    [
        new Question(new ("The Amazon River is the longest river in the world.", ["True", "False"]), "False"),
        new Question(new ("Mount Everest is located in Nepal.", ["True", "False"]), "True"),
        new Question(new ("Australia is the largest island in the world.", ["True", "False"]), "False"),
        new Question(new ("The Sahara Desert is the largest hot desert in the world.", ["True", "False"]), "True"),
        new Question(new ("Tokyo is the capital of South Korea.", ["True", "False"]), "False"),
    ]
);

Quiz scienceQuiz = new Quiz(
    [
        new Question(new ("What is the most abundant gas in the Earth's atmosphere?", ["Oxygen", "Nitrogen", "Carbon Dioxide", "Argon"]), "Nitrogen"),
        new Question(new ("What is the chemical symbol for gold?", ["Au", "Ag", "Ga", "Ge"]), "Au"),
        new Question(new ("Which planet is known as the Red Planet?", ["Venus", "Mars", "Jupiter", "Saturn"]), "Mars"),
        new Question(new ("What force pulls objects toward the center of the Earth?", ["Magnetic force", "Gravitational force", "Centrifugal force", "Electrostatic force"]), "Gravitational force"),
        new Question(new ("What is the process by which plants make their food using sunlight called?", ["Photosynthesis", "Respiration", "Fermentation", "Phototropism"]), "Photosynthesis"),
    ]
);

string choice;
do
{
    Console.Clear();
    ArrowKeyMenu menu = new("Select a Quiz", ["Math", "History", "Geography", "Science"]);
    choice = menu.GetChoice();
    Quiz quiz = choice switch
    {
        "Math" => mathQuiz,
        "History" => historyQuiz,
        "Geography" => geographyQuiz,
        "Science" => scienceQuiz,
        _ => throw new Exception($"Invalid choice: {choice}."),
    };

    int correct = 0;
    foreach (Question question in quiz.Questions)
    {
        Console.Clear();
        if (question.AskQuestion())
        {
            correct++;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct!");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Incorrect :(");
            Console.ResetColor();
        }
        
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
    }

    Console.WriteLine($"You scored: {((double)correct / quiz.Questions.Length)*100:#.##}%");
    Console.WriteLine("Press enter to continue");
    Console.ReadLine();

    ArrowKeyMenu again = new("Would you like to take another quiz?", ["Yes", "No"]);
    choice = menu.GetChoice();
} while (choice == "Yes");

Console.WriteLine("Have a beautiful day!");