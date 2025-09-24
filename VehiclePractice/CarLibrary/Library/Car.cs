namespace VehicleLibrary.Library
{
    public class Car : Vehicle
    {
        public int NumberOfDoor { get; set; }

        public Car (string brand, int year, int numberofdoors) : base (brand,year)
        {
            NumberOfDoor = numberofdoors;
        }

        public override int MaxSpeed()
        {
            return 180;
        }
    }
}
