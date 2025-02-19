using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsApp
{
    public class StarWarsCharacter
    {
        public string Name { get; set; }
        public string Alliance { get; set; }
        public string Rank { get; set; }
        public string LightSaberColor { get; set; }
        public List<string> Quotes { get; set; }

        public StarWarsCharacter() : this ("Luke Skywalker", "Jedi", "Jedi Knight", "Green")
        {
            Quotes = new List<string>
            {
                "Do or do not. There is no try.",
                "Fear is the path to the dark side."
            };
        }

        public StarWarsCharacter(string naam, string alliantie, string rang, string lichtzwaardKleur)
        {
            Name = naam;
            Alliance = alliantie;
            Rank = rang;
            LightSaberColor = lichtzwaardKleur;
        }

        public string DescribeCharacter()
        {
            return $"Naam: {Name}, Alliantie: {Alliance}, Rang: {Rank}, Lichtzwaardkleur: {LightSaberColor}";
        }

        public void ShowQuotes()
        {
            foreach (var quote in Quotes)
            {
                Console.WriteLine($"\"{quote}\"");
            }
        }
    }
}
