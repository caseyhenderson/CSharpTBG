using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGame
{
    enum Direction
    {
        North,
        South,
        West,
        East,
        Up,
        Down

    }
    class Room
    {
        public Dictionary<Direction, Room> exits = new Dictionary<Direction, Room>();
        public string name;
        public string description;
    }
    class Program
    {
        static void Describe(Room room)
        {
            string exitsTest = string.Join(", ", room.exits.Keys.ToArray());
            if (string.IsNullOrEmpty(exitsTest))
            {
                exitsTest = "None";
            }
            Console.WriteLine("Welcome.");
            Console.WriteLine("{0}\n\n{1}\n\nExits are: {2}\n", room.name, room.description, exitsTest);
        }

        static Room Setup()
        {
            Room main = new Room() { name = "Main", description = "This is the main room." };
            Room eastWing = new Room() { name = "East Wing", description = "This is the east wing." };
            Room closet = new Room() { name = "Closet", description = "This is a closet. The door locks behind you." };
            Room passage = new Room() { name = "Secret passage", description = "This is a long secret passage." };
            Room UpsideDown = new Room() { name = "The Upside Down", description = "Welcome to the Upside Down." }; // find Demogorgon here
            Room Lab = new Room() { name = "Abandoned Laboratory", description = "This is a strange, mysterious laboratory." }; // find item 2 here
            Room Morgue = new Room() { name = "Morgue", description = "This is a morgue. Not somewhere you really want to stick around." }; //find something here
            Room ForbiddenPath = new Room() { name = "Forbidden Path", description = "This is a forbidden pathway to new dimensions." }; // 'phase 2'
            Room Crossroads = new Room() { name = "Crossroads", description = "Many paths await here. Which will you choose?" };
            Room StrangeLake = new Room() { name = "Strange Lake", description = "There is no way across the lake and no way to proceed further south." };
            Room SilverWalkway = new Room() { name = "Silver Walkway", description = "This is the shining Silver Walkway." };
            Room GoldenRoad = new Room() { name = "Golden Road", description = "Where will this splendid road take you?" };
            Room GoldenCliff = new Room() { name = "Golden Cliff", description = "The Golden Cliff towers avove you - but to climb it you need a rope." };
            Room GoldenPath = new Room() { name= "Golden Path", description = "Continue along the Golden Path." };
            Room StrangeIsland = new Room() { name = "Strange Island", description = "There's nothing further south, but there is an object of value here." };
            Room StrangeIslandBay = new Room() { name = "Strange Island Bay", description = "West of the Strange Island, this bay provides a way for the cunning to circumvent the treacherous Golden Cliff." };
            Room StrangeIslandCliff = new Room() { name = "Strange Island Cliff", description = "From this cliff you can see the edge of the world." };
            Room EdgeOfTheWorld = new Room() { name = "Edge of the World", description = "This is the Edge of the World and you can go no further." };
            Room GoldenPathEnd = new Room() { name = "Golden Path End", description = "The path ends here." };
            Room DiamondAlley = new Room() { name = "Diamond Alley", description = "This alley glitters with the light reflected from a thousand diamonds" };
            Room Sea = new Room() { name = "Sea", description = "The endless sea." };
            Room CobaltCave = new Room() { name = "Cobalt Cave", description = "Continue through this cave to the Darkness Descent, or head north to the Abandoned Outpost where an item may be hidden." };
            Room AbandonedOutpost = new Room() { name = "Abandoned Outpost", description = "There are no people here, but they might have left something useful behind." };
            Room EmptyCave = new Room() { name = "Empty Cave", description = "It's empty, but there is an exit to the Barren Wilds" };
            Room DarknessDescent = new Room() { name = "Darkness Descent", description = "Pitch black - you need a particular item to get through here" };
            Room Nightway = new Room() { name = "Nightway", description = "The road to the city of the dead." };
            Room Necropolis = new Room() { name = "Necropolis", description = "The city of the dead awaits you, and there is a mysterious cove to the north." };
            Room MysteriousCove = new Room() { name = "Mysterious Cove", description = "There's something valuable here." };
            Room BarrenWilds = new Room() { name = "Barren Wilds", description = "Danger lurks, but this could be a valuable shortcut on your quest" };
            Room TheLandOfTheEmptyDead = new Room() { name = "The Land of the Empty Dead", description = "This is a land of death. Move quickly" };
            Room SeaOfLostSouls = new Room() { name = "The Sea of lost souls", description = "There is nothing here except a sense of loss." };
            Room BarrenPath = new Room() { name = "Barren Path", description = "Continue along it to proceed with your quest and approach the shining gates." };
            Room CliffEdge = new Room() { name = "Cliff Edge", description = "Stare out at the sea before returning to your quest" };
            Room Wildside = new Room() { name = "Wildside", description = "Emerge from the barren wilds to a wild land. Sharks await to the east, strange lands to the south, and the barren path to the shining gates to the north" };
            Room SharkPoolPrecipice = new Room() { name = "Shark Pool Precipice", description = "A close escape! Below you is a pool of hungry sharks and an ominous feel to the air." };
            Room SharkPool = new Room() { name = "Shark Pool of Death", description = "There is no escaping these hungry sharks. Your quest ends as you foolhardily walk straight into their lair" };
            Room KingShark = new Room() { name = "King Shark", description = "Should have gone north." };
            Room TheShiningGates = new Room() { name = "The Shining Gates", description = "You have made it to the shining gates, but do you have a Gate Pass?" };
            Room TheEmeraldPlateau = new Room() { name = "The Emerald Plateau", description = "The exit awaits you to the north. You are one step away from success." };
            Room Success = new Room() { name = "Success", description = "Congratulations! You have beaten the game!" };
            Room TreacherousBridge = new Room() { name = "Treacherous Bridge", description = "This bridge is really not very sturdy, and hungry sharks await below." };
            Room SidePath = new Room() { name = "Side Path", description = "A path by a pool of hungry sharks." };
            Room HopeGarden = new Room() { name = "Garden of Hope", description = "A beautiful garden which has a serene air of grace." };
            Room SilverSquare = new Room() { name = "Silver Square", description = "The silver square, a gleaming hive of activity." };
            Room SilverGate = new Room() { name = "Silver Gate", description = "This gate needs a key to continue." };
            Room SilverWalkway2 = new Room() { name = "Silver Walkway II", description = "The silver walkway continues." };
            Room SharkLake = new Room() { name = "Shark Lake", description = "If you want to get through here, you need to fight a hundred sharks. You're not getting through here." };
            Room ImpWall = new Room() { name = "Impenetrable Wall", description = "The Wall is strong and impenetrable. You must go back." };
            Room Demogorgon = new Room() { name = "Demogorgon", description = "This kills the player. Press Esc to restart." };
            Room Minefield = new Room() { name = "Minefield", description = "Mind your step..." };
            Room LockedDoor = new Room() { name = "Locked Door", description = "The door is locked... if only you had the key." };
            Room EmptyHut = new Room() { name = "Empty Hut", description = "There is nothing here." };


                
            main.exits.Add(Direction.East, eastWing);
            main.exits.Add(Direction.West, closet);
            eastWing.exits.Add(Direction.West, main);
            eastWing.exits.Add(Direction.East, LockedDoor);
            closet.exits.Add(Direction.Down, passage);
            passage.exits.Add(Direction.Up, closet);
            passage.exits.Add(Direction.East, UpsideDown);
            UpsideDown.exits.Add(Direction.West, passage);
            UpsideDown.exits.Add(Direction.Up, main);
            UpsideDown.exits.Add(Direction.Down, Lab);
            UpsideDown.exits.Add(Direction.East, Demogorgon);
            Lab.exits.Add(Direction.East, Morgue);
            Lab.exits.Add(Direction.Up, UpsideDown);
            Lab.exits.Add(Direction.North, main);
            Morgue.exits.Add(Direction.West, Lab);
            Morgue.exits.Add(Direction.South, ForbiddenPath);
            ForbiddenPath.exits.Add(Direction.North, Morgue);
            ForbiddenPath.exits.Add(Direction.South, Crossroads);
            Crossroads.exits.Add(Direction.South, StrangeLake);
            Crossroads.exits.Add(Direction.East, SilverWalkway);
            Crossroads.exits.Add(Direction.North, ForbiddenPath);
            Crossroads.exits.Add(Direction.West, GoldenRoad);
            StrangeLake.exits.Add(Direction.North, Crossroads);
            GoldenRoad.exits.Add(Direction.East, Crossroads);
            GoldenRoad.exits.Add(Direction.South, StrangeIsland);
            GoldenRoad.exits.Add(Direction.West, GoldenCliff);
            GoldenRoad.exits.Add(Direction.North, EmptyHut);
            EmptyHut.exits.Add(Direction.South, GoldenRoad);
            GoldenCliff.exits.Add(Direction.South, StrangeIsland);
            GoldenCliff.exits.Add(Direction.West, GoldenPath);
            GoldenCliff.exits.Add(Direction.East, GoldenRoad);
            StrangeIsland.exits.Add(Direction.East, StrangeLake);
            StrangeIsland.exits.Add(Direction.North, GoldenRoad);
            StrangeIsland.exits.Add(Direction.West, StrangeIslandBay);
            StrangeIslandBay.exits.Add(Direction.West, StrangeIslandCliff);
            StrangeIslandBay.exits.Add(Direction.East, StrangeIsland);
            StrangeIslandBay.exits.Add(Direction.North, GoldenPath);
            StrangeIslandCliff.exits.Add(Direction.East, StrangeIslandBay);
            StrangeIslandCliff.exits.Add(Direction.West, EdgeOfTheWorld);
            EdgeOfTheWorld.exits.Add(Direction.East, StrangeIslandCliff);
            EdgeOfTheWorld.exits.Add(Direction.North, GoldenPath);
            GoldenPath.exits.Add(Direction.South, StrangeIslandBay);
            GoldenPath.exits.Add(Direction.East, GoldenCliff);
            GoldenPath.exits.Add(Direction.North, GoldenPathEnd);
            GoldenPathEnd.exits.Add(Direction.East, EmptyCave);
            GoldenPathEnd.exits.Add(Direction.North, DiamondAlley);
            GoldenPathEnd.exits.Add(Direction.South, GoldenPath);
            EmptyCave.exits.Add(Direction.East, BarrenWilds);
            EmptyCave.exits.Add(Direction.West, GoldenPathEnd);
            DiamondAlley.exits.Add(Direction.North, Sea);
            DiamondAlley.exits.Add(Direction.South, GoldenPathEnd);
            DiamondAlley.exits.Add(Direction.West, CobaltCave);
            CobaltCave.exits.Add(Direction.North, AbandonedOutpost);
            CobaltCave.exits.Add(Direction.East, DarknessDescent);
            CobaltCave.exits.Add(Direction.West, DiamondAlley);
            DarknessDescent.exits.Add(Direction.West, CobaltCave);
            DarknessDescent.exits.Add(Direction.East, Nightway);
            Nightway.exits.Add(Direction.West, DarknessDescent);
            Nightway.exits.Add(Direction.East, Necropolis);
            Nightway.exits.Add(Direction.North, Sea);
            Sea.exits.Add(Direction.South, Nightway);
            Sea.exits.Add(Direction.Down, DiamondAlley);
            AbandonedOutpost.exits.Add(Direction.South, CobaltCave);
            Necropolis.exits.Add(Direction.West, Nightway);
            Necropolis.exits.Add(Direction.North, MysteriousCove);
            Necropolis.exits.Add(Direction.East, TheLandOfTheEmptyDead);
            MysteriousCove.exits.Add(Direction.South, Necropolis);
            TheLandOfTheEmptyDead.exits.Add(Direction.North, SeaOfLostSouls);
            TheLandOfTheEmptyDead.exits.Add(Direction.West, Necropolis);
            TheLandOfTheEmptyDead.exits.Add(Direction.East, BarrenPath);
            BarrenWilds.exits.Add(Direction.East, Wildside);
            BarrenWilds.exits.Add(Direction.West, EmptyCave);
            Wildside.exits.Add(Direction.North, BarrenPath);
            Wildside.exits.Add(Direction.East, SharkPoolPrecipice);
            Wildside.exits.Add(Direction.South, TreacherousBridge);
            BarrenPath.exits.Add(Direction.North, CliffEdge);
            BarrenPath.exits.Add(Direction.South, Wildside);
            BarrenPath.exits.Add(Direction.East, TheShiningGates);
            BarrenPath.exits.Add(Direction.West, TheLandOfTheEmptyDead);
            SharkPoolPrecipice.exits.Add(Direction.West, Wildside);
            SharkPoolPrecipice.exits.Add(Direction.East, SharkPool);
            TheShiningGates.exits.Add(Direction.East, BarrenPath);
            TheShiningGates.exits.Add(Direction.West, TheEmeraldPlateau);
            TheEmeraldPlateau.exits.Add(Direction.North, Success);
            TheEmeraldPlateau.exits.Add(Direction.South, KingShark);
            TheEmeraldPlateau.exits.Add(Direction.West, TheShiningGates);
            TreacherousBridge.exits.Add(Direction.North, Wildside);
            TreacherousBridge.exits.Add(Direction.West, LockedDoor);
            TreacherousBridge.exits.Add(Direction.South, SidePath);
            TreacherousBridge.exits.Add(Direction.East, SharkPool);
            LockedDoor.exits.Add(Direction.West, TreacherousBridge);
            LockedDoor.exits.Add(Direction.East, eastWing);
            SidePath.exits.Add(Direction.North, TreacherousBridge);
            SidePath.exits.Add(Direction.East, HopeGarden);
            HopeGarden.exits.Add(Direction.North, SharkPool);
            HopeGarden.exits.Add(Direction.West, SidePath);
            HopeGarden.exits.Add(Direction.South, SilverSquare);
            SilverSquare.exits.Add(Direction.North, HopeGarden);
            SilverSquare.exits.Add(Direction.South, Minefield);
            Minefield.exits.Add(Direction.East, SharkLake);
            Minefield.exits.Add(Direction.North, SilverSquare);
            SilverSquare.exits.Add(Direction.West, SilverGate);
            SilverGate.exits.Add(Direction.East, SilverSquare);
            SilverGate.exits.Add(Direction.West, SilverWalkway2);
            SilverWalkway2.exits.Add(Direction.South, SharkLake);
            SilverWalkway2.exits.Add(Direction.West, SilverWalkway);
            SilverWalkway.exits.Add(Direction.East, SilverWalkway2);
            SilverWalkway.exits.Add(Direction.South, ImpWall);
            ImpWall.exits.Add(Direction.North, SilverWalkway);
            SilverWalkway.exits.Add(Direction.West, Crossroads);







            // add more (idea is 10 x 10 grid)
            // items
            //inventory
            // win condition implement
            // also how does the player get out? need an exit
            // obstacles
            //helping hands
            // random events?


            return main;
        }
        static void Main(string[] args)
        {
            Room currentRoom = Setup();

            for (;;)
            {
                Describe(currentRoom);
                Console.Write(">");
                string command = Console.ReadLine();
                Direction direction;
                if (Enum.TryParse<Direction>(command, out direction))
                {
                    Room destination;
                    if (currentRoom.exits.TryGetValue(direction, out destination))
                    {
                        currentRoom = destination;

                    }
                    else
                    {
                        Console.WriteLine("You cannot go that way.");
                    }
                }
                else if (command == "Quit")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("I don't understand.");
                    Console.WriteLine("Try {0}", string.Join(",", Enum.GetNames(typeof(Direction))) + ", or Quit");
                }
            }
        }
    }
}

























