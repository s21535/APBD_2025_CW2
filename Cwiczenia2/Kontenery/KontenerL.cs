namespace Cwiczenia2.Kontenery;

public class KontenerL : Kontener, IHazardNotifier
{
    private bool _hasHazardCargo;
    private static int _Number = 0;
    
    public KontenerL(float ownMass, float maximumLoadMass, float height, float depth, bool hasHazardCargo)
    {
        _Number += 1;
        SerialNumber = string.Concat("KON","-","L","-",_Number);
        OwnMass = ownMass;
        MaximumLoadMass = maximumLoadMass;
        Height = height;
        Depth = depth;
        _hasHazardCargo = hasHazardCargo;
    }

    public void EmergencyNotification()
    {
        Console.WriteLine("Dangerous Incident at container: " + SerialNumber);
    }

    protected override void LoadCargo(float mass)
    {
        if (_hasHazardCargo && (mass + CargoMass > (MaximumLoadMass/2)))
        {
            EmergencyNotification();
        }
        else if (!_hasHazardCargo && (mass + CargoMass > MaximumLoadMass * 0.9f))
        {
            EmergencyNotification();
        }
        else
        {
            CargoMass += mass;
        }
    }
}