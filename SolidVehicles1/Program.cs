using System;
using System.Linq;
using System.Collections.Generic;
public interface IVehicle
{
    string Name { get; set; }
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    double EngineVolume { get; set; }

    void Start();
    void Stop();
}

public interface IWaterVehicle : IVehicle
{
    double MaxWaterSpeed { get; set; }

    void Drive();
}

public interface ILandVehicle : IVehicle
{
    double MaxLandSpeed { get; set; }
    int Wheels { get; set; }
    string TransmissionType { get; set; }

    void Drive();
}

public interface IAirVehicle : IVehicle
{
    double MaxAirSpeed { get; set; }
    bool Winged { get; set; }

    void Fly();
}


public class JetSki : IWaterVehicle
{
    public string Name { get; set; } = "Jetski";
    public int Doors { get; set; } = 0;
    public int PassengerCapacity { get; set; } = 2;
    public double EngineVolume { get; set; } = 1;
    public double MaxWaterSpeed { get; set; } = 100;

    public void Drive()
    {
        Console.WriteLine("The jetski zips through the waves with the greatest of ease");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }
    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class SpeedBoat : IWaterVehicle
{
    public string Name { get; set; } = "SpeedBoat";
    public int Doors { get; set; } = 1;
    public int PassengerCapacity { get; set; } = 8;
    public double EngineVolume { get; set; } = 2;
    public double MaxWaterSpeed { get; set; } = 150;

    public void Drive()
    {
        Console.WriteLine("The speedboat zips through the waves with the greatest of ease");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }
    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Canoe : IWaterVehicle
{
    public string Name { get; set; } = "Canoe";
    public int Doors { get; set; } = 0;
    public int PassengerCapacity { get; set; } = 1;
    public double EngineVolume { get; set; } = 0;
    public double MaxWaterSpeed { get; set; } = 10;

    public void Drive()
    {
        Console.WriteLine("The canoe strolls through the waves with the greatest of ease");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }
    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Motorcycle : ILandVehicle
{
    public string Name { get; set; } = "Moto";
    public int Wheels { get; set; } = 2;
    public int Doors { get; set; } = 0;
    public int PassengerCapacity { get; set; } = 2;
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 1.3;
    public double MaxLandSpeed { get; set; } = 160.4;

    public void Drive()
    {
        Console.WriteLine("The motorcycle screams down the highway");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Hummer : ILandVehicle
{
    public string Name { get; set; } = "Hummer";
    public int Wheels { get; set; } = 4;
    public int Doors { get; set; } = 4;
    public int PassengerCapacity { get; set; } = 5;
    public string TransmissionType { get; set; } = "Automatic";
    public double EngineVolume { get; set; } = 2.5;
    public double MaxLandSpeed { get; set; } = 140.0;

    public void Drive()
    {
        Console.WriteLine("The Hummer speeds down the desert");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Ferrari : ILandVehicle
{
    public string Name { get; set; } = "Ferrari";
    public int Wheels { get; set; } = 4;
    public int Doors { get; set; } = 2;
    public int PassengerCapacity { get; set; } = 2;
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 5.6;
    public double MaxLandSpeed { get; set; } = 200.4;

    public void Drive()
    {
        Console.WriteLine("The ferrari screams down the highway");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Cessna : IAirVehicle
{
    public string Name { get; set; } = "Cessna";
    public int Wheels { get; set; } = 3;
    public int Doors { get; set; } = 3;
    public int PassengerCapacity { get; set; } = 113;
    public bool Winged { get; set; } = true;
    public string TransmissionType { get; set; } = "None";
    public double EngineVolume { get; set; } = 31.1;
    public double MaxAirSpeed { get; set; } = 309.0;


    public void Fly()
    {
        Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class FlyingCar : IAirVehicle
{
    public string Name { get; set; } = "Flying Car";
    public int Wheels { get; set; } = 4;
    public int Doors { get; set; } = 4;
    public int PassengerCapacity { get; set; } = 2;
    public bool Winged { get; set; } = true;
    public double EngineVolume { get; set; } = 45.1;
    public double MaxAirSpeed { get; set; } = 344.0;

    public void Fly()
    {
        Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Helicopter : IAirVehicle
{
    public string Name { get; set; } = "Helicopter";
    public int Wheels { get; set; } = 0;
    public int Doors { get; set; } = 2;
    public int PassengerCapacity { get; set; } = 4;
    public bool Winged { get; set; } = false;
    public double EngineVolume { get; set; } = 31.1;
    public double MaxAirSpeed { get; set; } = 250.0;

    public void Fly()
    {
        Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Program
{
    public static void Main()
    {

        // Build a collection of all vehicles that fly
        List<IAirVehicle> allAirVehicles = new List<IAirVehicle>();
        allAirVehicles.Add(new Cessna());
        allAirVehicles.Add(new FlyingCar());
        allAirVehicles.Add(new Helicopter());
        Console.WriteLine("Here are all the vehicles that can fly:");

        foreach (var airVehicle in allAirVehicles)
        {
            Console.WriteLine(airVehicle.Name);
        }
        // With a single `foreach`, have each road vehicle Drive()
        List<ILandVehicle> allLandVehicles = new List<ILandVehicle>();
        allLandVehicles.Add(new Motorcycle());
        allLandVehicles.Add(new Hummer());
        allLandVehicles.Add(new Ferrari());
        foreach (var landVehicle in allLandVehicles)
        {
            landVehicle.Drive();
        }


        // Build a collection of all vehicles that operate on water
        List<IWaterVehicle> allWaterVehicles = new List<IWaterVehicle>();
        allWaterVehicles.Add(new JetSki());
        allWaterVehicles.Add(new SpeedBoat());
        allWaterVehicles.Add(new Canoe());
        // With a single `foreach`, have each water vehicle Drive()
        foreach (var waterVehicle in allWaterVehicles)
        {
            waterVehicle.Drive();
        }
        Console.ReadLine();
    }
}
