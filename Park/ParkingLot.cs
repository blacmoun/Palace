namespace Park
{
    public class ParkingLot
    {
        public void Park(Vehicle vehicle)
        {
            Console.WriteLine($"Step 1 : [{GetType().Name}] put vehicle into parkedVehicle");
            double size = vehicle.Size;
        }
    }
}
