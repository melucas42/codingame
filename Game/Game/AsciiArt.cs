using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class AsciiArt
{
    private const int _spaceBetweenLetters = 1;
    static void Main(string[] args)
    {
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();
        string[] rows = new string[H];

        string answer = "";

        for (int i = 0; i < H; i++)
        {
            string ROW = Console.ReadLine();

            Console.Error.WriteLine("ROW " + ROW);
            string[] letterSymbols = SplitRowToArray(ROW, L);

            foreach (var letter in T.ToCharArray())
            {
                var letterNumber = GetLetterNumber(letter);
                Console.Error.WriteLine("Getting letter " + letterNumber);
                answer += letterSymbols[letterNumber];
            }
            answer += "\n";
        }

        Console.Error.WriteLine("L " + L);
        Console.Error.WriteLine("H " + H);
        Console.Error.WriteLine("T " + T);

        //var letterList

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(answer);
    }

    private static string[] SplitRowToArray(string row, int letterWidth)
    {
        List<string> stringList = new List<string>();
        int letterStartChar = 0;
        int letterNumber = 0;
        Console.Error.WriteLine("letterWidth " + letterWidth);
        Console.Error.WriteLine("row.Length " + row.Length);

        while (letterStartChar < row.Length - 1)
        {
            Console.Error.WriteLine("LetterNumber " + letterNumber);

            var letterToAdd = row.Substring(letterStartChar, letterWidth);
            Console.Error.WriteLine("LetterToAdd " + letterToAdd);
            stringList.Add(letterToAdd);
            letterStartChar += letterWidth;
            letterNumber++;
        }
        return stringList.ToArray();
    }

    private static int GetLetterNumber(char letter)
    {
        var value = char.ToUpper(letter) - 64 - 1;
        if (value > 25 || value < 0)
        {
            return 26;
        }

        return value;
    }
}
