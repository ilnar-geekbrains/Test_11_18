namespace Test_11_18
{
  public static class ArrayExtensions
  {
    public static T[] Copy<T>(this T[] array)
    {
      T[] copyArray = new T[array.Length];
      for (int i = 0; i < array.Length; i++)
      {
        copyArray[i] = array[i];
      }
      return copyArray;
    }
  }
}
