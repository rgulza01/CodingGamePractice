using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


class Solution
{
    static void Main(string[] args)
    {
        while (true)
        {
            List<int> peaks = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                var mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain.
                peaks.Add(mountainH);
                if (i == 7)
                {
                    var highest_index = peaks.IndexOf(peaks.Max());
                    var highest_peak = peaks.Max();
                    Console.WriteLine();
                    peaks.Remove(highest_peak);
                    //peaks.ToList().ForEach(i => Console.WriteLine(i.ToString()));
                }
            }

        }


    }
}