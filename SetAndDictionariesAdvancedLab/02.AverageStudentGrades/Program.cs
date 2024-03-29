﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!grades.ContainsKey(name))
                {
                    grades.Add(name, new List<decimal>());
                    grades[name].Add(grade);
                }
                else
                {
                    grades[name].Add(grade);
                }
            }

            foreach (var student in grades)
            {
                StringBuilder allGrades = new StringBuilder();

                for (int i = 0; i < student.Value.Count; i++)
                {
                    allGrades.Append($"{student.Value[i]:f2}" + " ");
                }

                Console.WriteLine($"{student.Key} -> {allGrades.ToString().TrimEnd()} (avg: {student.Value.Average():f2})");
            }
        }
    }
}
