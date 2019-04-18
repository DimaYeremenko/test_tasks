using System;
using System.Collections.Generic;
using System.Linq;

namespace Sixth_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new List<string> {"red", "green", "yellow", "blue", "purple"};

            Console.WriteLine("Init array");
            array.ForEach(i => Console.Write($"{i}, "));

            Console.WriteLine();
            Console.WriteLine("Input item:");
            var item = Console.ReadLine();

            var newArray = ChangeStartingPoint(array, item);

            Console.WriteLine("Result array");
            newArray.ForEach(i => Console.Write($"{i}, "));

            Console.ReadKey();
        }

        private static List<string> ChangeStartingPoint(List<string> array, string first)
        {
            var index = array.IndexOf(first);
            var resultArray = array.Skip(index).Take(array.Count - index).ToList();
            resultArray.AddRange(array.Take(index));

            return resultArray;
        }
    }
}
