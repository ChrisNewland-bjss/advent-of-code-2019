using System.Collections.Specialized;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System;

namespace AdventOfCode
{
    public class DayTwo : Day
    {
        public override string Compute(string[] input) {

            List<int> list = input[0]
                .Split(',')
                .Select(i => int.Parse(i))
                .ToList();
            int noun = list[1] = 12;
            int verb = list[2] = 2;

            calculate(list);
            return "Day 2 - Part Two Result: " + "TODO";
        }

        private int calculate(List<int> list) {

            for(int i = 0; i < list.Count(); i++) {

                int firstNum = list[i + 1];
                int sencondNum = list[i + 2];
                int destination = list[i + 3];

                if (list[i] == 1) {
                    list[destination] = addition(list[firstNum], list[sencondNum]);
                    i += 3;
                }
                else if (list[i] == 2) {
                    list[destination] = multiply(list[firstNum], list[sencondNum]);
                    i += 3;
                }
                else if (list[i] == 99) { 
                    break;
                }
                else {
                    Console.WriteLine(list[i] + " - Invalid OP Code");
                }
            }
            Console.WriteLine("-------------");
            Console.WriteLine("Day 2 - Part One Result: " + list[0].ToString());
            return list[0];
        }

        private int addition(int a, int b) {
            return a + b;
        }

        private int multiply(int a, int b) {
            return a * b;
        }
    }
}