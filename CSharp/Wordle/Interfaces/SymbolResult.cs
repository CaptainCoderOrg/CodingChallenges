public class SymbolResult
{
    public char Symbol { get; }
    public bool IsInWord { get; }
    public bool IsCorrect { get; }

    public SymbolResult(char symbol, bool isCorrect, bool isInWord)
    {
        Symbol = symbol;
        IsCorrect = isCorrect;
        IsInWord = isInWord;
    }
}