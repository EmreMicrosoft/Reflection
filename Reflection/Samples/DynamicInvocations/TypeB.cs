using Reflection.Models;

namespace Reflection.Samples.DynamicInvocations;

public class TypeB
{
    public static DynamicResult<Teacher> MethodA(DynamicRequest request)
    {
        var result = new DynamicResult<Teacher>();
        for (var i = 0; i < request.Repetition; i++)
        {
            result.Results.Add(
                (DynamicType<Teacher>)request
                    .Parameters[i]);
        }

        Console.WriteLine($"TypeB/MethodA returned : {nameof(result)}");
        return result;
    }

    public static void MethodB(int number)
    {
        Console.WriteLine($"Result of TypeB/MethodB : { number }");
    }
}