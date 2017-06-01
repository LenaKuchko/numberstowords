using Xunit;
using System;
using System.Collections.Generic;
using NumbersToWords.Objects;

namespace NumbersToWords
{
  public class NumberToWordsTests
  {
    // [Fact]
    // public void TestFunction()
    // {
    //   Conversion newConversion = new Conversion();
    //   Assert.Equal(3, newConversion.ConvertNum(1000000));
    // }
    // [Fact]
    // public void TestGetGroup()
    // {
    //   Conversion newConversion = new Conversion();
    //   char [] test = new char [] {'2', '3', '4'};
    //   Assert.Equal(test, newConversion.GetGroup("1234"));
    // }
    // [Fact]
    // public void TestConvertGroup()
    // {
    //   Conversion newConversion = new Conversion();
    //   Assert.Equal("eight", newConversion.ConvertGroup("999"));
    // }
    [Fact]
    public void Test()
    {
      Conversion newConversion = new Conversion();
      Assert.Equal("six", newConversion.ConvertWholeNumber("987654"));
      Console.WriteLine(newConversion.ConvertWholeNumber("987654"));
    }
  }
}
