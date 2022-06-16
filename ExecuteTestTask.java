
public class ExecuteTestTask {
    public static void main(String[] args)
    {
        System.out.println("Execution of CopyArray tests...");
        TestCopyArray.copyNotEmptyArrayOfIntegers();
        TestCopyArray.copyEmptyArrayOfIntegers();
        TestCopyArray.copyNotEmptyArrayOfStrings();
        TestCopyArray.copyNullArrayOfStrings();
        TestCopyArray.copyArrayOfObjects();
        System.out.println("FINISHED");
        System.out.println("Execution of MultiplyArrays tests...");
        TestMultiplyArrays.oneArrayIsNull();
        TestMultiplyArrays.oneArrayIsEmpty();
        TestMultiplyArrays.arrayLengthOverThreeIsIgnored();
        TestMultiplyArrays.lengthOfBothArraysIsLessThanThree();
        TestMultiplyArrays.negativeNumbers();
        System.out.println("FINISHED");
    }
}
