using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SourcerProject.Models;
using System.Collections.ObjectModel;

namespace SourcerProject.DataLayer
{
    public class GameData
    {
        public static Player PlayerData()
        {
            return new Player()
            {
                Id = 1,
                Name = "Deckard",
                Age = 24,
                Health = 100,
                Lives = 3,
                ExperiencePoints = 0,
                LocationId = 0
            };
        }

        public static List<string> InitialMessages()
        {
            return new List<string>()
            {
                "\t The year is 2145 the human race has reached a level technology that allows them to shape reality itself,.....",
                "\t This event caused human beings to born with extraordinary abilites that were only achievable through technology before our story begins 24 years after that event..."
            };
        }
        public static Location StartingLocation()
        {
            return new Location()
            {
                Id = 1,
                Name = "Alpha Base",
                Description = "This is the first secret base of the Sourcer organization" +
                    "It was created by the Citium Organization which is in charge of managing, training, and monitoring all Sourcers. " +
                    "Not much is known about Citium but they managed to aquire all government contracts involved with Sourcers across the world.",
                Accessilbe = true
            };
        }

        public static Map GameMapData()
        {
            Map GameMap = new Map();

            ObservableCollection<Location> locations = new ObservableCollection<Location>
            {
                new Location()
                {
                    Id = 2,
                    Name = "Detroit, Michigan",
                    Description = "Detroit is quite different from what it was in the  early 21st century. The city that was  once considered a economic wasteland and crime" + 
                    " running rampant. Detroit is now the economic model for cities accross the world. Detroit's turnaround can be creditied to Citium which bought large parts  of city and  " +
                    " turned it in science, technology, and research hub of the world. But don't let the glitz and glamor fool you. The old Detroit is still here and it's criminal organizitions are biding their time.",
                    Accessilbe = true
                },
                new Location()
                {
                    Id = 3,
                    Name = "New York City, New York",
                    Description = "New York...",
                    Accessilbe = true
                    
                },
                new Location()
                {
                    Id = 4,
                    Name = "Los Angelos, California",
                    Description = "LA...",
                    Accessilbe = true

                },
                new Location()
                {
                    Id = 5,
                    Name = "Sao Paulo, Brazil",
                    Description = "Sao Paulo....",
                    Accessilbe = true
                }
            };

            return GameMap; 
        }
    }
}

