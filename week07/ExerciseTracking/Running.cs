public class Running : Exercise
{
    public double DistanceMiles;

    public Running(DateTime date, int durationMinutes, double distanceMiles)
        : base(date, durationMinutes)
    {
        DistanceMiles = distanceMiles;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Running on {ActivityDate.ToShortDateString()} for {DurationMinutes} minutes. Distance: {DistanceMiles} miles.");
    }
}




