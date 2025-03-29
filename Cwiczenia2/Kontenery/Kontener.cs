namespace Cwiczenia2.Kontenery;

public abstract class Kontener
{
    protected float CargoMass {get; private set;}
    protected float OwnMass {get; private set;}
    protected float MaximumLoadMass {get; private set;}
    protected float Height {get; private set;}
    protected float Depth {get;private set;}
    protected string SerialNumber {get;private set;}

    protected void UnloadCargo()
    {
        CargoMass = 0;
    }

    protected void LoadCargo(float mass)
    {
        if ((mass + CargoMass <= MaximumLoadMass))
        {
            throw new Exception("OverfillException");
        }
    }
}