using Reflection.Models;

namespace Reflection.Samples.DynamicInvocations;

public class Request
{
    public static void Run()
    {

    }

    private static IEnumerable<DynamicRequest> GetRequests()
    {
        var result = new List<DynamicRequest>
        {
            new DynamicRequest
            {
                ClassName = nameof(TypeB),
                MethodName = nameof(TypeB.MethodA),
                Repetition = 2,
                Parameters = new object[]
                {
                    new object[]
                    {
                        1, "John Doe", "Physics"
                    },
                    new object[]
                    {
                        2, "Jane Doe", "Mathematics"
                    }
                }
            }
        };

        return result;
    }
}