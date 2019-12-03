using System;
using System.IO;
using System.Diagnostics;

namespace AdventOfCode
{
    public abstract class Day
    {
        public abstract string Compute(string[] input);
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Day day = new DayTwo();
            var input = File.ReadAllLines("input/day2.txt");
            Console.WriteLine(day.Compute(input));

            stopWatch.Stop();
            DisplayDuration(stopWatch);

        }

        static void DisplayDuration(Stopwatch stopWatch) {
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}h:{1:00}m:{2:00}.{3:000}s",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds);
            Console.WriteLine("-------------");
            Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine("-------------");
        }
    }
}