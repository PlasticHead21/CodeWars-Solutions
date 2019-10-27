using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HungerGames
{
    class HungryGames
    {
        static void Main(string[] args)
        {
            foreach (var i in Dinglemouse.WhoEatsWho("leaves,busker,antelope,leaves,fox,lion,cow,busker,lion,cow,giraffe,leaves,antelope"))
            {
                Console.WriteLine(i);
            }
                      
        }
    }

    public static class Dinglemouse
    {
        private static Dictionary<string, List<string>> animals;
        static Dinglemouse()
        {
            animals = new Dictionary<string, List<string>>()
            {
                {"antelope", new List<string> {"grass"}},
                { "grass", null},
                { "big-fish", new List<string>{"little-fish"}},
                { "leaves", null},
                { "bear", new List<string>{"big-fish", "bug", "leaves", "chicken", "cow", "sheep"}},
                { "chicken", new List<string>{"bug"}},
                { "cow", new List<string>{"grass"}},
                { "sheep", new List<string>{"grass"}},
                { "fox", new List<string>{"chicken", "sheep"}},
                { "giraffe", new List<string>{"leaves"}},
                { "lion", new List<string>{"antelope", "cow"}},
                { "panda", new List<string>{"leaves"}},
                { "bug", new List<string>{"leaves"}}
            };
        }
        public static string[] WhoEatsWho(string zoo)
        {
            if (String.IsNullOrEmpty(zoo)) return new String[]{zoo};
            List<string> escapedAnimals = zoo.Split(new char[] {','}).ToList();
            List<string> report = new List<string> {zoo};
            while (HungryGames(report, escapedAnimals)){}           
            report.Add(String.Join(",", escapedAnimals));
            
            return report.ToArray();
        }

        private static bool HungryGames(List<string> report, List<string> escapedAnimals)
        {
            for (int i = 0; i < escapedAnimals.Count(); i++)
            {

                var selectedAnimal = DetermineAnimal(escapedAnimals[i]);
                if (CanEatLeft(escapedAnimals, i, selectedAnimal))
                {
                    EatLeft(report, escapedAnimals, i);
                    return true;
                }
                if (CanEatRight(escapedAnimals, i, selectedAnimal))
                {
                    EatRight(report, escapedAnimals, i);
                    return true;
                }
            }

            return false;
        }

        private static KeyValuePair<string, List<string>> DetermineAnimal(string selectedAnimal)
        {
            var determinedAnimal = animals.FirstOrDefault(a => a.Key == selectedAnimal);
            return determinedAnimal;
        }

        private static bool CanEatLeft(List<string> escapedAnimals, int index, KeyValuePair<string, List<string>> selectedAnimal)
        {
            if (escapedAnimals == null || index <= 0) return false;
            var leftAnimal =escapedAnimals[index - 1];
            if (selectedAnimal.Value != null)
            {
                return selectedAnimal.Value.Contains(leftAnimal);
            }
            else
            {
                return false;
            }
        }

        private static bool CanEatRight(List<string> escapedAnimals, int index, KeyValuePair<string, List<string>> selectedAnimal)
        {
            if (escapedAnimals == null || index >= escapedAnimals.Count() - 1) return false;
            var rightAnimal = escapedAnimals[index + 1];
            if (selectedAnimal.Value != null)
            {
                return selectedAnimal.Value.Contains(rightAnimal);
            }
            else
            {
                return false;
            }
        }

        private static void EatLeft(List<string> report, List<string> escapedAnimals, int index)
        {
            Eat(report, escapedAnimals, index - 1, index);
        }

        private static void EatRight(List<string> report, List<string> escapedAnimals, int index)
        {
            Eat(report, escapedAnimals, index + 1, index);
        }

        private static void Eat(List<string> report, List<string> escapedAnimals, int victim, int predator)
        {
            report.Add($"{escapedAnimals[predator]} eats {escapedAnimals[victim]}");
            escapedAnimals.RemoveAt(victim);
        }
    }
}
