using Shouldly;

namespace Tests;

public class WordFilterTest
{
    [Fact]
    public void words_of_length_3_should_returns_words_of_length_3()
    {
        string[] words = [ "cat", "dog", "sun", "computer", "keyboard", "mouse", "code", "cup", "tea", "bag" ];
        List<string> filtered = WordFilter.WordsOfLength(words, 3);
        filtered.Count.ShouldBe(6);
        filtered.ShouldContain("cat");
        filtered.ShouldContain("dog");
        filtered.ShouldContain("sun");
        filtered.ShouldContain("cup");
        filtered.ShouldContain("tea");
        filtered.ShouldContain("bag");
    }

    [Fact]
    public void words_of_length_6_should_returns_words_of_length_6()
    {
        string[] words = [ 
        "cat", "dog", "sun", 
         "catdog", "dogcat", "cathat", "chatme", 
         "cup", "tea", "bag" ];
        List<string> filtered = WordFilter.WordsOfLength(words, 6);
        filtered.Count.ShouldBe(4);
        filtered.ShouldContain("catdog");
        filtered.ShouldContain("dogcat");
        filtered.ShouldContain("cathat");
        filtered.ShouldContain("chatme");
    }

    [Fact]
    public void unique_words_of_length_3_should_return_words_of_length_3()
    {
        string[] words = [ 
        "cat", "cat", "cat", 
         "dog", "dog", "dog", 
         "computer", "human" ];
        List<string> filtered = WordFilter.UniqueWordsOfLength(words, 3);
        filtered.Count.ShouldBe(2);
        filtered.ShouldContain("cat");
        filtered.ShouldContain("dog");
    }
}