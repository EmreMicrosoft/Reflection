using System.Reflection;


namespace Reflection;

public class Fundementals
{
    public static void AssemblyInfo()
    {
        Console.WriteLine("ASSEMBLY INFO:");

        var assembly = Assembly.GetExecutingAssembly();
        Console.WriteLine("Assembly    : " + assembly);
        Console.WriteLine("Location    : " + assembly.Location);
        Console.WriteLine("Entry Point : " + assembly.EntryPoint);
        Console.WriteLine("------------------------------------");
        Console.WriteLine();
    }

    public static void TypesAndPropertiesOfAssembly()
    {
        var types = Assembly.GetExecutingAssembly().GetTypes();

        Console.WriteLine("TYPES AND PROPERTIES OF ASSEMBLY:");

        foreach (var type in types)
        {
            Console.WriteLine("+ Type Name : " + type.Name);

            foreach (var property in type.GetProperties())
            {
                Console.WriteLine("  - Property Name : " + property.Name);
            }
        }

        Console.WriteLine("------------------------------------");
        Console.WriteLine();
    }
}