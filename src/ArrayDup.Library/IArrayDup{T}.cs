using System.Collections.Generic;

namespace ArrayDup.Library
{
    public interface IArrayDup<T>
    {
        IEnumerable<T> Copy(IEnumerable<T> data);
    }
}