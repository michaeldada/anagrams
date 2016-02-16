using System;
using System.Linq;
using System.Collections.Generic;

namespace AnagramNamespace
{
  public class Anagram
  {
    private string _input;
    private List<char> _inputChars;

    private List<string> _candidates;
    private List<char> _candidateChars;


    public Anagram(string input)
    {
      _input=input;
      _candidates = new List<string>{};
      _candidateChars = new List<char>{};
      _inputChars = new List<char>{};
    }

    public string GetInput()
    {
      return this._input;
    }
    public List<string> GetAll()
    {
      return this._candidates;
    }
    public void SetCandidate(string candidateInput)
    {
      _candidates.Add(candidateInput);
      // _candidateChars.Add(candidateInput);

    }
    public List<string> GetCandidate()
    {
      return this._candidates;
    }

    // public List<string> CheckPerfectAnagram()
    // {
    //   List<string> perfectMatches = new List<string>{};
    //   foreach (string item in GetAll())
    //   {
    //     if (string.Equals(this.GetInput(), item, StringComparison.OrdinalIgnoreCase))
    //     {
    //       perfectMatches.Add(item);
    //     }
    //   }
    //   return perfectMatches;
    // }

    public List<string> CheckAnagram()
    {
      List<string> anagramMatches = new List<string>{};
      List<char> lettersInCommon = new List<char>{};
      // List<string> sortedCandidates = new List<string>{};
      foreach (string item in GetAll())
      {
         char[] itemArray = (item.ToLower()).ToCharArray();
        Array.Sort(itemArray);
        Console.WriteLine(itemArray);
        string itemString = new string(itemArray);
        char[] inputArray = this.GetInput().ToLower().ToCharArray();
        Array.Sort(inputArray);
        string inputString = new string(inputArray);
        inputString.ToLower();
        int Counter = 0;


        if(string.Equals(inputString, itemString, StringComparison.OrdinalIgnoreCase))
        {
          anagramMatches.Add( item.ToLower() );
        }
        else
        {
          foreach (char character in itemArray)
          {
              int length = inputArray.Length-1;

              for (int i = 0; i<=length; i++)
              {
                if(character == inputArray[i])
                {
                  Counter++;
                }


              }
              if (Counter >= 3)
              {
                anagramMatches.Add( item.ToLower() );
                Counter = 0;
              }
            //if char==inputArray[index]
            //add partial match to anagramMatches
          }
        }

      }
        return anagramMatches;
    }

    // public static string CheckAnagram()
    // {
    //    new _inputCharArray = GetInput().toCharArray();
    //   _inputChars.Add()
    //
    //
    //
    // }
  }
}
