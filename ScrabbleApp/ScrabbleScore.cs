using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ScrabbleScore
{
    Dictionary<int, string> PointScore = new Dictionary<int, string>
    {
        {1, "AEIOULNSTR" },
        {2, "DG" },
        {3, "BCMP" },
        {4, "FHVWY" },
        {5, "K" },
        {8, "JX" },
        {10, "QZ" },
    };

    public int GetScrabbleScore(string word)
    {
        int wordScore = 0;
        foreach (char letter in word.ToUpper())
        {
            foreach(int score in PointScore.Keys)
            {
                if (PointScore[score].Contains(word))
                {
                    wordScore += score;
                }
            }

        }
        return wordScore;
    }

}
