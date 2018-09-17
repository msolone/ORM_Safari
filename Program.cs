using System;
using ORM_Safari.Models;

namespace ORM_Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Wow, what was the name of that animal!?");
            while (true) {
            var species = System.Console.ReadLine(); 
            var newSpecies = new SeenAnimals {
                Species = species
            };
            var db = new SafariVacationContext();
            db.SeenAnimalsTable.Add(newSpecies);
            db.SaveChanges();
            }
        }
    }
}
