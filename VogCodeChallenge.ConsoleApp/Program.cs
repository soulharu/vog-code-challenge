using System;

namespace VogCodeChallenge.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Step 7: \n");
            QuestionClass.IterateThrough();

            Console.WriteLine("\n\nStep 8: \n");
            var entryArray = new object[] { 1, 5, 0, 1.0f, 5.34f, "potato", (double)9 };

            foreach (var entry in entryArray)
            {
                Console.WriteLine($"Entry: {entry}, Type: {entry.GetType().Name}");
                
                try 
                { 
                    var result = QuestionClass.TESTModule(entry);
                    Console.WriteLine($"Result: {result}, Type: {result.GetType().Name} \n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception thrown: {ex.Message} \n");
                }
            }
        }
    }
}
