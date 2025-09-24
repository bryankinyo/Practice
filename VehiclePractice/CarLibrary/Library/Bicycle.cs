namespace VehicleLibrary.Library
{
    public class Bicycle : Vehicle
    {
        public bool HasGear { get; set; }
        public Bicycle(string brand, int year, bool hasGear) : base (brand, year)
        {
            HasGear = hasGear;
        }

        public override int MaxSpeed()
        {
            return 90;
        }
    }
}
