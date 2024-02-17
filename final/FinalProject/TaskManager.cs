using System;
using System.Collections.Generic;
using System.Linq;

public class TaskManager
{
    private List<Task> tasks;

    public TaskManager()
    {
        tasks = new List<Task>();
    }

    public void AddTask(Task task)
    {
        // Work-in-progress: Implementing Task addition
    }

    public void DisplayAllTasks()
    {
        // Work-in-progress: Implementing Task display
        {
            task.DisplayTaskDetails();
            Console.WriteLine();
        }
    }

    public List<Task> GetTasks()
    {
        return tasks;
    }

    public void UpdateTask(string title, Task updatedTask)
    {
        // Work-in-progress: Implementing Task update
        {
           // Work-in-progress: Implementing Task update
        }
    }

    public void DeleteTask(string title)
    {
        Task taskToDelete = tasks.Find(t => t.Title.Equals(title));
        if (taskToDelete != null)
        {
            tasks.Remove(taskToDelete);
        }
    }

    public void SortTasks(int sortOption)
    {
       // Work-in-progress: Implementing Task sorting
        {
           // Work-in-progress: Implementing Task sorting
        }
    }

    public List<Task> FilterTasks(int filterOption)
    {
        // Work-in-progress: Implementing Task filtering
        {
            // Work-in-progress: Implementing Task filtering
        }

       // Work-in-progress: Implementing Task filtering
    }
}
