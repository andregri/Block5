using System;

namespace Exercise10_2
{
    public class HouseMove 
    {
        public Location CurrentLocation { get; set; }

        public HouseMove(Location currentLocation) 
        {
            CurrentLocation = currentLocation;
        }

		public void MoveToANewLocation(Location newLocation)
		{
			CurrentLocation = newLocation;
		}

        public Location[] Exits
        {
            get { return CurrentLocation.Exits; }
        }

        void GoThroughExteriorDoor()
		{
            // create an instance of something that implements the interface allow us to 
            // distinguish between class "[...]WithDoor" and not 
            IHasExteriorDoor hasExitDoor = CurrentLocation as IHasExteriorDoor;
			if (hasExitDoor != null)
				MoveToANewLocation(CurrentLocation);
			else
				throw new ArgumentNullException("Sorry this place hasn't an Exterior Door");
		}
    }
}