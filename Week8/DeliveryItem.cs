public abstract class DeliveryItem
{
    public string TrackingNumber{get; set;}
    public double Weight {get; set;}

    public DeliveryItem(string trackingNumber)
    {
        TrackingNumber = trackingNumber;
    }
    public abstract double CalculateCost();
    public virtual void PrintInfo()
    {
        Console.WriteLine($"Track number: {TrackingNumber}, weight: {Weight}");
    }
}