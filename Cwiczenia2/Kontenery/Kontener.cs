namespace Cwiczenia2.Kontenery;

public abstract class Kontener
{
    protected float CargoMass {get;set;}
    protected float OwnMass {get;set;}
    protected float MaximumLoadMass {get;set;}
    protected float Height {get;set;}
    protected float Depth {get;set;}
    protected virtual string SerialNumber { get; set; }

    protected virtual void UnloadCargo()
    {
        CargoMass = 0;
    }

    protected virtual void LoadCargo(float mass)
    {
        if ((mass + CargoMass <= MaximumLoadMass))
        {
            throw new Exception("OverfillException");
        }
    }
}