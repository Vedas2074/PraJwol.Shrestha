using System;
class IterationStatement
{
    // Pascal case: IterationStatment
    // Camel case: iterationStatement
    static void Main()
    {
        IterationStatement iterationStatement = new IterationStatement();
        iterationStatement.LearnForLoops();
    }
    void LearnForLoops()
    {
        int i;
        for (i = 0; i < 10; i++)
        {
            Console.WriteLine("Hello World!");

            int[] numbers = { 4, 5, 6, 7, 8, 9, 10 };
            for (int x = 0; x < numbers.Length; x++)
            {
                Console.WriteLine(numbers[x]);
            }

            // foreach(int num in numbers)
            // {
            //    Console.WriteLine(num);
            //  }

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
    void LearnWhileLoops()
    {
        // int i = 0;
        // while( i < 10)
        // {
        //     Console.WriteLine("Hello World!");
        //     i++;
        // }
        string confirm = "Y";
        while (confirm == "Y")
        {
            Console.WriteLine("Hello world!");
            Console.WriteLine("Wat to print one more time?");
            confirm = Console.ReadLine();
        }

        string confirm1 = "Y";
        do
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Want to print one more time?");
            confirm1 = Console.ReadLine();

        } while (confirm == "Y");
    }
}