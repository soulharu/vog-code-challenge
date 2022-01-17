using System;
using System.Collections.Generic;
using System.Linq;

namespace VogCodeChallenge.ConsoleApp
{
    public static class QuestionClass
    {
        static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "Jeffrey",
            "John",
        };

        public static void IterateThrough()
        {
            //Method 1
            var concatenate = string.Join(", ", NamesList);
            Console.WriteLine($"Iterated with string.Join() to concatenate: {concatenate}. \n");

            //Method 2
            var linq = NamesList.Where(n => n.EndsWith("y")).ToList();           
            Console.WriteLine("Iterated with Linq and lambda expression filtering names ending with \"y\": ");
            linq.ForEach(i => Console.WriteLine($"- {i}"));
        }

        public static object TESTModule(object entry)
        {
            switch (entry)
            {
                case int i when (i <= 0):
                    throw new Exception("Entry value can't be a interger smaller than 1.");

                case int i when (i > 4):
                    return i * 3;

                case int i:
                    return i * 2;

                case float f when (f == 1.0f || f == 2.0f):
                    return 3.0f;

                case string s:
                    return s.ToUpper();

                default:
                    return entry;
            }
        }
    }
}
