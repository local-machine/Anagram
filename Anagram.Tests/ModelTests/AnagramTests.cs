using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Anagram.Models
{
  public class AnagramTests
  {
    [TestMethod]
    public void AnagramConstructor_CreatesInstanceOfAnagram_Anagram()
    {
      Anagram myAnagram = new Anagram();
      Assert.AreEqual(typeof(Anagram), myAnagram.GetType());
    }
  }
}