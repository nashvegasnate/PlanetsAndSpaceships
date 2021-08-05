using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            Console.WriteLine($"Planets are listed as follows: {String.Join(',', planetList)}");


            List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastTwoPlanets);
            Console.WriteLine($"All of the planets are listed as follows: {String.Join(',', planetList)}");

            planetList.Insert(0, "Venus");
            planetList.Insert(1, "Earth");
            Console.WriteLine($"Almost all the planets are listed as follows: {String.Join(',', planetList)}");

            planetList.Add("and Pluto");
            Console.WriteLine($"At last, all the planets (including Pluto) are listed as follows: {String.Join(',', planetList)}");


            List<string> rockyPlanets = new List<string>(planetList.GetRange(0, 4).ToArray());
            Console.WriteLine($"These are the rocky planets: {String.Join(',', rockyPlanets)}");

            planetList.RemoveAt(planetList.Count -1);
            //OR
            //planetList.Remove("and Pluto");
            Console.WriteLine($"These are the real planets: {String.Join(',', planetList)}");

            var dictionary = new Dictionary<string, string>();
            //???????????????????
            
        }
    }
}
