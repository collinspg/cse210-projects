class Program
{
    static void Main(string[] args)
    {
        TaskManager taskManager = new TaskManager();

        while (true)
        {
            UserInterface.ShowMenu();
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Task newTask = UserInterface.GetUserInputForTask();
                    taskManager.AddTask(newTask);
                    break;

                case 2:
                    taskManager.DisplayAllTasks();
                    break;

                case 3:
                    // Save tasks to a file before exiting
                    FileHandler.SaveTasksToFile(taskManager.GetTasks(), "tasks.txt");
                    return;

                case 4:
                    Console.WriteLine("Update Task:");
                    string updateTaskTitle = UserInterface.GetUserInputForDeleteTask();
                    Task updatedTask = UserInterface.GetUserInputForUpdateTask();
                    taskManager.UpdateTask(updateTaskTitle, updatedTask);
                    break;

                case 5:
                    Console.WriteLine("Delete Task:");
                    string deleteTaskTitle = UserInterface.GetUserInputForDeleteTask();
                    taskManager.DeleteTask(deleteTaskTitle);
                    break;

                case 6:
                    int sortOption = UserInterface.GetUserInputForSortOption();
                    taskManager.SortTasks(sortOption);
                    break;

                case 7:
                    int filterOption = UserInterface.GetUserInputForFilterOption();
                    List<Task> filteredTasks = taskManager.FilterTasks(filterOption);
                    foreach (var filteredTask in filteredTasks)
                    {
                        UserInterface.DisplayTaskDetailsWithPriority(filteredTask);
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
