using Xunit;
using System;
using System.Collections.Generic;
using NumbersToWords.Objects;

namespace NumbersToWords
{
  public class NumberToWordsTests
  {
    [Fact]
    public void TestFunction()
    {
      Conversion newConversion = new Conversion();
      Assert.Equal(3, newConversion.ConvertNum(1000000));
    }
    [Fact]
    public void TestGetGroup()
    {
      Conversion newConversion = new Conversion();
      char [] test = new char [] {'1', '0', '0'};
      Assert.Equal(test, newConversion.GetGroup("1000"));
    }
  }
}
