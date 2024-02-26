using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
  public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        char char1 = 'A';
        char char2 = 'B';
        string result = CharacterRange.GetRange(char1, char2);
        Assert.That(result, Is.Empty);


    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        char char1 = 'B';
        char char2 = 'A';
        string result = CharacterRange.GetRange(char1, char2);
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        char char1 = 'A';
        char char2 = 'C';
        string result = CharacterRange.GetRange(char1, char2);
        Assert.That(result, Is.EqualTo("B"));
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        char char1 = 'D';
        char char2 = 'G';
        string result = CharacterRange.GetRange(char1, char2);
        Assert.That(result, Is.EqualTo("E F"));
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        char char1 = 'X';
        char char2 = 'Z';
        string result = CharacterRange.GetRange(char1, char2);
        Assert.That(result, Is.EqualTo("Y"));
    }
}
