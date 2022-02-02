using Reflection.Models;

namespace Reflection.Samples.DynamicInvocations;

public class TypeB
{
    public static DynamicResult MethodA(DynamicRequest request)
    {
        var result = new DynamicResult();

        for (var i = 0; i < request.Repetition; i++)
        {
            
        }

        Console.WriteLine($"TypeB/MethodA returned : {nameof(result)}");
        return result;
    }

    public static void MethodB(int number)
    {
        Console.WriteLine($"Result of TypeB/MethodB : { number }");
    }
}