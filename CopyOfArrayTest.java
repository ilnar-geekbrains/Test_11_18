

class CopyOfArrayTest {
    public static void main(String[] args) {
        testOne();
        testTwo();
        testThree();
    }

    //Первый тестовый кейс
    public static void testOne() {
        int[] actualArray = {1, 3, 4, 5};
        int[] resultArray = CopyOfArray.copyArray(actualArray);

        System.out.print("Первый тестовый кейс : ");
        CopyOfArray.printResult(actualArray, resultArray);

    }

    //Второй тестовый кейс
    public static void testTwo() {
        int[] actualArray = {};
        int[] resultArray = CopyOfArray.copyArray(actualArray);

        System.out.print("Второй тестовый кейс : ");
        CopyOfArray.printResult(actualArray, resultArray);

    }

    //Третий тестовый кейс
    public static void testThree() {
        int[] actualArray = {0, -1};
        int[] resultArray = CopyOfArray.copyArray(actualArray);

        System.out.print("Третий тестовый кейс : ");
        CopyOfArray.printResult(actualArray, resultArray);

    }

}