/*1. for abstract */
// using System;

// public class MacbookAir : Laptop
// {
//     public override bool TouchScreen => false;
// }

/*2. for interface */
using System;

public class MacbookAir : Laptop
{
    public bool TouchScreen => false;

    public void TurnOff()
    {
        Console.WriteLine("Turning off MacbookAir");
    }

    public void TurnOn()
    {
        Console.WriteLine("Turning on MacbookAir");
    }
}