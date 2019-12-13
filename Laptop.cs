/*1. differen type of class abstract, virtual*/
// using System;

// public abstract class Laptop
// {
//     public virtual void TurnOn()
//     {
//         Console.WriteLine("Turning On.");
//     }
//     public void TurnOff()
//     {
//         Console.WriteLine("Truning Off.");
//     }
//     public abstract bool TouchScreen {get;}
// }

/*
*   you also can use every thing in abstract like:
*
*   public abstract class Laptop
*    {
*        public abstract void TurnOn();
*        public abstract void TurnOff();
*        public abstract bool TouchScreen {get;}
*    }
*
*    but is much better you use interface.
*/
/*2. interface */
using System;

public interface Laptop
{
    void TurnOn();
    void TurnOff();
    bool TouchScreen {get;}
}
