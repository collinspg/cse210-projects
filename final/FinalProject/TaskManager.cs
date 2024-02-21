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
        tasks.Add(task);
    }

    public void DisplayAllTasks()
    {
        foreach (var task in tasks)
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
        Task taskToUpdate = tasks.Find(t => t.Title.Equals(title));
        if (taskToUpdate != null)
        {
            taskToUpdate.Title = updatedTask.Title;
            taskToUpdate.Description = updatedTask.Description;
            taskToUpdate.Deadline = updatedTask.Deadline;
            taskToUpdate.Priority = updatedTask.Priority;
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
        switch (sortOption)
        {
            case 1:
                tasks = tasks.OrderBy(t => t.Priority).ToList();
                break;
            case 2:
                tasks = tasks.OrderBy(t => t.Deadline).ToList();
                break;
            default:
                break;
        }
    }

    public List<Task> FilterTasks(int filterOption)
    {
        List<Task> filteredTasks = new List<Task>();

        switch (filterOption)
        {
            case 1:
                filteredTasks = tasks.Where(t => t.Priority.Equals("High")).ToList();
                break;
            case 2:
                filteredTasks = tasks.Where(t => t.Deadline.Date == DateTime.Now.Date).ToList();
                break;
            default:
                break;
        }

        return filteredTasks;
    }
}