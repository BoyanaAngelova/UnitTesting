using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverseTests
{
    [Test]
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        //Arrange
        int[] ints = { };
        //Act
        string result = Reverse.ReverseArray(ints); 
        //Assert
        Assert.That(result, Is.EqualTo(" "));
    }

  
    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        //Arrange
        int[] ints = new int[] { 1, 2, };
        //Act
        string result = Reverse.ReverseArray(ints);
        //Assert
        Assert.That(result, Is.EqualTo("1,2"));
    }

    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {
        
    }
}
