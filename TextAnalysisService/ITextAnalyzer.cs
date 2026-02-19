namespace TextAnalysisService;

public interface ITextAnalyzer
{
    int CountWords(string? text);
    int CountCharacters(string? text);
}

