using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SchoolCompetition
{
    public class StartUp
    {
        public static void Main()
        {
            var scores =  new Dictionary<string, int>();
            var categories = new Dictionary<string, SortedSet<string>>();
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                var args = input.Split(' ');
                var name = args[0];
                var category = args[1];
                var score = int.Parse(args[2]);

                if (!scores.ContainsKey(name))
                {
                    scores[name] = 0;
                }

                if (!categories.ContainsKey(name))
                {
                    categories[name] = new SortedSet<string>();
                }

                scores[name] += score;
                categories[name].Add(category);

            }

            var orderedStudents = scores.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key);

            foreach (var studentKvp in orderedStudents)
            {
                var name = studentKvp.Key;
                var score = studentKvp.Value;
                var studentCategories = $"{string.Join(", ", categories[name])}";

                Console.WriteLine($"{name}: {score} [{studentCategories}]");
            }
        }
    }
}
