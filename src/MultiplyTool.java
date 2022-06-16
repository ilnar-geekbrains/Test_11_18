public class MultiplyTool {

    public static int[] multy(int[] arr1, int[] arr2) {
        return new int[]{arr1[0] * arr2[0], arr1[1] * arr2[0] + arr1[0] * arr2[1], arr1[1] * arr2[1]};
    }

}
