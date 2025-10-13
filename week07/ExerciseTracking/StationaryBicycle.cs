public class StationaryBicycle : Exercise
{
    public double CyclingSpeedMPH;

    public StationaryBicycle(DateTime date, int durationMinutes, double cyclingSpeedMPH)
        : base(date, durationMinutes)
    {
        CyclingSpeedMPH = cyclingSpeedMPH;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Stationary Cycling on {ActivityDate.ToShortDateString()} for {DurationMinutes} minutes. Average Speed: {CyclingSpeedMPH} MPH.");
    }
}



// // Derived class for Stationary Bicycle
// public class StationaryBicycle : Exercise
// {
//     private int _resistanceLevel;

//     public StationaryBicycle(string date, TimeSpan duration, int resistanceLevel)
//         : base(date, duration)
//     {
//         _resistanceLevel = resistanceLevel;
//     }

//     public override void DisplayDetails()
//     {
//         Console.WriteLine($"Stationary Bicycle on {_date} for {_duration.TotalMinutes:F0} minutes.");
//         Console.WriteLine($"Resistance Level: {_resistanceLevel}.");
//     }
// }

















