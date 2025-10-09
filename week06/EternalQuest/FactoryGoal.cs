class GoalFactory
{
    public static Goal CreateGoalFromString(string line)
    {
        string[] parts = line.Split(":");
        string type = parts[0];
        string[] data = parts[1].Split(",");

        switch (type)
        {
            case "SimpleGoal":
                return new SimpleGoal(data[0], data[1], int.Parse(data[2])) 
                { 
                    // Store completion status
                };
            case "EternalGoal":
                return new EternalGoal(data[0], data[1], int.Parse(data[2]));
            case "ChecklistGoal":
                ChecklistGoal chg = new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[4]), int.Parse(data[5]));
                return chg;
            case "NegativeGoal":
                return new NegativeGoal(data[0], data[1], int.Parse(data[2]));
            default:
                throw new Exception("Unknown goal type.");
        }
    }
}