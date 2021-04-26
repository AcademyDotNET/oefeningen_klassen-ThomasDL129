using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_RPG
{
    class Location
    {
        public Location()
        {
            Exits = new List<Exit>();
            ObjectsInRoom = new List<GameObject>();
        }

        public string Title { get; set; }
        public string Description { get; set; }

        public List<Exit> Exits { get; set; }
        public List<GameObject> ObjectsInRoom { get; set; }

        public void Describe()
        {
            Console.WriteLine(Title + "\n*********");
            Console.WriteLine(Description);
            Console.WriteLine("\nVoorts zie je ook nog:");
            foreach (var objects in ObjectsInRoom)
            {
                objects.Describe();
            }
            Console.WriteLine("\n*********");
        }

        public Location GetLocationOnMove(Directions direction, List<GameObject> playerInventory )
        {
            foreach(var exit in Exits)
    {
                if (exit.ExitDirection == direction)
                {

                    if (exit.TestPassCondition(playerInventory))
                    {
                        Console.WriteLine($"Je verplaats je naar {exit.GoesToLocation.Title}");
                        return exit.GoesToLocation;
                    }
                    else
                    {
                        Console.WriteLine("Je kan hier niet langs (je hebt niet alle vereiste items).");
                        return this;
                    }
                }
            }
            Console.WriteLine("Dat is geen geldige richting");
            return this;

        }
    }
}
