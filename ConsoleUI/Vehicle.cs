using System;

namespace ConsoleUI;

public abstract class Vehicle
{
    public string Year { get; set; } = "GenericOne";
    public string Make { get; set; } = "GenericTwo";
    public string Model { get; set; } = "GenericThree";

    public abstract void DriveAbstract();

    public virtual void DriveVirtual()
    {
        Console.WriteLine("Default Console");
    }
}