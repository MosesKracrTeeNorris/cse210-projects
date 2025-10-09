using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Eternal Quest Program!");
        Console.WriteLine("Track your goals, earn points, and stay motivated on your Eternal Quest.\n");

        GoalManager manager = new GoalManager();
        manager.Start();
    }
}