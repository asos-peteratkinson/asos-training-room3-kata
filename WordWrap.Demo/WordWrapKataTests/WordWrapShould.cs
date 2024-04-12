using FluentAssertions;
using NUnit.Framework;
using WordWrapKata;

namespace WordWrapKataTests;

public class WordWrapShould
{
    [Test]
    public void ReturnEmpty_WhenNull()
    {
        var result = WordWrap.Wrap(null, 10);

        result.Should().BeEmpty();
    }

    [Test]
    public void ReturnEmpty_WhenEmptyString()
    {
        var result = WordWrap.Wrap("", 10);

        result.Should().BeEmpty();
    }

    [Test]
    public void ReturnSameWord_WhenShortWord()
    {
        var result = WordWrap.Wrap("Word", 10);

        result.Should().Be("Word");
    }
    
    [TestCase("longword", 4, "long\nword")]
    [TestCase("longerword", 6, "longer\nword")]
    [TestCase("verylongword", 4, "very\nlong\nword")]
    public void ReturnWrappedWord_WhenWordIsLongerThanTheLimit(string input, int limit, string expected)
    {
        var result = WordWrap.Wrap(input, limit);

        result.Should().Be(expected);
    }

    [Test]
    public void ReturnWrappedWord_WhenTwoWordsLongerThanLimit()
    {
        var result = WordWrap.Wrap("word word", 6);

        result.Should().Be("word\nword");
    }
    
    [Test]
    public void ReturnWrappedWord_WhenTwoDifferentWordsLongerThanLimit()
    {
        var result = WordWrap.Wrap("word here", 6);

        result.Should().Be("word\nhere");
    }

    [Test]
    public void ReturnWrappedWord_WhenThreeWordsLongerThanLength()
    {
        var result = WordWrap.Wrap("word word word", 6);

        result.Should().Be("word\nword\nword");
    }
    
    [Test]
    public void ReturnWrappedWord_AtLastSpace_WhenThreeWordsLongerThanLength()
    {
        var result = WordWrap.Wrap("word word word", 11);

        result.Should().Be("word word\nword");
    }

    [Test]
    public void ReturnWrappedWord_WhenTheLimitLandsOnASpace()
    {
        var result = WordWrap.Wrap("word word", 4);

        result.Should().Be("word\nword");
    }
}