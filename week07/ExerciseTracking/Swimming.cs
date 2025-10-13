public class Swimming : Exercise
{
    public int NumberOfLaps;

    public Swimming(DateTime date, int durationMinutes, int numberOfLaps)
        : base(date, durationMinutes)
    {
        NumberOfLaps = numberOfLaps;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Swimming on {ActivityDate.ToShortDateString()} for {DurationMinutes} minutes. Laps: {NumberOfLaps}.");
    }
}





// // Derived class for Swimming
// public class Swimming : Exercise
// {
//     private int _laps;
//     private string _stroke;

//     public Swimming(string date, TimeSpan duration, int laps, string stroke)
//         : base(date, duration)
//     {
//         _laps = laps;
//         _stroke = stroke;
//     }

//     public override void DisplayDetails()
//     {
//         Console.WriteLine($"Swimming on {_date} for {_duration.TotalMinutes:F0} minutes.");
//         Console.WriteLine($"Laps: {_laps}, Stroke: {_stroke}.");
//     }
// }




















