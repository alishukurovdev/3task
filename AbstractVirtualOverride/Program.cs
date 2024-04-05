namespace AbstractVirtualOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Car car = new Car("Land Rover", "Defender"," Black", 2.7, 5.4, 4, false);
            //car.GetInfo();
            //car.DefineNatureHarmness();
            //car.GetType();
            //car.AverageSpeed();
            //Console.WriteLine($"Average Speed: {car.AverageSpeed()} km/h");
            Bicycle bicycle = new Bicycle("Velosipet", "velos", "Red", 5, 3, "offroad");
            Vehicle[] vehicles = { car, bicycle };

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
                vehicle.GetInfo();
                vehicle.DefineNatureHarmness();
                Console.WriteLine();
            }
            Console.WriteLine($"Average Speed: {car.AverageSpeed()} km/h");
            Console.WriteLine($"Average Speed: {bicycle.AverageSpeed()} km/h");

        }
    }
}
