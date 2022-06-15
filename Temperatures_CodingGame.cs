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
        int howMany;
        string inputString = Console.ReadLine();
        int result; 
        if (int.TryParse(inputString, out result))
        {
            howMany = result;
        }

        string input = Console.ReadLine();
        if (input.Length == 0)
        {
            Console.WriteLine("0");
        }
        else
        {

            string[] initialList = input.Split(' ');
            List<int> positiveList = new List<int>();
            List<int> negativeList = new List<int>();


            for (int i = 0; i < initialList.Length; i++)
            {
                int t = int.Parse(initialList[i]);// transforming
                if (t > 0)
                {
                    positiveList.Add(t);
                }
                else
                {
                    negativeList.Add(t);
                }
            }



            if (positiveList.Count == 0)
            {
                int b = negativeList.AsQueryable().Max();
                Console.WriteLine(b);

            } else if (negativeList.Count == 0)
            {
                int a = positiveList.AsQueryable().Min();
                Console.WriteLine(a);

            }
            else
            {
                int a = positiveList.AsQueryable().Min();
                int b = negativeList.AsQueryable().Max();
                int c = Math.Abs(a);

                int d = Math.Abs(b);


                if (d < c)
                {
                    Console.WriteLine(b);
                }
                else if (c == d)
                {
                    Console.WriteLine(a);
                }
                else if (d > c)
                {
                    Console.WriteLine(a);
                }

            }


        }

    }
}