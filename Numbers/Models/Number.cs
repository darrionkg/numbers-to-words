using System.Collections.Generic;

namespace NumbersToWords

{
  public class Numbers
  {
    private string _number;
    private static Dictionary<int, string> _onesPlace = new Dictionary<int, string> ()
    {
      {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}
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
  }
}
