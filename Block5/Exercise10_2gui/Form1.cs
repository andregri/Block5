using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercise10_2;

namespace Exercise10_2gui
{
    public partial class HideAndSeek : Form
    {
        int moves;
        Opponent opponent;
        Location currentLocation;

        Room diningRoom;
        Room stairs;
        RoomWithDoor kitchen;
        RoomWithDoor livingRoom;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;
        RoomWithHidingPlace bathroom;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveaway;

        public HideAndSeek()
        {
            InitializeComponent();
            InitializeGame();
            opponent = new Opponent(diningRoom);
            ResetGame(false);
        }

        public void InitializeGame()
        {
            // inside
            diningRoom = new Room("Dining Room", "a crystal chandelier");
            stairs = new Room("Stairs", "a wooden bannister");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "on top of fridge", "screen door");
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "under the sofa", "an oak door with a brass knob");
            hallway = new RoomWithHidingPlace("Upstairs hallway", "a picture of a dog", "in the closet");
            masterBedroom = new RoomWithHidingPlace("Master Bedroom", "a large bed", "under the bed");
            secondBedroom = new RoomWithHidingPlace("Second Bedroom", "a small bad", "under the bed");
            bathroom = new RoomWithHidingPlace("Bathroom", "a sink and a toilette", "in the shower");

            // outside
            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back Yard", true, "screen door");
            garden = new OutsideWithHidingPlace("Garden", false, "in the sheed");
            driveaway = new OutsideWithHidingPlace("Driveaway", false, "in the garage");

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

        private void MoveToANewLocation(Location locationToMove)
        {
            moves++;
            currentLocation = locationToMove;
            RedrawForm();
        }

        private void RedrawForm()
        {
            exitsComboBox.Items.Clear();
            foreach (Location exit in currentLocation.Exits)
                exitsComboBox.Items.Add(exit.Name);
            exitsComboBox.SelectedIndex = 0;

            descriptionTextBox.Text = currentLocation.Description + "\r\nCurrent Move: " + moves + ".";
            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                checkButton.Text = "Check " + hidingPlace.HidingPlaceName;
                checkButton.Visible = true;
            }
            else
                checkButton.Visible = false;

            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoorButton.Visible = true;
            else
                goThroughTheDoorButton.Visible = false;
        }

        private void ResetGame(bool pippo)
        {
            if (pippo)
            {
                MessageBox.Show("You found me!");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                descriptionTextBox.Text = "You found your opponent in " + moves + " moves!He was in the " + currentLocation.Name;
            }

            moves = 0;
            hideButton.Visible = true;
            goHereButton.Visible = false;
            checkButton.Visible = false;
            goThroughTheDoorButton.Visible = false;
            exitsComboBox.Visible = false;
        }

        private void goHereButton_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exitsComboBox.SelectedIndex]);
        }

        private void goThroughTheDoorButton_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }

        private void hideButton_Click(object sender, MouseEventArgs e)
        {
            hideButton.Visible = false;
            for (int i = 0; i <= 20; i++)
            {
                opponent.Move();
                descriptionTextBox.Text = i + "...";
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
            }

            descriptionTextBox.Text = "I'm coming";
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);
            goHereButton.Visible = true;
            exitsComboBox.Visible = true;
            MoveToANewLocation(livingRoom);
        }

        private void checkButton_Click(object sender, MouseEventArgs e)
        {
            moves++;
            if (opponent.Check(currentLocation))
                ResetGame(true);
            else
                RedrawForm();
        }
    }
}
