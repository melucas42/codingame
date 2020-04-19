using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * The while loop represents the game.
 * Each iteration represents a turn of the game
 * where you are given inputs (the heights of the mountains)
 * and where you have to print an output (the index of the mountain to fire on)
 * The inputs you are given are automatically updated according to your last actions.
 **/
class TheDescent
{
    static void Main1(string[] args)
    {

        // game loop
        while (true)
        {
            //var mountainList = new List<Mountain>();
            var indexOfMax = 0;
            var maxHeight = 0;
            for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine());
                //mountainList.Add(new Mountain()
                //{
                //    index = i,
                //    height = mountainH
                //});
                if(mountainH >= maxHeight) { indexOfMax = i; }
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            //var mountain = mountainList.Sort(
                //.Select(i => i.index).Max(m => m.height);
           Console.WriteLine(indexOfMax); // The index of the mountain to fire on.

        }
    }
}

class Mountain
{
    public int index;
    public int height;
}