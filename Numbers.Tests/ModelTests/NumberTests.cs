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
  }
}
