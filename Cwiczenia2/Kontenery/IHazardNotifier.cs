namespace Cwiczenia2.Kontenery;

public interface IHazardNotifier
{
    protected virtual void EmergencyNotification()
    {
        Console.WriteLine("Emergency Notification!");
    }
}