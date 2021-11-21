using System.Collections.Generic;
using System.Linq;

namespace ArrayDup.Library
{
    public class ArrayDup<T, TR> : ArrayDup<T>,  IArrayDup<T, TR>
        where T : TR
    {
        public IEnumerable<TR> Copy(IEnumerable<T> data)
        {
            var answer = new List<TR>(data.Count());
            CopyCore(data, answer);
            return answer;
        }
    }
}
