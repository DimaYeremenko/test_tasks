using System;
using System.Linq;

namespace Second_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            SecondTask();

            Console.ReadKey();
        }

        private static void SecondTask()
        {
            var random = new Random();

            var uniqueArray = new int?[100000];

            for (int i = 0; i < uniqueArray.Length; i++)
            {
                var newUniqueNumber = 0;
                while (true)
                {
                    newUniqueNumber = random.Next(0, uniqueArray.Length);
                    if (!uniqueArray.Contains(newUniqueNumber)) break;
                }

                uniqueArray[i] = newUniqueNumber;
            }

            // Check for unique value in array, You can remove or comment if not need
            Console.WriteLine(uniqueArray.Distinct().Count() == uniqueArray.Count() ? "Unique" : "Not unique");
        }
    }
}
