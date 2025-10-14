using System;

class Program
{
    static void Main(string[] args)
    {
  
        // Create a list of activities
        List<Activity> activities = new List<Activity>
        {
            new Running("2025", 30, 3.0),
            new Cycling("2025", 30, 9.7),
            new Swimming("2025", 30, 20)
        };

        // Loop through and display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}















// public class Program
// {
//     public static void Main(string[] args)
//     {
//         List<Exercise> exercises = new List<Exercise>();

//         exercises.Add(new Running(new DateTime(2025, 10, 10), 30, 3.5));
//         exercises.Add(new StationaryBicycle(new DateTime(2025, 10, 11), 45, 18.2));
//         exercises.Add(new Swimming(new DateTime(2025, 10, 12), 60, 40));
//         exercises.Add(new Running(new DateTime(2025, 10, 13), 25, 2.8));

//         Console.WriteLine("--- Exercise Log ---");
//         foreach (Exercise exercise in exercises)
//         {
//             exercise.DisplayDetails(); // Polymorphic call
//         }
//     }
// }