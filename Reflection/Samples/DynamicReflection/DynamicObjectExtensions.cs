namespace Reflection.Samples.DynamicReflection;

public static class DynamicObjectExtensions
{
    public static dynamic Extend(this Type type)
        => new ExtendedObject(type);

    public static dynamic Extend(this object objectInstance)
        => new ExtendedObject(objectInstance);
}