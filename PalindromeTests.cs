using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> word = new() { "aha", "boob" };
        // Act
        bool result = Palindrome.IsPalindrome(word);
        // Assert
        Assert.IsTrue(result);
    }

    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> word= new();

        // Act
        bool result = Palindrome.IsPalindrome(word);
        //
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        List<string> word = new() { "aha" };

        // Act
        bool result = Palindrome.IsPalindrome(word);
        //
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        List<string> word = new() { "hahaa" };

        // Act
        bool result = Palindrome.IsPalindrome(word);
        //
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        List<string> word = new() { "hahah", "aha" };

        // Act
        bool result = Palindrome.IsPalindrome(word);
        //
        Assert.IsTrue(result);
    }
}
