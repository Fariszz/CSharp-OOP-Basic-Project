namespace Task_Management_System;

public class Task
{
    public int TaskId { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public Status Status { get; set; }

    public Task(int taskId, int userId, string title, string description, DateTime dueDate, Status status)
    {
        TaskId = taskId;
        UserId = userId;
        Title = title;
        Description = description;
        DueDate = dueDate;
        Status = status;
    }
}
