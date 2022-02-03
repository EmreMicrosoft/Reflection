namespace Reflection.Models;

public class DynamicRequest
{
    public DynamicRequest(string nameSpace,
                          string className,
                          string methodName,
                          int repetition,
                          object[] parameters)
    {
        NameSpace = nameSpace;
        ClassName = className;
        MethodName = methodName;
        Repetition = repetition;
        Parameters = parameters;
    }

    public string NameSpace { get; }
    public string ClassName { get; }
    public string MethodName { get; }
    public int Repetition { get; }
    public object[] Parameters { get; }
}