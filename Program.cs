using System;
using System.Linq;
using ORM_Safari.Models;

namespace ORM_Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create

            // System.Console.WriteLine("Wow, what was the name of that animal!?");
            // while (true) {
            // var species = System.Console.ReadLine(); 
            // var newSpecies = new SeenAnimals {
            //     Species = species
            // };
            // var db = new SafariVacationContext();
            // db.SeenAnimalsTable.Add(newSpecies);
            // db.SaveChanges();

            
            
            // Show all animals seen

            // SQL Equivalent : SELECT * FROM SeenAnimals

            // var db = new SafariVacationContext();
            // var animals = db.SeenAnimalsTable;

            // foreach (var animal in animals) 
            // {
            //     System.Console.WriteLine($"You saw a {animal.Species}");
            // }
 
            
            
            // Update

            // SQL Equivalent : UPDATE SeenAnimalsTable SET CountofTimesScene = 3 AND LocationOfLastScene = Africa WHERE Id = 2
            // var AnimalToUpdate = db.SeenAnimalsTable.FirstOrDefault(animal => animal.Id == 2);

            // AnimalToUpdate.CountOfTimesSeen = 3;
            // AnimalToUpdate.LocationOfLastSeen = "Africa";

            // var AnimalToUpdate = db.SeenAnimalsTable.FirstOrDefault(animal => animal.Id == 5);

            // AnimalToUpdate.CountOfTimesSeen = 2;
            // AnimalToUpdate.LocationOfLastSeen = "Forest";

            // db.SaveChanges();

           
           
            // Display all Animals from the Jungle

            // SQL Equivalent : SELECT * FROM SeenAnimalsTable WHERE LocationOfLastSeen = "Jungle"

            // var JungleAnimals = db.SeenAnimalsTable
            //         .Where(animal => animal.LocationOfLastSeen == "Jungle");
            // foreach (var animal in JungleAnimals) 
            // {
            // System.Console.WriteLine(value: $"I saw a {animal.Species} in the Jungle");
            // }

            
            
            // Remove

            // SQL Equivalent : DELETE FROM SeenAnimalsTable WHERE LocationOfLastSeen = 'Desert'

            // var DeleteDesert = db.SeenAnimalsTable.FirstOrDefault(animal => animal.LocationOfLastSeen == "Desert");

            // db.SeenAnimalsTable.Remove(DeleteDesert);

            // db.SaveChanges();

            
            
            // Adding all of the CountOfTimesSeen

            // var db = new SafariVacationContext();
            // var animals = db.SeenAnimalsTable;
            // var total = 0;
            // foreach (var animal in animals) 
            // {
            //     total += animal.CountOfTimesSeen;
            // }
            // System.Console.WriteLine($"You saw {total} animals on your safari trip");

            
            
            // Adding the times you saw Lions, Tigers, and Bears Oh My!

            // var db = new SafariVacationContext();
            // var animals = db.SeenAnimalsTable.Where(animal => animal.Species == "Lion" || animal.Species == "Tiger" || animal.Species == "Bear");
            // var total = 0;
            // foreach (var animal in animals) 
            // {
            //     total += animal.CountOfTimesSeen;
            // }
            // System.Console.WriteLine($"You saw {total} Lions, Tigers, and Bears on your safari trip");

            // Adventure Mode : Add a TimeDate Column and Update Time for 1 animal to current time

            var db = new SafariVacationContext();
            var AnimalToUpdate = db.SeenAnimalsTable.FirstOrDefault(animal => animal.Species == "Tiger");

            AnimalToUpdate.LastSeenTime = DateTime.Now;

            db.SaveChanges();
    
        }
    }
}

        
    




