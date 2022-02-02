namespace Reflection.Models;

public class DynamicRequest
{
    public string ClassName { get; set; }
    public string MethodName { get; set; }
    public int Repetition { get; set; } = 1;
    public object[] Parameters { get; set; }
}