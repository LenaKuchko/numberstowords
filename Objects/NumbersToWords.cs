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
      { 9, "nine"},   { 10, "ten"},   { 11, "eleven"},  { 12, "twelve"},  { 13, "thirteen"},
      { 15, "fifteen"},  { 18, "eighteen"}, { 20, "twenty"}, { 30, "thirty"},
      { 50, "fifty"}, { 80, "eighty"}
    };

    public double ConvertNum(int input)
    {
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

    public string ConvertGroup (int groupInput)
    {
      string result = "";
      int hundreds = groupInput/100;
      int tens = groupInput % 100;
      int ones = groupInput % 10;
      Console.WriteLine(result);

      // return uniqueSpecial[tens];
      Console.WriteLine(tens + "this one");
      if (hundreds != 0)
      {
        result += uniqueSpecial[hundreds] + " hundred ";
      }
      Console.WriteLine(tens);
      if (tens != 0 && uniqueSpecial.ContainsKey(tens))
      {
        result += uniqueSpecial[tens];
        Console.WriteLine(tens);
        Console.WriteLine(result);
        return result;
      }
        else if (tens/10 == 2 || tens/10 == 3 || tens/10 == 5 || tens/10 == 8)
        {
          result += " " + uniqueSpecial[tens-ones];
        }
        else
        {
          result += uniqueSpecial[tens/10] + "ty ";
        }
      if (ones != 0)
      {
        result += uniqueSpecial[ones];
      }
      Console.WriteLine(result);
      return result;
    }
  }
}
