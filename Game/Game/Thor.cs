using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/
class Player
{
    static void Main1(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTx = int.Parse(inputs[2]); // Thor's starting X position
        int initialTy = int.Parse(inputs[3]); // Thor's starting Y position

        var distXAbs = Math.Abs(lightX - initialTx);
        var distYAbs = Math.Abs(lightY - initialTy);

        var xDir = GetXDir(lightX, initialTx);
        var yDir = GetYDir(lightY, initialTy);

        var generalDir = yDir + xDir;

        Console.Error.WriteLine("xDir " + xDir);
        Console.Error.WriteLine("yDir " + yDir);
        Console.Error.WriteLine("distXAbs " + distXAbs);
        Console.Error.WriteLine("distYAbs " + distYAbs);
        Console.Error.WriteLine("lightX " + lightX);
        Console.Error.WriteLine("lightY " + lightY);
        Console.Error.WriteLine("initialTx " + initialTx);
        Console.Error.WriteLine("initialTy " + initialTy);

        var yCounter = 0;
        var xCounter = 0;
        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.

            if (xCounter < distXAbs && yCounter < distYAbs)
            {
                xCounter++;
                yCounter++;
                Console.WriteLine(generalDir);
            }
            else if (xCounter < distXAbs)
            {
                xCounter++;
                Console.WriteLine(xDir);
            }
            else if (yCounter < distYAbs)
            {
                yCounter++;
                Console.WriteLine(yDir);
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");


            // A single line providing the move to be made: N NE E SE S SW W or NW
        }
    }

    private static string GetYDir(in int lightY, in int initialTy)
    {
        if (lightY < initialTy)
        {
            return "N";
        }
        if (lightY > initialTy)
        {
            return "S";
        }

        return string.Empty;
    }

    private static string GetXDir(int lightX, int initialTx)
    {
        if (lightX < initialTx)
        {
            return "W";
        }
        if (lightX > initialTx)
        {
            return "E";
        }

        return string.Empty;
    }
}