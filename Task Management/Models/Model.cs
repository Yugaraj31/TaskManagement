namespace TaskManagementAPI;

public enum Role { Admin, User, Manager }

//User table
public class Users
{
    public int Id { get; set; }
    public string Username { get; set; }
    public Role Role { get; set; }
}

//TaskItems table
public class TaskItems
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int AssignedUserId { get; set; }
}

//TaskComments table
public class TaskComments
{
    public int Id { get; set; }
    public string Comment { get; set; }
    public int TaskItemId { get; set; }
    public int UserId { get; set; }
}

//UserLogin table
public class UserLogin
{
    public string Username { get; set; }
    public string Password { get; set; }
}
