# OOP-inheritance-with-CSharp
refer from  AvetisG Programming

reference: https://www.youtube.com/watch?v=cL0OftSZ7V8&list=PLylgIRlJtHWRqlr1gtx3UgWXIzFS2ms9N

Inheritance:
----------------

- abstract
- interface

# Abstract Inheritance

#1. create 3 diff cs file on the working folder
-------------------------------------------

- Laptop.cs
------------

this class is ready to inherited by other class.
 
code:

```

using System;

public abstract class Laptop
{
    public virtual void TurnOn()
    {
        Console.WriteLine("Turning On.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Truning Off.");
    }

    public abstract bool TouchScreen {get;}
}

```

explain:

```

public virtual void TurnOn()
    {
        Console.WriteLine("Turning On.");
    }

```

**virtual** mean you can get this method and override it

 
```

  public abstract bool TouchScreen {get;}

```

**This method abstract need to be mention after inherited by other class

- MacbookAir.cs
-------------

inheriting Laptop.cs class.

code:

```

using System;

public class MacbookAir : Laptop
{
    public override bool TouchScreen => false;
}


```

explain:

```

public override bool TouchScreen => false;

```

inherited Laptop and method TouchScreen has been mention.

- AsusZenbook.cs
---------------

inheriting Laptop.cs class.

code:

```

using System;

public class AsusZenbook : Laptop
{
    public override bool TouchScreen => false;
}

```

#2. At your Program.cs
------------------
code:

```

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


```

**result:**

Turning On.
Truning Off.
Turning On.
Truning Off.
False
False

#3. override function TurnOn()
--------------------------------

member this **virtual** method on Laptop.cs:

```

 public virtual void TurnOn()
    {
        Console.WriteLine("Turning On.");
    }

```

now made change in AsusZenbook.cs:


```

using System;

public class AsusZenbook : Laptop
{
    public override bool TouchScreen => false;

    public override void TurnOn(){
        Console.WriteLine("Turning On specific to AsusZenbook");
    }
}

``` 

in cmd type :dotnet run

**result:**
Turning On.
Truning Off.
Turning On specific to AsusZenbook
Truning Off.
False
False


#4. Continue to use interface (abstract vs interface)
--------------------------------------

you also can use everything with abstract key work like:
in Laptop.cs

```

 public abstract class Laptop
    {
        public abstract void TurnOn();
        public abstract void TurnOff();
        public abstract bool TouchScreen {get;}
    }



```

but is much better you use interface.
because more resourceful and easier so less resource required by CPU.
to be continue...

# Interface Inheritance
1. on .cs file change accordingly 
----------------------------------
- Laptop.cs

```

using System;

public interface Laptop
{
    void TurnOn();
    void TurnOff();
    bool TouchScreen {get;}
}

```

- MacbookAir.cs

```

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

```

- AsusZenbook.cs

```

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

```

2. result change from abstract to interface
-------------
in Program.cs (no change)

```
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

```

**result:**

Turning on MacbookAir
Turning off MacbookAir
Turning on AsusZenbook
Turning off AsusZenbook
False
False
