namespace Reflection.Samples.DynamicInvocations;

public class TypeA
{
    public static string MethodA(string firstName, string lastName)
    {
        var result = $"\"{firstName} {lastName}\"";
        Console.WriteLine($"TypeA/MethodA returned : {result}");
        return result;
    }

    public static int MethodB(IEnumerable<int> numbers)
    {
        var result = numbers.Sum();

        Console.WriteLine($"TypeA/MethodB returned : {result}");
        return result;
    }
}