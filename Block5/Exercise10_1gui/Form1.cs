using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercise10_1;

namespace Exercise10_1gui
{
    public partial class ExploreTheHouseForm : Form
    {
        HouseMove houseMove;
        Room diningRoom;
        RoomWithDoor kitchen;
        RoomWithDoor livingRoom;
        Outside garden;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;

        public ExploreTheHouseForm()
        {
            InitializeComponent();
            InitializeRoom();
            MoveToANewLocation(diningRoom);
        }

        private void InitializeRoom()
        {
            diningRoom = new Room("Dining Room", "a crystal chandelier");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "screen door");
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob");
            garden = new Outside("Garden", false);
            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back Yard", true, "screen door");

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

            houseMove = new HouseMove(diningRoom);
        }

        private void MoveToANewLocation(Location place)
        {
            houseMove.MoveToANewLocation(place);
            exitsComboBox.Items.Clear();
            foreach (Location exit in houseMove.CurrentLocation.Exits)
                exitsComboBox.Items.Add(exit.Name);
            exitsComboBox.SelectedIndex = 0;

            descriptionTextBox.Text = houseMove.CurrentLocation.Description;
            if (houseMove.CurrentLocation is IHasExteriorDoor)
                goThroughTheDoorButton.Visible = true;
            else
                goThroughTheDoorButton.Visible = false;
        }

        private void goHereButton_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(houseMove.CurrentLocation.Exits[exitsComboBox.SelectedIndex]);
        }

        private void goThroughTheDoorButton_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = houseMove.CurrentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }
    }
}
