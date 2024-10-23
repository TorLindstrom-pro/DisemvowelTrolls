using DisemvowelTrolls;

namespace NTest;

public class Tests
{
    [Test]
    public void InputIsOnlyConsonants_ReturnsInput()
    {
        var result = Kata.Disemvowel("qwrt");
        Assert.That(result, Is.EqualTo("qwrt"));
    }
    
    [Test]
    public void InputIsOnlyVowels_ReturnsEmptyString()
    {
        var result = Kata.Disemvowel("aeiou");
        Assert.That(result, Is.EqualTo(""));
    }
    
    [Test]
    public void VowelsInInput_ReturnsInputWithoutVowels()
    {
        var result = Kata.Disemvowel("hello");
        Assert.That(result, Is.EqualTo("hll"));
    }
    
    [Test]
    public void UpperCaseVowelsInInput_ReturnsInputWithoutVowels()
    {
        var result = Kata.Disemvowel("HELLO");
        Assert.That(result, Is.EqualTo("HLL"));
    }
}