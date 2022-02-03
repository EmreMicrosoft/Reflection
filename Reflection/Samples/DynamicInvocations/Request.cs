using System.Reflection;
using Reflection.Models;

namespace Reflection.Samples.DynamicInvocations;

public class Request
{
    public static void Run()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var requests = TestRequests();

        foreach (var request in requests)
        {
            var type = assembly.GetType($"{request.NameSpace}.{request.ClassName}");
            var method = type!.GetMethod(nameof(request.MethodName));
            var instance = Activator.CreateInstance(type);
            for (var i = 0; i < request.Repetition; i++)
            {
                method!.Invoke(instance, (object[])request.Parameters[i]);
            }

        }
    }

    private static IEnumerable<DynamicRequest> TestRequests()
    {
        var result = new List<DynamicRequest>
        {
            new(nameSpace: "Reflection",
                className: nameof(TypeB),
                methodName: nameof(TypeB.MethodA),
                repetition: 2,
                parameters: new object[]
                {
                    new Teacher { Id = 1, Name = "John Doe", FieldOfStudy = "Physics" },
                    new Teacher { Id = 2, Name = "Jane Doe", FieldOfStudy = "Mathematics" }
                }),
            new(nameSpace: "Reflection",
                className: nameof(TypeA),
                methodName: nameof(TypeA.MethodB),
                repetition: 3,
                parameters: new object[]
                {
                    new List<int> { 4, 8, 6, 7 },
                    new List<int> { 2, 5, 14 },
                    new List<int> { 5, 9, 1, 21, 8 }
                })
        };

        return result;
    }
}