using Reflection.Models;


namespace Reflection.Samples.DynamicInvocations;

public class TestClass
{
    public static IEnumerable<Teacher> MethodA(IEnumerable<Teacher> teachers)
    {
        var result = teachers.ToList();

        Console.WriteLine($"TypeB/MethodA returned : {result}");
        return result;
    }

    public static int MethodB(IEnumerable<int> numbers)
    {
        var result = numbers.Sum();

        Console.WriteLine($"TypeA/MethodB returned : {result}");
        return result;
    }
}