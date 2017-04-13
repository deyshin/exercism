using System;
using System.Collections.Generic;

public static class Scrabble
{
    public static int Score(string input)
    {
        int score = 0;
        var charArray = input?.ToUpper().ToCharArray();

        try
        {
            if (charArray == null)
            {throw new Exception("Input has no char");}

            foreach (var l in charArray)
            { score += LetterToValue(l); }
        }
        catch
        {score = 0;}

        return score;
    }

    private static byte LetterToValue(char letter)
    {
        byte value;
        LetterValueDictionary.TryGetValue(letter, out value);

        return value;
    }

    private static Dictionary<char, byte> LetterValueDictionary = new Dictionary<char, byte>()
    {
        {'A',1}, {'E',1}, {'I',1}, {'O',1}, {'U',1}, {'L',1}, {'N',1}, {'R',1}, {'S',1}, {'T',1},
        {'D',2}, {'G',2},
        {'B',3}, {'C',3}, {'M',3}, {'P',3},
        {'F',4}, {'H',4}, {'V',4}, {'W',4}, {'Y',4},
        {'K',5},
        {'J',8}, {'X',8},
        {'Q',10}, {'Z',10}
    };
}