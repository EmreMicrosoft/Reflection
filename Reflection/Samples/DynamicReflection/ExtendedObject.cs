using System.Dynamic;
using System.Reflection;


namespace Reflection.Samples.DynamicReflection;

public class ExtendedObject : DynamicObject
{
    private readonly Type _type;
    private readonly object _objectInstance;
    private const BindingFlags Flags = BindingFlags.Instance
                                       | BindingFlags.Static
                                       | BindingFlags.Public
                                       | BindingFlags.NonPublic;

    public ExtendedObject(Type type)
        => _type = type;

    public ExtendedObject(object objectInstance)
        : this(objectInstance.GetType())
        => _objectInstance = objectInstance;


    private object Object
        => _objectInstance ?? _type;

    public override bool TryGetMember(GetMemberBinder binder, out object result)
    {
        var property = _type.GetProperty(binder.Name, Flags);

        if (property != null)
        {
            result = property.GetValue(_objectInstance);
            return true;
        }

        var field = _type.GetField(binder.Name, Flags);

        if (field == null)
            return base.TryGetMember(binder, out result);

        result = field.GetValue(_objectInstance);
        return true;
    }


    public override bool TrySetMember(SetMemberBinder binder, object value)
    {
        var property = _type.GetProperty(binder.Name, Flags);

        if (property != null)
        {
            property.SetValue(_objectInstance, value);
            return true;
        }

        var field = _type.GetField(binder.Name, Flags);

        if (field == null)
            return base.TrySetMember(binder, value);

        field.SetValue(_objectInstance, value);
        return true;
    }


    public override bool TryInvokeMember(InvokeMemberBinder binder,
        object[] args, out object result)
    {
        args = args.Select(Unboxing).ToArray();

        var method = _type.GetMethod(binder.Name,
            args.Select(a => a.GetType()).ToArray());

        result = method!.Invoke(_objectInstance, args).Extend();
        return true;
    }


    public override bool TryConvert(ConvertBinder binder, out object result)
    {
        result = binder.Type
            .GetTypeInfo()
            .IsInstanceOfType(_objectInstance)
                ? _objectInstance
                : Convert.ChangeType(_objectInstance, binder.Type);
        return true;
    }


    private static object Unboxing(dynamic dynamicObject)
    {
        if (dynamicObject is ExtendedObject extendedObject)
            return extendedObject.Object;

        return dynamicObject;
    }
}