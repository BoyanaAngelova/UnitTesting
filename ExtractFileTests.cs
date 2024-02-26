using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
       string path = null;
        Assert.That(() => ExtractFile.GetFile(path), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        string path = "";
        Assert.That(() => ExtractFile.GetFile(path), Throws.ArgumentNullException);

    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        string path = "C:\\Users\\repos\\demo.txt";
        string expected = "File name: demo\nFile extension: txt";
        string result = ExtractFile.GetFile(path);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        string path = "C:\\Users\\repos\\demo";
        string expected = "File name: demo";
        string result = ExtractFile.GetFile(path);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        string path = "C:\\%Users\\repos\\demo.txt";
        string expected = "File name: demo\nFile extension: txt";
        string result = ExtractFile.GetFile(path);
        Assert.That(result, Is.EqualTo(expected));
    }
}
