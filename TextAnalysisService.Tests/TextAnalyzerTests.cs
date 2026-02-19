using TextAnalysisService;

namespace TextAnalysisService.Tests;

public class TextAnalyzerTests
{
    private readonly TextAnalyzer _analyzer = new();

    [Fact]
    public void CountWords_ReturnsZero_WhenTextIsNullOrEmpty()
    {
        Assert.Equal(0, _analyzer.CountWords(null));
        Assert.Equal(0, _analyzer.CountWords(""));
        Assert.Equal(0, _analyzer.CountWords("   "));
    }

    [Fact]
    public void CountWords_ReturnsCorrectCount()
    {
        var result = _analyzer.CountWords("Hello world from tests");
        Assert.Equal(4, result);
    }

    [Fact]
    public void CountCharacters_ReturnsZero_WhenNull()
    {
        Assert.Equal(0, _analyzer.CountCharacters(null));
    }

    [Fact]
    public void CountCharacters_ReturnsCorrectCount()
    {
        var result = _analyzer.CountCharacters("Hello");
        Assert.Equal(5, result);
    }
}
