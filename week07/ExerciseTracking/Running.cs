using System;

public class Running : Activity
{
    private double _distance; // miles

    public Running(string date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (_distance / GetMinutes()) * 60;

    public override double GetPace() => GetMinutes() / _distance;
}




// public class Running : Exercise
// {
//     public double DistanceMiles;

//     public Running(DateTime date, int durationMinutes, double distanceMiles)
//         : base(date, durationMinutes)
//     {
//         DistanceMiles = distanceMiles;
//     }

//     public override void DisplayDetails()
//     {
//         Console.WriteLine($"Running on {ActivityDate.ToShortDateString()} for {DurationMinutes} minutes. Distance: {DistanceMiles} miles.");
//     }
// }




