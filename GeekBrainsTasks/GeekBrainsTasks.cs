namespace GeekBrainsTasks;
public class GeekBrainsTasks
{
    public static T[] CopyArray<T>(T[] originalArray)
    {
        T[] copiedArray = new T[originalArray.Length];
        for (int i = 0; i < originalArray.Length; i++)
            copiedArray[i] = originalArray[i];
        return copiedArray;
    }

    public static int[] PolinomMultiply(int[] firstPolinom, int[] secondPolinom)
    {
        int[] answerArray = new int[firstPolinom.Length + secondPolinom.Length - 1];
        for (int i = 0; i < firstPolinom.Length; i++)
        {
            for (int j = 0; j < secondPolinom.Length; j++)
            {
                int indexRecordOfAnswerArray = 0 + (i + j);
                answerArray[indexRecordOfAnswerArray] += firstPolinom[i] * secondPolinom[j];
            }
        }
        return answerArray;
    }
}