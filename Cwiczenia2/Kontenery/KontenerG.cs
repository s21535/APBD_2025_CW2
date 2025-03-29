namespace Cwiczenia2.Kontenery;

public class KontenerG : Kontener,IHazardNotifier
{
    private float _pressure;
    private static int _Number = 0;
    
    public KontenerG(float ownMass, float maximumLoadMass, float height, float depth, float pressure)
    {
        _Number += 1;
        SerialNumber = string.Concat("KON","-","G","-",_Number);
        OwnMass = ownMass;
        MaximumLoadMass = maximumLoadMass;
        Height = height;
        Depth = depth;
        _pressure = pressure;
    }
    
    public void EmergencyNotification()
    {
        Console.WriteLine("Dangerous Incident at container: " + SerialNumber);
    }
    
    protected override void LoadCargo(float mass)
    {
        if (mass + CargoMass > (MaximumLoadMass))
        {
            EmergencyNotification();
        }
        else
        {
            CargoMass += mass;
        }
    }

    protected void UnloadCargo()
    {
        CargoMass = CargoMass * 0.05f;
    }
    
}