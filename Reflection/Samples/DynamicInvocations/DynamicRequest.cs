using System.Reflection;
using Reflection.Models;


namespace Reflection.Samples.DynamicInvocations;

public class DynamicRequest
{
    public static IEnumerable<dynamic> Run()
    {
        var requests = TestRequests();

        var assembly = Assembly.GetExecutingAssembly();

        return (from request in requests
                let type = assembly.GetType($"{request.NameSpace}.{request.ClassName}")
                let method = type!.GetMethod(request.MethodName)
                let instance = Activator.CreateInstance(type!)
                select method!.Invoke(instance, request.Parameters))
            .Cast<dynamic>().ToList();
    }


    private static IEnumerable<InvokeRequest> TestRequests()
    {
        var result = new List<InvokeRequest>
        {
            new()
            {
                NameSpace = "Reflection.Samples.DynamicInvocations",
                ClassName = nameof(TestClass),
                MethodName = "MethodA",
                Parameters = new object[]
                {
                    new List<Teacher>
                    {
                        new() { Id = 1, Name = "John Doe", FieldOfStudy = "Physics" },
                        new() { Id = 2, Name = "Jane Doe", FieldOfStudy = "Mathematics" }
                    }
                }
            },
            new()
            {
                NameSpace = "Reflection.Samples.DynamicInvocations",
                ClassName = nameof(TestClass),
                MethodName = "MethodB",
                Parameters = new object[]
                {
                    new List<int> { 5, 9, 1, 21, 8 }
                }
            }
        };

        return result;
    }
}