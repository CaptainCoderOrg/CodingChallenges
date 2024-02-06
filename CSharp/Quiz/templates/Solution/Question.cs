public class Question
{
    public ArrowKeyMenu Menu;
    public string CorrectAnswer;

    public Question(ArrowKeyMenu menu, string correctAnswer)
    {
        Menu = menu;
        CorrectAnswer = correctAnswer;
    }

    public bool AskQuestion()
    {
        string result = Menu.GetChoice();
        return result == CorrectAnswer;
    }
}