using System;
using System.Collections.Generic;

namespace NumbersToWords.Objects
{
  public class Conversion
  {
    public Dictionary<int, string> uniqueSpecial = new Dictionary<int, string>
    {
      { 1, "one"}, { 2, "two"}, { 3, "three"}, { 4, "four"},
      { 5, "five"}, { 6, "six"}, { 7, "seven"}, { 8, "eight"},
      { 9, "nine"}, { 10, "ten"}, { 11, "eleven"}, { 12, "twelve"},
      { 13, "thirteen"}, { 15, "fifteen"}, { 100, "hundred"}, { 1000, "thousand"},
      { 1000000, "million"}
      //  { 1000000000, "billion"}, { 1000000000000, "trillion"}
    };

    public double ConvertNum(int input)
    {
      //tell us how many groups of three
      Console.WriteLine(input.ToString());
      double groupCount = (double)input.ToString().Length / 3;
      return Math.Ceiling(groupCount);

    }
    public char [] GetGroup(string input)
    {
      char [] arrayString = input.ToCharArray();
      char [] array = new char [3];
      for (int i=0; i<3; i++)
       {
        array[i] = arrayString[i];
      }
      return array;
    }
  }
}
