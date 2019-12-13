// refer: https://www.youtube.com/watch?v=0xBRJfl95MU&list=PLylgIRlJtHWRqlr1gtx3UgWXIzFS2ms9N&index=3
using System;

namespace OPP_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop macbookAir = new MacbookAir();
            Laptop asusZenbook = new AsusZenbook();

            macbookAir.TurnOn();
            macbookAir.TurnOff();

            asusZenbook.TurnOn();
            asusZenbook.TurnOff();

            Console.WriteLine(macbookAir.TouchScreen);
            Console.WriteLine(asusZenbook.TouchScreen);
        }
    }
}

/* no changes for interface & abstract */