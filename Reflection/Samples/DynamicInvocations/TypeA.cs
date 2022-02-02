namespace Reflection.Samples.DynamicInvocations;

public class TypeA
{
    public static void MethodA(string firstName, string lastName)
    {
        Console.WriteLine($"TypeA/MethodA returned : \"{ firstName } { lastName }\"");
    }

    public static void MethodB(int number1, int number2)
    {
        Console.WriteLine($"TypeA/MethodB returned : { number1 + number2 }");
    }
}