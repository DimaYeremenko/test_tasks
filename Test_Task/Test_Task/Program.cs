using System;

namespace Test_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();

            Console.ReadLine();
        }

        private static void FirstTask()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("Foo Bar");
                    continue;
                }

                if (i % 3 == 0)
                {
                    Console.WriteLine("Foo");
                    continue;
                }

                if (i % 5 == 0)
                {
                    Console.WriteLine("Bar");
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}
