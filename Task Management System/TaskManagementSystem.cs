namespace Task_Management_System;

public class TaskManagementSystem
{
    public Dictionary<int, Task> tasks = new Dictionary<int, Task>();

    public void AddTask(Task task)
    {
        tasks[task.TaskId] = task;
    }

    public List<Task> GetTasksByUser(int userId)
    {
        List<Task> userTasks = new List<Task>();
        foreach (var task in tasks.Values)
        {
            if (task.UserId == userId)
            {
                userTasks.Add(task);
            }
        }
        return userTasks;
    }

    public void UpdateTaskStatus(User user, Task task, Status status)
    {
        if (tasks.ContainsKey(task.TaskId) && tasks[task.TaskId].UserId == user.UserId)
        {
            tasks[task.TaskId].Status = status;
        }
    }

    public void DeleteTask(int userId, int taskId)
    {
        if (tasks.ContainsKey(taskId) && tasks[taskId].UserId == userId)
        {
            tasks.Remove(taskId);
        }
    }

    public void GetTasksByUserFilter(User user, Status status)
    {
        List<Task> userTasks = GetTasksByUser(user.UserId);
        var filteredTasks = userTasks.Where(task => task.Status == status).ToList();
        foreach (var task in filteredTasks)
        {
            Console.WriteLine($"TaskId: {task.TaskId}, Title: {task.Title}, Description: {task.Description}, DueDate: {task.DueDate}, Status: {task.Status}");
        }
    }
}
