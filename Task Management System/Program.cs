namespace Task_Management_System;

public class Program
{
    public static void Main()
    {
        TaskManagementSystem taskManagementSystem = new TaskManagementSystem();

        // menambahkan user
        User user1 = new User { UserId = 1, Name = "John Doe" };
        User user2 = new User { UserId = 2, Name = "Jane Doe" };

        // menamhkan task
        Task task1 = new Task(1, user1.UserId, "Task 1", "Description 1", new DateTime(2021, 10, 1), Status.Pending);
        Task task2 = new Task(2, user1.UserId, "Task 2", "Description 2", new DateTime(2021, 10, 2), Status.Pending);
        Task task3 = new Task(3, user2.UserId, "Task 3", "Description 3", new DateTime(2021, 10, 3), Status.Pending);
        Task task4 = new Task(4, user1.UserId, "Task 4", "Description 4", new DateTime(2021, 10, 4), Status.Pending);

        taskManagementSystem.AddTask(task1);
        taskManagementSystem.AddTask(task2);
        taskManagementSystem.AddTask(task3);
        taskManagementSystem.AddTask(task4);

        taskManagementSystem.GetTasksByUser(user1.UserId).ForEach(task =>
        {
            Console.WriteLine($"TaskId: {task.TaskId}, Title: {task.Title}, Description: {task.Description}, DueDate: {task.DueDate}, Status: {task.Status}");
        });

        taskManagementSystem.UpdateTaskStatus(user1, task1, Status.Completed);

        Console.WriteLine("After updating task status:");

        taskManagementSystem.GetTasksByUser(user1.UserId).ForEach(task =>
        {
            Console.WriteLine($"TaskId: {task.TaskId}, Title: {task.Title}, Description: {task.Description}, DueDate: {task.DueDate}, Status: {task.Status}");
        });
        
        Console.WriteLine("");

        Console.WriteLine("Tasks by user filter Completed:");
        taskManagementSystem.GetTasksByUserFilter(user1, Status.Completed);

        Console.WriteLine("Tasks by user filter Pending:");
        taskManagementSystem.GetTasksByUserFilter(user1, Status.Pending);
    }
}