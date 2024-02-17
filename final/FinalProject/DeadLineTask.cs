// DeadlineTask.cs
using System;

public class DeadlineTask : Task
{
    public DeadlineTask(string title, string description, DateTime deadline, string priority)
        : base(title, description, deadline, priority)
    {
      
    }
}
