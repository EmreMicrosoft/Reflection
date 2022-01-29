using System.Reflection;
using Reflection.Models;


namespace Reflection;

public class GetStarted
{
    private readonly Assembly _assembly;
    public GetStarted()
    {
        _assembly = Assembly.GetExecutingAssembly();
    }
    public  void AssemblyInfo()
    {
        Console.WriteLine("ASSEMBLY INFO:");
        
        Console.WriteLine($"Assembly    : { _assembly }");
        Console.WriteLine($"Location    : { _assembly.Location }");
        Console.WriteLine($"Entry Point : { _assembly.EntryPoint }");
        Console.WriteLine($"------------------------------------");
        Console.WriteLine();
    }


    public void TypesAndPropertiesOfAssembly()
    {
        var types = _assembly.GetTypes();

        Console.WriteLine("TYPES AND PROPERTIES OF ASSEMBLY:");

        foreach (var type in types)
        {
            Console.WriteLine($"+ Type Name : { type.FullName } ");

            foreach (var property in type.GetProperties())
            {
                Console.WriteLine($"  - Property : { property.Name } / { property.PropertyType }");
            }
        }

        Console.WriteLine("------------------------------------");
        Console.WriteLine();
    }


    public static void AccessToPrivates()
    {
        Console.WriteLine("ACCESS TO PRIVATES:");

        var objectType = typeof(Student);
        var objectInstance = (Student)Activator.CreateInstance(objectType);
        var property = objectType.GetProperty("Id",
            BindingFlags.NonPublic | BindingFlags.Instance);

        property!.SetValue(objectInstance, 12345);

        Console.WriteLine(property.GetValue(objectInstance));

        Console.WriteLine("------------------------------------");
        Console.WriteLine();
    }


    public static void CastInstanceAndInvokeMethod()
    {
        Console.WriteLine("CAST INSTANCE AND INVOKE METHOD:");

        var objectType = typeof(Student);
        var objectInstance = (Student)Activator.CreateInstance(objectType);
        var method = objectType.GetMethod(nameof(Student.Greetings));

        object[] parameters = { "Hello World!" };
        method!.Invoke(objectInstance, parameters);

        Console.WriteLine("------------------------------------");
        Console.WriteLine();
    }
}