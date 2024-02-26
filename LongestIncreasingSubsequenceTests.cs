using NUnit.Framework;
using NUnit.Framework.Internal;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {

        int[] lis = null;
        Assert.That(() => LongestIncreasingSubsequence.GetLis(lis), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        //Arrange
        int[] lis = Array.Empty<int>();
        //Act
        string result = LongestIncreasingSubsequence.GetLis(lis);
        //Assert
        Assert.That(result, Is.Empty);  
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        //Arrange
        int[] lis = new int[] {1};
        //Act
        string result = LongestIncreasingSubsequence.GetLis(lis);
        //Assert
        Assert.That(result, Is.EqualTo("1"));
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        //Arrange
        int[] lis = new int[] {2, 5, 4, 3, 1};
        //Act
        string result = LongestIncreasingSubsequence.GetLis(lis);
        //Assert
        Assert.That(result, Is.EqualTo("2 5"));
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        //Arrange
        int[] lis = new int[] { 1, 2, 3, 4, 5 };
        //Act
        string result = LongestIncreasingSubsequence.GetLis(lis);
        //Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 5"));

    }
}
