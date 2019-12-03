﻿using System;
using System.IO;

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
            Day day = new DayTwo();
            var input = File.ReadAllLines("input/day2.txt");
            Console.WriteLine(day.Compute(input));
        }
    }
}