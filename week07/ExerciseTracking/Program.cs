using System;

class Program
{
    static void Main(string[] args)
    {
  
        // Create a list of activities
        List<Activity> activities = new List<Activity>
        {
            new Running("October 2025", 30, 3.0),
            new StationaryBicycling("October 2025", 30, 9.7),
            new Swimming("October 2025", 30, 20)
        };

        // Loop through and display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}









// using System;

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         List<Exercise> exercises = new List<Exercise>();

//         exercises.Add(new Running(new DateTime(2025, 10, 10), 45, 7.5));
//         exercises.Add(new StationaryBicycle(new DateTime(2025, 10, 11), 60, 25.0));
//         exercises.Add(new Swimming(new DateTime(2025, 10, 12), 30, 20));
//         exercises.Add(new Running(new DateTime(2025, 10, 13), 50, 8.0));

//         Console.WriteLine("--- Exercise Log ---");
//         foreach (var exercise in exercises)
//         {
//             exercise.DisplayDetails(); // Polymorphism in action
//         }
//     }
// }


