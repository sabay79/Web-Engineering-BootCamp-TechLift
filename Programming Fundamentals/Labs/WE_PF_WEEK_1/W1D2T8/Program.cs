/*HackerLand University has the following grading policy:
- Every student receives a grade in the inclusive range from 0 to 100.
- Any grade less than 40 is a failing grade.

Sam is a professor at the university and likes to round each student's grades according to these rules:
- If the difference between the grade and the next multiple of 5 is less than , round  up to the next multiple of .
- If the value of  is less than , no rounding occurs as the result will still be a failing grade.

Given the initial value of grades for each of Sam's students, write code to automate the rounding process.*/

using System;
using System.Collections.Generic;


namespace W1D2T8
{
    internal class Program
    {
        public static List<int> GradingStudents(List<int> grade, int gradesCount)
        {
            List<int> finalGrade = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int next = ((grade[i] / 5) + 1) * 5;

                if (next - grade[i] >= 3 || grade[i] < 38)
                    finalGrade.Add(grade[i]);
                else
                    finalGrade.Add(next);
            }
            return finalGrade;
        }
        static void Main()
        {
            Console.WriteLine("Enter no of grades:");
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("\nEnter grades:");
            List<int> grades = new List<int>();
            for (int i = 0; i < gradesCount; i++)
            {
                Console.Write("Grade " + (i + 1) + " : ");
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = GradingStudents(grades, gradesCount);
            Console.WriteLine("\nFinal grades are: " + (String.Join(" ", result)));
        }
    }
}
