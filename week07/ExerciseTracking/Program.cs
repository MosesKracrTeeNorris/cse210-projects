public class Program
{
    public static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>();

        exercises.Add(new Running(new DateTime(2025, 10, 10), 30, 3.5));
        exercises.Add(new StationaryBicycle(new DateTime(2025, 10, 11), 45, 18.2));
        exercises.Add(new Swimming(new DateTime(2025, 10, 12), 60, 40));
        exercises.Add(new Running(new DateTime(2025, 10, 13), 25, 2.8));

        Console.WriteLine("--- Exercise Log ---");
        foreach (Exercise exercise in exercises)
        {
            exercise.DisplayDetails(); // Polymorphic call
        }
    }
}






// using System;

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





// public class Program
// {
//     public static void Main(string[] args)
//     {
//         List<Exercise> exercises = new List<Exercise>();

//         exercises.Add(new Running("2025-10-12", TimeSpan.FromMinutes(45), 7.5));
//         exercises.Add(new StationaryBicycle("2025-10-11", TimeSpan.FromMinutes(60), 8));
//         exercises.Add(new Swimming("2025-10-10", TimeSpan.FromMinutes(30), 20, "Freestyle"));
//         exercises.Add(new Running("2025-10-09", TimeSpan.FromMinutes(30), 5.0));

//         Console.WriteLine("--- Exercise Log ---");
//         foreach (var exercise in exercises)
//         {
//             exercise.DisplayDetails();
//             Console.WriteLine(); // Add a blank line for readability
//         }
//     }
// }







