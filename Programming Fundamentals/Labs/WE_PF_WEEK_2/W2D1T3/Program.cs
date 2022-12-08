//Dynamic Array

using System;
using System.Collections.Generic;
using System.Linq;

namespace W2D1T3
{
    internal class Program
    {
        public static List<int> DynamicArray(int n, List<List<int>> queries)
        {
            List<int> lastAnswers = new List<int>();
            int lastAnswer = 0;

            List<List<int>> seqList = new List<List<int>>();

            for (int i = 0; i < n; i++)
                seqList.Add(new List<int>());

            foreach (var query in queries)
            {
                int index = (query[1] ^ lastAnswer) % n;
                //Insertion
                if (query.First() == 1) //query[0]
                {
                    seqList[index].Add(query.Last());
                }
                //Retrieving
                else
                {
                    int y = query.Last();
                    int size = seqList[index].Count();

                    lastAnswer = seqList[index][y % size];
                    lastAnswers.Add(lastAnswer);
                }
            }
            return lastAnswers;
        }

        static void Main()
        {
            Console.Write("Enter n=array size and q=no of queries: ");
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int q = Convert.ToInt32(firstMultipleInput[1]);

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < q; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }
            List<int> result = DynamicArray(n, queries);

            Console.WriteLine("Last Answers: "+String.Join(" ", result));
        }
    }
}
