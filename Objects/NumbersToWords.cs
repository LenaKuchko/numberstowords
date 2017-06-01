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
    public string GetGroup(string input)
    {
      char [] arrayString = input.ToCharArray();
      char [] array = new char [3];
      for (int i=0, j=input.Length-3; i<3; i++, j++)
      {
        array[i] = arrayString[j];
      }
      Console.WriteLine(array);
      string s = new string(array);
      return s;
    }

    public string ConvertGroup (string numberSection)
    {
      int groupInput = Convert.ToInt32(numberSection);
      string sectionResult = "";
      int hundreds = groupInput/100;
      int tens = groupInput % 100;
      int ones = groupInput % 10;
      Console.WriteLine(sectionResult);

      // converts "hundreds" place
      Console.WriteLine(tens + "this one");
      if (hundreds != 0)
      {
        sectionResult += uniqueSpecial[hundreds] + " hundred ";
      }
      Console.WriteLine(tens);
        //Tests "tens" place
        if (tens != 0 && uniqueSpecial.ContainsKey(tens))
        {
          sectionResult += uniqueSpecial[tens];
          Console.WriteLine(tens);
          Console.WriteLine(sectionResult);
          return sectionResult;
        }
        else if (tens/10 == 2 || tens/10 == 3 || tens/10 == 5 || tens/10 == 8)
        {
          sectionResult += " " + uniqueSpecial[tens-ones];
        }
        else
        {
          sectionResult += uniqueSpecial[tens/10] + "ty ";
        }

      if (ones != 0)
      {
        sectionResult += uniqueSpecial[ones];
      }
      Console.WriteLine(sectionResult);
      return sectionResult;
    }
    public string ConvertWholeNumber(string input)
    {
      string result = "";
      while (input != "")
      {
        Console.WriteLine("While");
        string section = GetGroup(input);
        Console.WriteLine(section);
        result += ConvertGroup(section);
        input.Remove(input.Length-3, 0);

      }
      Console.WriteLine(input);
      Console.WriteLine(GetGroup(input));
      return result;
    }
  }
}
