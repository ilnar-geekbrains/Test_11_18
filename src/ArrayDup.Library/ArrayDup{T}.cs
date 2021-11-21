using System.Collections.Generic;
using System.Linq;

namespace ArrayDup.Library
{
    public class ArrayDup<T> : IArrayDup<T>
    {
        public IEnumerable<T> Copy(IEnumerable<T> data)
        {
            var answer = new List<T>(data.Count());
            CopyCore(data, answer);
            return answer;
        }

        protected static void CopyCore<TS, TR>(IEnumerable<TS> source, IList<TR> dest)
            where TS : TR
        {
            foreach (var element in source)
            {
                dest.Add(element);
            }
        }
    }
}
