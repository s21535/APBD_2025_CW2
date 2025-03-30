namespace Cwiczenia2.Kontenery;

public class KontenerC<T> : Kontener
{
    private List<T> cargoList;
    private float _temperatue; 
    private static int _Number = 0;
    
    public KontenerC(float ownMass, float maximumLoadMass, float height, float depth)
    {
        _Number += 1;
        SerialNumber = string.Concat("KON","-","C","-",_Number);
        OwnMass = ownMass;
        MaximumLoadMass = maximumLoadMass;
        Height = height;
        Depth = depth;
    }
}