namespace TextAnalysisService;

public class TextAnalyzer : ITextAnalyzer
{
    public int CountWords(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return 0;

        return text
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Length;
    }

    public int CountCharacters(string text)
    {
        if (text is null)
            return 0;

        return text.Length;
    }
}
