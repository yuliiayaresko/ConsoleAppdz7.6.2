using System;

class Program
{
    static void Main(string[] args)
    {
        
        Traveler traveler = new Traveler();
        
        Car car = new Car();
        
        traveler.Travel(car);
       
        Boat boat = new Boat();
        
        ITransport boatTransport = new BoatToTransportAdapter(boat);
        
        traveler.Travel(boatTransport);

        Console.Read();
    }
}


interface ITransport
{
    void Drive();
}


class Car : ITransport
{
    public void Drive()
    {
        Console.WriteLine("Автомобіль їде по дорозі");
    }
}


class Traveler
{
    public void Travel(ITransport transport)
    {
        transport.Drive();
    }
}


interface IWaterTransport
{
    void Sail();
}


class Boat : IWaterTransport
{
    public void Sail()
    {
        Console.WriteLine("Човен пливе по воді");
    }
}


class BoatToTransportAdapter : ITransport
{
    private Boat boat;

    public BoatToTransportAdapter(Boat b)
    {
        boat = b;
    }

    public void Drive()
    {
        boat.Sail();
    }
}
