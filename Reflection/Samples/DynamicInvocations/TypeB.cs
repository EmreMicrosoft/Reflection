namespace Reflection.Samples.DynamicInvocations;

public class TypeB
{
    public static void MethodA(string message)
    {
        Console.WriteLine($"Message from TypeB/MethodA : \"{ message }\"");
    }

    public static void MethodB(int number)
    {
        Console.WriteLine($"Result of TypeB/MethodB : { number }");
    }
}