class MultipliedPolynomsTest {

    public static void main(String[] args) {
        testOne();
        testTwo();
        testThree();
        testFour();
        testFive();
    }

    /*
    Первый тестовый кейс
     */
    public static void testOne() {
        int[] arrayFirst = {-1, 1};
        int[] arraySecond = {2, 1};

        // (x - 1)(x + 2) = (x^2 + x - 2)
        int[] answerPolynom = {-2, 1, 1};

        int[] multipliedPolynom = MultipliedPolynoms.multipliedPolynoms(arrayFirst, arraySecond);

        System.out.print("Первый тестовый кейс : ");
        MultipliedPolynoms.printResult(answerPolynom, multipliedPolynom);
    }

    /*
    Второй тестовый кейс
    */
    public static void testTwo() {
        int[] arrayFirst = {0};
        int[] arraySecond = {1, 1, 1};

        // 0 * (x^2 + x + 1) = 0
        int[] answerPolynom = {0};

        int[] multipliedPolynom = MultipliedPolynoms.multipliedPolynoms(arrayFirst, arraySecond);

        System.out.print("Второй тестовый кейс : ");
        MultipliedPolynoms.printResult(answerPolynom, multipliedPolynom);
    }

    /*
    Третий тестовый кейс
    */
    public static void testThree() {
        int[] arrayFirst = {-1};
        int[] arraySecond = {1};

        // 1 * (-1) = -1
        int[] answerPolynom = {-1};

        int[] multipliedPolynom = MultipliedPolynoms.multipliedPolynoms(arrayFirst, arraySecond);

        System.out.print("Третий тестовый кейс : ");
        MultipliedPolynoms.printResult(answerPolynom, multipliedPolynom);
    }

    /*
    Четвертый тестовый кейс
    */
    public static void testFour() {
        int[] arrayFirst = {5, -3, 4};
        int[] arraySecond = {-7, 2, -2};

        // (4x^2 - 3x + 5)(-2x^2 + 2x - 7) = (-8x^4 + 14x^3 - 44x^2 + 31x - 35)
        int[] answerPolynom = {-35, 31, -44, 14, -8};

        int[] multipliedPolynom = MultipliedPolynoms.multipliedPolynoms(arrayFirst, arraySecond);

        System.out.print("Четвертый тестовый кейс : ");
        MultipliedPolynoms.printResult(answerPolynom, multipliedPolynom);
    }

    /*
    Пятый тестовый кейс
    */
    public static void testFive() {
        int[] arrayFirst = {1, 1};
        int[] arraySecond = {1, 1};

        // (x + 1)(x + 1) = (x^2 + 2x + 1)
        int[] answerPolynom = {1, 2, 1};

        int[] multipliedPolynom = MultipliedPolynoms.multipliedPolynoms(arrayFirst, arraySecond);

        System.out.print("Пятый тестовый кейс : ");
        MultipliedPolynoms.printResult(answerPolynom, multipliedPolynom);
    }

}