namespace Reflection.Samples.DynamicInvocations;

public class TypeA
{
    public static string MethodA(string firstName, string lastName)
    {
        var result = $"\"{firstName} {lastName}\"";
        Console.WriteLine($"TypeA/MethodA returned : {result}");
        return result;
    }

    public static int MethodB(int number1, int number2)
    {
        var result = number1 + number2;
        Console.WriteLine($"TypeA/MethodB returned : {result}");
        return result;
    }
}