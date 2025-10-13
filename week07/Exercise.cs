using System;
using System.Collections.Generic;

public abstract class Exercise
{
    public DateTime ActivityDate;
    public int DurationMinutes;

    public Exercise(DateTime date, int durationMinutes)
    {
        ActivityDate = date;
        DurationMinutes = durationMinutes;
    }

    public abstract void DisplayDetails();
}







