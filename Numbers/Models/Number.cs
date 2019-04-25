using System.Collections.Generic;

namespace NumbersToWords

{
  public class Numbers
  {
    private string _number;
    private static Dictionary<string, string> _onesPlace = new Dictionary<string, string> ()
    {
      {"1", "one"}, {"2", "two"}, {"3", "three"}, {"4", "four"}, {"5", "five"}, {"6", "six"}, {"7", "seven"}, {"8", "eight"}, {"9", "nine"}
    };

    private static Dictionary<string, string> _tenToTwenty = new Dictionary<string, string> ()
    {
      {"10", "ten"}, {"11", "eleven"}, {"12", "twelve"}, {"13", "thirteen"}, {"14", "fourteen"}, {"15", "fifteen"}, {"16", "sixteen"}, {"17", "seventeen"}, {"18", "eighteen"}, {"19", "nineteen"}
    };

    private static Dictionary<string, string> _tensPlace = new Dictionary<string, string> ()
    {
      {"2", "twenty"}, {"3", "thirty"}, {"4", "forty"}, {"5", "fifty"}, {"6", "sixty"}, {"7", "seventy"}, {"8", "eighty"}, {"9", "ninety"}
    };

    private static Dictionary<string, string> _otherPlaces = new Dictionary<string, string> ()
    {
      {"3", "hundred"}, {"4", "thousand"}, {"6", "million"}, {"9", "billion"}, {"12", "trillion"}
    };

    public Numbers(string number)
    {
      _number = number;
    }

    public string GetNumber()
    {
      return _number;
    }

    public void SetNumber(string newNumber)
    {
      _number = newNumber;
    }

    public char[] MakeArray()
    {
      char[] numberArray = _number.ToCharArray();
      return numberArray;
    }

    
  }
}
