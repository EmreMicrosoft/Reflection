namespace Reflection.Models;

public class InvokeRequest
{
    public string NameSpace { get; set; }
    public string ClassName { get; set; }
    public string MethodName { get; set; }
    public object[] Parameters { get; set; }
}