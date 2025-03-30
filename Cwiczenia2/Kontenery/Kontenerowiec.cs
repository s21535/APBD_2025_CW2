namespace Cwiczenia2.Kontenery;

public class Kontenerowiec
{
    private List<Kontener> _containersList;
    private float _maximumSpeed;
    private int _maximumContainerCount;
    private float _maximumContainersLoadMass;

    public Kontenerowiec(float maximumSpeed, int maximumContainerCount, float maximumContainersLoadMass)
    {
        _maximumSpeed = maximumSpeed;
        _maximumContainerCount = maximumContainerCount;
        _maximumContainersLoadMass = maximumContainersLoadMass;
    }

    public void LoadContainer(Kontener kontener)
    {
        float currentMass = 0;
        int containersCount = 0;
        foreach (var kontenerX in _containersList)
        {
            currentMass += kontenerX.CargoMass + kontenerX.OwnMass;
            containersCount += 1;
        }

        if (currentMass > _maximumContainersLoadMass)
        {
            Console.WriteLine("Kontener przekracza ładowność kontenerowca.");
            return;
        }
        if (containersCount > _maximumContainerCount)
        {
            Console.WriteLine("Kontener przekracza ładowność kontenerowca.");
            return;
        }

        _containersList.Append(kontener);
        
    }
    
}