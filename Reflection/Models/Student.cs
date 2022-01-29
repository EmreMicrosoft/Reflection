namespace Reflection.Models;

public class Student
{
    private int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void Greetings(string message)
    {
        Console.WriteLine(message);
    }
}