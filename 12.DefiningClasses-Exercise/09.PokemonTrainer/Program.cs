using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            string input = "";
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] inputData = input.Split();
                string trainerName = inputData[0];
                string pokemonName = inputData[1];
                string pokemonElement = inputData[2];
                int pokemonHealth = int.Parse(inputData[3]);
                bool containsCurrentTrainer = false;
                foreach (Trainer item in trainers)
                {
                    if (item.Name == trainerName)
                    {
                        item.Pokemon.Add(new Pokemon() { Name = pokemonName, Element = pokemonElement, Health = pokemonHealth });
                        containsCurrentTrainer = true;
                        break;
                    }
                }
                if (!containsCurrentTrainer)
                {
                    trainers.Add(new Trainer() { Name = trainerName, Badges = 0, Pokemon = new List<Pokemon>() });
                    trainers[trainers.Count - 1].Pokemon.Add(new Pokemon() { Name = pokemonName, Element = pokemonElement, Health = pokemonHealth });
                }
            }
            while ((input = Console.ReadLine()) != "End")
            { 
                foreach (Trainer item in trainers)
                {
                    if (!item.Pokemon.Any(x => x.Element == input))
                    {
                        item.Pokemon.ForEach(x => x.Health -= 10);
                        item.Pokemon.RemoveAll(x => x.Health <= 0);
                    }
                    else
                    {
                        item.Badges++;
                    }
                }
            }
            foreach (Trainer item in trainers.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine($"{item.Name} {item.Badges} {item.Pokemon.Count}");
            }
        }
    }
}
