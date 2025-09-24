using VehicleLibrary.Library;

class Program
{
    static void Main(string[] args)
    {
        var vehicles = new List<Vehicle>
        {
            new Car("Toyota", 1998, 2),
            new Bicycle("Giant", 2025, true)
        };
        
        foreach (var vehicle in vehicles)
        {
            if ( vehicle is Car car)
            Console.WriteLine($"Vehicle: {vehicle.GetType().Name}, Brand: {car.Brand}, Year: {car.Year}, Max Speed: {car.MaxSpeed()} km/h, Doors: {car.NumberOfDoor}");
            
            else if (vehicle is Bicycle bicycle)
            Console.WriteLine($"Vehicle: {vehicle.GetType().Name}, Brand: {bicycle.Brand}, Year: {bicycle.Year}, Max Speed: {bicycle.MaxSpeed()} km/h, Has Gear: {bicycle.HasGear}");
        }
    }
}