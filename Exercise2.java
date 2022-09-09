public class Exercise2 {
    public static void main(String[] args) {
        tests();
    }

    //основная функция
    public static int[] multiPolinom(int[] arr1, int[] arr2){
        int[] result = new int[arr1.length + arr2.length - 1];
        for (int i = 0; i < arr1.length; i++) {
            for (int j = 0; j < arr2.length; j++) {
                result[i+j] += arr1[i] * arr2[j];
            }
        }
        return result;
    }

    //проверка на идентичность массивов
    private static boolean checkArr(int[] arr1, int[] arr2){
        if (arr1.length == arr2.length){
            for (int i = 0; i < arr1.length; i++) {
                if (arr1[i] != arr2[i]){
                    return false;
                }
            }
            return true;
        } else {
            return false;
        }
    }

    //тесты
    private static void tests(){
        test1();
        test2();
    }

    private static void test1(){
        int[] arr1 = new int[]{-1, 1};
        int[] arr2 = new int[]{2, 1};
        int[] checkRes = new int[]{-2, 1, 1};
        int[] res = multiPolinom(arr1, arr2);
        if (checkArr(checkRes, res)){
            System.out.println("Тест 1 пройден успешно");
        } else {
            System.out.println("Тест 1 провален");
        }
    }

    private static void test2(){
        int[] arr1 = new int[]{2, -3, 14, 266, -400};
        int[] arr2 = new int[]{7, 0, 5};
        int[] checkRes = new int[]{14, -21, 108, 1847, -2730, 1330, -2000};
        int[] res = multiPolinom(arr1, arr2);
        if (checkArr(checkRes, res)){
            System.out.println("Тест 2 пройден успешно");
        } else {
            System.out.println("Тест 2 провален");
        }
    }
}
