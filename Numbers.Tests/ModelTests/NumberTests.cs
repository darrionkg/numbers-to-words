using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords;
using System;
using System.Collections.Generic;

namespace NumbersToWords.Tests

{
  [TestClass]
  public class NumbersTest
  {
    [TestMethod]
    public void GetWord_SingleNumberWord_String()
    {
      Numbers testNumber = new Numbers("5");
      Assert.AreEqual(typeof(Numbers), testNumber.GetType());
    }

    [TestMethod]
    public void MakeArray_NumberString_IntArray()
    {
      Numbers testNumber = new Numbers("532");
      char[] numberArray = testNumber.MakeArray();
      char[] testArray = {'5', '3', '2'};
      CollectionAssert.AreEqual(numberArray, testArray);
    }

    [TestMethod]
    public void FindMatch_ArrayReturnsString_String()
    {
      Numbers testNumber = new Numbers("532");
      char[] numberArray = testNumber.MakeArray();
      string findMatch = testNumber.FindMatch(numberArray);
      Assert.AreEqual(findMatch, "five hundred thirty two");
    }
  }
}
