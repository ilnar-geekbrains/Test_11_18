namespace ArrayExtension
{
    /// <summary>
    /// Extension methods for array
    /// </summary>
    public static class ArrayExtensions
    {
        /// <summary>
        /// Copy elements from source array to destination
        /// </summary>
        /// <param name="sourceArray"> From array copy </param>
        /// <param name="destinationArray"> To array copy </param>
        /// <typeparam name="T">Generic array type</typeparam>
        /// <exception cref="NullReferenceException">If array is null</exception>
        /// <exception cref="IndexOutOfRangeException">If length source array more then destination array</exception>
        public static void CopyExtension<T>(this T[] sourceArray, T[] destinationArray)
        {
            if (sourceArray == null || destinationArray == null)
            {
                throw new NullReferenceException();
            }

            if (sourceArray.Length > destinationArray.Length)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = 0; i < sourceArray.Count(); i++)
            {
                destinationArray[i] = sourceArray[i];
            }
        }
    }
}