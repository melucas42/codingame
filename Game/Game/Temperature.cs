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
class Solution
{
    static void Main1(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string[] inputs = Console.ReadLine().Split(' ');
        
        var closestTemp = Int32.MaxValue;

        if (n == 0)
        {
            closestTemp = 0;
        }

        for (int i = 0; i < n; i++)
        {
            int t = int.Parse(inputs[i]);// a temperature expressed as an integer ranging from -273 to 5526

            var tempAbs = Math.Abs(t);
            Console.Error.WriteLine("t " + t);
            Console.Error.WriteLine("tempAbs " + tempAbs);
            if (t >= 0 && tempAbs <= Math.Abs(closestTemp))
            {
                closestTemp = t;
            }
            else if (tempAbs < Math.Abs(closestTemp))
            {
                closestTemp = t;
            }
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(closestTemp);
    }
}