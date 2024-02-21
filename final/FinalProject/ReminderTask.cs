using System;

public class ReminderTask : Task
{
    public ReminderTask(string title, string description, DateTime deadline, string priority)
        : base(title, description, deadline, priority)
    {
        
    }
}

