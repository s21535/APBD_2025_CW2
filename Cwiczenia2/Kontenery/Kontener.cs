namespace Cwiczenia2.Kontenery;

public abstract class Kontener
{
    public float CargoMass {get;protected set;}
    public float OwnMass {get;protected set;}
    protected float MaximumLoadMass {get;set;}
    protected float Height {get;set;}
    protected float Depth {get;set;}

    protected string SerialNumber
    {
        get
        {
            return SerialNumber;
        }
        set
        {
            if (SerialNumber != null)
            {
                return;
            }
            else
            {
                SerialNumber = value;
            }
        }
    }

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