using System.Collections.Generic;

namespace ArrayDup.Library
{
    public interface IArrayDup<T, TR> : IArrayDup<T>
        where T : TR
    {
        IEnumerable<TR> Copy(IEnumerable<T> data);
    }
}