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

            //Part 1
            calculate(1, initList(input), 12, 2);   

            //Part 2
            for(int n = 0; n < 100; n++){
                for(int v = 0; v < 100; v++){
                    if (calculate(2, initList(input), n, v) == 19690720) {
                        return (100 * n + v).ToString();
                    }
                }
            }
            return null;
        }

        private int calculate(int part, List<int> list, int noun, int verb) {

            list[1] = noun;
            list[2] = verb;

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
            return list[0];
        }

        private List<int> initList(String[] input) {
            List<int> list = input[0]
                .Split(',')
                .Select(i => int.Parse(i))
                .ToList(); 
            return list;
        }

        private int addition(int a, int b) {
            return a + b;
        }

        private int multiply(int a, int b) {
            return a * b;
        }
    }
}