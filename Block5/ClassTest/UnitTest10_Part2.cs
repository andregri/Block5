using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise10_2;

namespace ClassTest
{
    [TestClass]
    public class UnitTest10_Part2
    {
        [TestMethod]
        public void TestPart1()
        {
            // inside
            Room diningRoom = new Room("Dining Room", "a crystal chandelier");
            Room stairs = new Room("Stairs", "a wooden bannister");
            RoomWithDoor kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "on top of fridge", "screen door");
            RoomWithDoor livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "under the sofa", "an oak door with a brass knob");
            RoomWithHidingPlace hallway = new RoomWithHidingPlace("Upstairs hallway", "a picture of a dog", "in the closet");
            RoomWithHidingPlace masterBedroom = new RoomWithHidingPlace("Master Bedroom", "a large bed", "under the bed");
            RoomWithHidingPlace secondBedroom = new RoomWithHidingPlace("Second Bedroom", "a small bad", "under the bed");
            RoomWithHidingPlace bathroom = new RoomWithHidingPlace("Bathroom", "a sink and a toilette", "in the shower");

            // outside
            OutsideWithDoor frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            OutsideWithDoor backYard = new OutsideWithDoor("Back Yard", true, "screen door");
            OutsideWithHidingPlace garden = new OutsideWithHidingPlace("Garden", false, "in the sheed");
            OutsideWithHidingPlace driveaway = new OutsideWithHidingPlace("Driveaway", false, "in the garage");

            diningRoom.Exits = new Location[] { livingRoom, kitchen };

            kitchen.Exits = new Location[] { diningRoom };
            kitchen.DoorLocation = backYard;

            livingRoom.Exits = new Location[] { diningRoom, stairs };
            livingRoom.DoorLocation = frontYard;

            stairs.Exits = new Location[] { livingRoom, hallway };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            bathroom.Exits = new Location[] { hallway };
            masterBedroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };

            garden.Exits = new Location[] { backYard, frontYard };
            driveaway.Exits = new Location[] { backYard, frontYard };

            frontYard.Exits = new Location[] { garden, backYard, driveaway };
            frontYard.DoorLocation = livingRoom;

            backYard.Exits = new Location[] { garden, frontYard, driveaway };
            backYard.DoorLocation = kitchen;
        }
    }
}
