using System;
using System.Collections.Generic;

public class UserInterface
{
    public static void ShowMenu()
    {
        Console.WriteLine("1. Add Task");
        Console.WriteLine("2. Display Tasks");
        Console.WriteLine("3. Exit");
        Console.WriteLine("4. Update Task");
        Console.WriteLine("5. Delete Task");
        Console.WriteLine("6. Sort Tasks");
        Console.WriteLine("7. Filter Tasks");
    }

    public static Task GetUserInputForTask()
    {
        Console.Write("Enter Task Title: ");
        string title = Console.ReadLine();
        Console.Write("Enter Task Description: ");
        string description = Console.ReadLine();
        Console.Write("Enter Task Deadline (yyyy-MM-dd HH:mm:ss): ");
        DateTime deadline = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter Task Priority (High/Medium/Low): ");
        string priority = Console.ReadLine();

        return new Task(title, description, deadline, priority);
    }

    public static Task GetUserInputForUpdateTask()
    {
        Console.Write("Enter Task Title to Update: ");
        string title = Console.ReadLine();
        Console.Write("Enter Updated Task Description: ");
        string description = Console.ReadLine();
        Console.Write("Enter Updated Task Deadline (yyyy-MM-dd HH:mm:ss): ");
        DateTime deadline = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter Updated Task Priority (High/Medium/Low): ");
        string priority = Console.ReadLine();

        return new Task(title, description, deadline, priority);
    }

    public static string GetUserInputForDeleteTask()
    {
        Console.Write("Enter Task Title to Delete: ");
        return Console.ReadLine();
    }

    public static int GetUserInputForSortOption()
    {
        Console.WriteLine("1. Sort by Priority");
        Console.WriteLine("2. Sort by Deadline");
        Console.Write("Enter Sort Option: ");
        return int.Parse(Console.ReadLine());
    }

    public static int GetUserInputForFilterOption()
    {
        Console.WriteLine("1. Filter by Priority");
        Console.WriteLine("2. Filter by Deadline (Today)");
        Console.Write("Enter Filter Option: ");
        return int.Parse(Console.ReadLine());
    }

    public static void DisplayTaskDetailsWithPriority(Task task)
    {
        task.DisplayTaskDetails();
        Console.WriteLine();
    }
}

