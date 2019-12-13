/*1. for abstract */
// using System;

// public class AsusZenbook : Laptop
// {
//     public override bool TouchScreen => false;

//     public override void TurnOn(){
//         Console.WriteLine("Turning On specific to AsusZenbook");
//     }
// }

/*2. for interface */
using System;

public class AsusZenbook : Laptop
{
    public bool TouchScreen => false;

    public void TurnOff()
    {
        Console.WriteLine("Turning off AsusZenbook");
    }

    public void TurnOn()
    {
        Console.WriteLine("Turning on AsusZenbook");
    }
}