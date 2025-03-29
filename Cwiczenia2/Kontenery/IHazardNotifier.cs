namespace Cwiczenia2.Kontenery;

public interface IHazardNotifier
{
    protected void EmergencyNotification()
    {
        Console.WriteLine("Emergency Notification!");
    }
}