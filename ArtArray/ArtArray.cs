namespace ArtArray
{
    public static class ArtArray
    {
        public static T[] Copy<T>(T[] arr) {
            if (arr == null) {
                throw new ArgumentNullException(nameof(arr));
            }

            var copy = new T[arr.Length];
            for (int i = 0; i < arr.Length; i++) {
                copy[i] = arr[i];
            }

            return copy;
        }

        public static double[] MultiplyBy(this double[] firstArr, double[] secondArr)
        {
            var result = new double[firstArr.Length + secondArr.Length - 1];

            for (int i = 0; i < firstArr.Length; i++) {
                for (int j = 0; j < secondArr.Length; ++j) {
                    result[i + j] += firstArr[i] * secondArr[j];
                }
            }

            return result;
        }
    }
}