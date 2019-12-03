using System.Linq;
using System;

namespace AdventOfCode
{
    public class DayOne : Day {

        public override string Compute(string[] input) {

            float output = 0;
            //Part One
            // float calc(float o) => output += MathF.Floor(o / 3) - 2;
            // var i = input.Select(int.Parse).ToList();
            // i.ForEach(x => calc(x));

            //Part Two
            float calc(float o) => output += o;
            foreach(string s in input) {
                float o = Int32.Parse(s);
                while (MathF.Floor(o / 3) - 2 > 0) {
                    calc(o = MathF.Floor(o / 3) - 2);
                }
            }
            Console.WriteLine("-------------");
            return "Day 1 - Part Two Result: " + output.ToString();
        }
    }
}