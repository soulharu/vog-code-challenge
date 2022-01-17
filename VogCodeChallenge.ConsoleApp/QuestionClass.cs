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
    }
}
