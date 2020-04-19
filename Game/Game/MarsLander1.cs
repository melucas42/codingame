using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualBasic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class MarsLander
{
    static void Main1(string[] args)
    {
        string[] inputs;
        int surfaceN = int.Parse(Console.ReadLine()); // the number of points used to draw the surface of Mars.
        for (int i = 0; i < surfaceN; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            int landX = int.Parse(inputs[0]); // X coordinate of a surface point. (0 to 6999)
            int landY = int.Parse(inputs[1]); // Y coordinate of a surface point. By linking all the points together in a sequential fashion, you form the surface of Mars.
        }

        var currentPower = 0;
        // game loop
        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            int X = int.Parse(inputs[0]);
            int Y = int.Parse(inputs[1]);
            int hSpeed = int.Parse(inputs[2]); // the horizontal speed (in m/s), can be negative.
            int vSpeed = int.Parse(inputs[3]); // the vertical speed (in m/s), can be negative.
            int fuel = int.Parse(inputs[4]); // the quantity of remaining fuel in liters.
            int rotate = int.Parse(inputs[5]); // the rotation angle in degrees (-90 to 90).
            int power = int.Parse(inputs[6]); // the thrust power (0 to 4).

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            if (TooMuchPush(vSpeed))
            {
                Console.Error.WriteLine("Not descending anymore, cutting power");
                currentPower = ReducePower(currentPower);
            }
            else if (DescendingTooFast(vSpeed))
            {
                Console.Error.WriteLine("Descending too fast... increasing power");
                currentPower = IncreasePower(currentPower);
            }

            //var speedAtLanding = GetSpeedAtLanding(vSpeed, acceleration, Y);
            Console.Error.WriteLine("Y " + Y);
            Console.Error.WriteLine("vSpeed " + vSpeed);
            Console.Error.WriteLine("currentPower " + currentPower);
            // 2 integers: rotate power. rotate is the desired rotation angle (should be 0 for level 1), power is the desired thrust power (0 to 4).
            Console.WriteLine("0 " + currentPower);
        }
    }

    private static int ReducePower(int currentPower)
    {
        if (currentPower > 0)
        {
            return currentPower - 1;
        }

        return currentPower;
    }

    private static int IncreasePower(int currentPower)
    {
        if (currentPower < 4)
        {
            return currentPower + 1;
        }

        return currentPower;
    }

    private static bool TooMuchPush(int speed)
    {
        if (speed > 0)
        {
            return true;
        }

        return false;
    }
    private static bool DescendingTooFast(int speed)
    {
        if (speed < -40)
        {
            return true;
        }

        return false;
    }
}