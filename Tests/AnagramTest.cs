using System;
using System.Collections.Generic;
using Xunit;

namespace AnagramNamespace
{
  public class AnagramTest
  {
    [Fact]
    public void Anagram_ForReturningOneWord_true()
    {
      Anagram newAnagram = new Anagram("a");
       Console.WriteLine("Test output: " + newAnagram.GetInput());
      Assert.Equal("a", newAnagram.GetInput());
    }
    [Fact]
    public void Anagram_ForReturningOneWord_false()
    {
      Anagram newAnagram = new Anagram("a");
       Console.WriteLine("Test output: " + newAnagram.GetInput());
      Assert.Equal("b", newAnagram.GetInput());
    }

    [Fact]
    public void Anagram_SetAndReturnListItems_CatDogBird()
    {
      Anagram newAnagram = new Anagram("test");
      newAnagram.SetCandidate("Cat");
      newAnagram.SetCandidate("Dog");
      newAnagram.SetCandidate("Bird");
      List<string> animals = new List<string>{};
      animals.Add("Cat");
      animals.Add("Dog");
      animals.Add("Bird");
      Console.WriteLine(animals[0] + animals[1] + animals[2]);
      Assert.Equal(animals, newAnagram.GetAll());

    }
    [Fact]
    public void Anagram_TestForPartial_true()
    {
    Anagram newAnagram = new Anagram("walking");
    newAnagram.SetCandidate("Cat");
    newAnagram.SetCandidate("Dog");
    newAnagram.SetCandidate("Bird");
    newAnagram.SetCandidate("walk");
    newAnagram.SetCandidate("walking");
    List<string> compareList = new List<string>{};
    compareList.Add("walk");
    compareList.Add("walking");
    List<string> anagramMatches = newAnagram.CheckAnagram();
    Console.WriteLine("List of partial and complete matches: " + anagramMatches[0] + anagramMatches[1]);
    Assert.Equal(compareList, newAnagram.CheckAnagram());
}

    //  [Fact]
    //  public void Anagram_CheckCheckAnagram_anagramMatches()
    // {
    // Anagram newAnagram = new Anagram("Bread");
    // newAnagram.SetCandidate("cat");
    // newAnagram.SetCandidate("dog");
    // newAnagram.SetCandidate("racecar");
    // newAnagram.SetCandidate("bird");
    // newAnagram.SetCandidate("Beard");
    // newAnagram.SetCandidate("baRed");
    // List<string> compareList = new List<string>{};
    // compareList.Add("beard");
    // compareList.Add("bared");
    // List<string> anagramMatches = newAnagram.CheckAnagram();
    // Assert.Equal(compareList, newAnagram.CheckAnagram());
    //
    // }


  }



}
