import java.util.Arrays;

public class TestGB {

  public static int[] CreateArray(int size) {
    int array[] = new int[size]; // Создаём массив int размером в size (не указано в тестовом, что нельзя
                                 // привязаться к типу)
    for (int i = 0; i < array.length; i++) {
      array[i] = (int) Math.round((Math.random() * 200) - 100); // Заполняем массив случайными величинами от -100 до 100
    }
    return array;
  }

  public static int[] CloneArray(int[] array) {
    int copy[] = null; // создаём пустой массив для дальнейшего копирования
    copy = array.clone(); // копируем массив с помошью втроенной возможности java
    return copy;
  }

  public static void main(String[] args) {
    TestGB obj = new TestGB();

    int arr[] = obj.CreateArray(2); // создание массива
    // Тесты работы программы
    if (Arrays.equals(arr, obj.CloneArray(arr))) {
      System.out.println("Тест пройден!");
    } else {
      System.out.println("Тест провален!");
    }

    arr = obj.CreateArray(8);
    if (Arrays.equals(arr, obj.CloneArray(arr))) {
      System.out.println("Тест пройден!");
    } else {
      System.out.println("Тест провален!");
    }

    arr = obj.CreateArray(0);
    if (Arrays.equals(arr, obj.CloneArray(arr))) {
      System.out.println("Тест пройден!");
    } else {
      System.out.println("Тест провален!");
    }
  }
}
