using System;

public class Task
{
    private string title;
    private string description;
    private DateTime deadline;
    private string priority;

    public string Title { get => title; set => title = value; }
    public string Description { get => description; set => description = value; }
    public DateTime Deadline { get => deadline; set => deadline = value; }
    public string Priority { get => priority; set => priority = value; }

    public Task(string title, string description, DateTime deadline, string priority)
    {
        Title = title;
        Description = description;
        Deadline = deadline;
        Priority = priority;
    }

    public virtual void DisplayTaskDetails()
    {
        Console.WriteLine($"Task: {Title}\nDescription: {Description}\nDeadline: {Deadline}\nPriority: {Priority}");
    }
}

