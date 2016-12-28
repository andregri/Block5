using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise10_1;

namespace ClassTest
{
    [TestClass]
    public class UnitTest10
    {
        [TestMethod]
        public void TestPart1()
        {
            Room diningRoom = new Room("Dining Room", "a crystal chandelier");
            RoomWithDoor kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "screen door");
            RoomWithDoor livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob");
            Outside garden = new Outside("Garden", false);
            OutsideWithDoor frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            OutsideWithDoor backYard = new OutsideWithDoor("Back Yard", true, "screen door");

            diningRoom.Exits = new Location[] { livingRoom, kitchen };

            kitchen.Exits = new Location[] { diningRoom };
            kitchen.DoorLocation = backYard;

            livingRoom.Exits = new Location[] { diningRoom };
            livingRoom.DoorLocation = frontYard;

            garden.Exits = new Location[] { backYard, frontYard };

            frontYard.Exits = new Location[] { garden, backYard };
            frontYard.DoorLocation = livingRoom;

            backYard.Exits = new Location[] { garden, frontYard };
            backYard.DoorLocation = kitchen;
        }
    }
}
