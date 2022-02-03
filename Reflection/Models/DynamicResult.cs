namespace Reflection.Models;

public class DynamicResult<T>
{
    public IList<DynamicType<T>> Results { get; set; }
}