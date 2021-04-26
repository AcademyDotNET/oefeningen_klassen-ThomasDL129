using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbased_RPG
{
    class GameManager
    {
        public GameManager()
        {
            InitGame();
        }

        private Location currentLocation = null;
        public bool Exit { get; set; }

        public void DescribeLocation()
        {
            this.currentLocation.Describe();
        }

        public void VerwerkActie()
        {
            string actie = Console.ReadLine();
            bool error = false;
            if (actie == "n")
                currentLocation = currentLocation.GetLocationOnMove(Directions.North, playerInventory);
            else if (actie == "o")
                currentLocation = currentLocation.GetLocationOnMove(Directions.East, playerInventory);
            else if (actie == "w")
                currentLocation = currentLocation.GetLocationOnMove(Directions.West, playerInventory);
            else if (actie == "z")
                currentLocation = currentLocation.GetLocationOnMove(Directions.South, playerInventory);
            else if (actie == "p")
                AddObjectToInventory();
            else if (actie == "e")
                Exit = true;
            else
            {
                error = true;
            }
            if (error)
                Console.WriteLine("Onbekende actie");

            Console.ReadLine();
            Console.Clear();
        }

        private void AddObjectToInventory()
        {
            if (currentLocation.ObjectsInRoom.Count != 0)
            {
                playerInventory.Add(currentLocation.ObjectsInRoom[0]);
                Console.WriteLine($"Je hebt {currentLocation.ObjectsInRoom[0].Name} opgeraapt.");
                currentLocation.ObjectsInRoom.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("Je vind niets interessants.");
            }
        }

        public void ToonActies()
        {
            Console.WriteLine("Mogelijke acties: (typ bijvoorbeeld n indien u naar het noorden wil)");
            Console.WriteLine("n= noord");
            Console.WriteLine("o= oost");
            Console.WriteLine("z= zuid");
            Console.WriteLine("w= west");
            Console.WriteLine();
            Console.WriteLine("p= pak object op");
            Console.WriteLine("e= exit game");
        }

        private List<Location> GameLocations = new List<Location>();
        private List<GameObject> Objects = new List<GameObject>();
        private List<GameObject> playerInventory = new List<GameObject>();

        private void InitGame()
        {
            //Maak Locaties
            Location l1 = new Location()
            {
                Title = "De poort",
                Description = "Je staat voor een grote grijze poort die op een kier staat. Rondom je is prikkeldraad, je kan enkel naar het noorden, door de poort gaan. "
            };

            Location l2 = new Location()
            {
                Title = "Receptie",
                Description = "De receptie....veel blijft er niet meer over van wat eens een bruisende omgeving was. Hier en daar zie je skeletten van , waarschijnlijk, enkele studenten. Een grote poort staat op een kier naar het zuiden. Je ziet twee deuren aan de westelijke en noordelijke zijde."

            };

            Location l3 = new Location()
            {
                Title = "Koffieruime",
                Description = "Je staat in de koffieruimte achter de receptie. Menig pralinetje is hier vroeger met veel gusto opgesmikkeld. Een lege pralinedoos is het enige bewijs dat het hier ooit gezellig was. Een deur is de enige uitgang uit deze kamer naar het oosten."
            };

            Location l4 = new Location()
            {
                Title = "Tuin",
                Description = "Het is duidelijk herfst. Een kale boom en vele bruine bladeren op de grond...mistroosteriger kan eigenlijk niet. Je ziet een deur in het zuiden en in het westen en een grote klapdeur naar het noorden."

            };

            Location l5 = new Location()
            {
                Title = "Cafetaria",
                Description = "Ooit was dit een bruisende locatie: veel eten, geroezemoes en licht door de grote ruiten. Nu enkel stof en lege tafel. Enkel een klapdeur is zichtbaar naar het zuiden."
            };

            Location l6 = new Location()
            {
                Title = "Gang",
                Description = "Een brede gang waar makkelijk 5 mensen schouder aan schouder door kunnen. Zowel in het oosten als het westen zie je een deur."

            };

            Location l7 = new Location()
            {
                Title = "Computerruimte",
                Description = "Eindelijk; je hebt het gehaald. De plek waar iedereen naar toe wil: het computerlabo!"
            };

            //Place objects in rooms
            GameObject keytol7 = new GameObject() { Description = "Verroest en groot", Name = "Sleutel" };
            l5.ObjectsInRoom.Add(keytol7);

            //Place exits
            l1.Exits.Add(new Exit() { ExitDirection = Directions.North, GoesToLocation = l2 });

            l2.Exits.Add(new Exit() { ExitDirection = Directions.South, GoesToLocation = l1 });
            l2.Exits.Add(new Exit() { ExitDirection = Directions.West, GoesToLocation = l3 });
            l2.Exits.Add(new Exit() { ExitDirection = Directions.North, GoesToLocation = l4 });

            l3.Exits.Add(new Exit() { ExitDirection = Directions.East, GoesToLocation = l2 });

            l4.Exits.Add(new Exit() { ExitDirection = Directions.South, GoesToLocation = l2 });
            l4.Exits.Add(new Exit() { ExitDirection = Directions.West, GoesToLocation = l6 });
            l4.Exits.Add(new Exit() { ExitDirection = Directions.North, GoesToLocation = l5 });

            l5.Exits.Add(new Exit() { ExitDirection = Directions.South, GoesToLocation = l4 });

            l6.Exits.Add(new Exit() { ExitDirection = Directions.East, GoesToLocation = l4 });
            l6.Exits.Add(new Exit() { ExitDirection = Directions.West, GoesToLocation = l7, NeedsObject = new List<GameObject>() { keytol7 } }); //needs key condition

            l7.Exits.Add(new Exit() { ExitDirection = Directions.East, GoesToLocation = l6 }); //Winning room

            //Voeg locatie toe
            GameLocations.Add(l1);
            GameLocations.Add(l2);
            GameLocations.Add(l3);
            GameLocations.Add(l4);
            GameLocations.Add(l5);
            GameLocations.Add(l6);
            GameLocations.Add(l7);

            currentLocation = l1;
        }
    }
}
