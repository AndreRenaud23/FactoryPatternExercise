using FactoryPatternExercise;

Console.WriteLine("How many wheels would you like your vehicle have? (two/four)");

var answer = Console.ReadLine();

VehicleFactory setter = new VehicleFactory();

IVehicle vehicle = setter.GetVehicle(answer);

vehicle.Drive();
