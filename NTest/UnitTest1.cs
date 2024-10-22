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
}