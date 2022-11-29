package org.example;

import org.example.model.Cat;
import org.example.model.Dog;

import java.util.ArrayList;
import java.util.List;

public class Main {


    public static void main(String[] args) {
        List<Object> firstMass = new ArrayList<>();
        Cat cat = new Cat("barsic", "21", "145");
        Dog dog = new Dog("rex", "3");
        for (int i = 0; i < 5; i++) {
            firstMass.add(i);
        }
        firstMass.add(cat);
        firstMass.add(dog);
        //различные реализации
//        List<Object> secondMass = copyMass(firstMass);
//        List<Object> secondMass = copyMass(firstMass,3);
        List<Object> secondMass = copyMass(firstMass,3,3);
        if (secondMass != null) {
            System.out.println("скопированный массив: ");
            for (int i = 0; i < secondMass.size(); i++) {
                System.out.println("ii- " + secondMass.get(i).toString());
            }
        }
    }

    /**
     * @param firstMass - исзодный массив
     * @return результирующий массив
     */
    public static List<Object> copyMass(List<Object> firstMass) {
        List<Object> resultMass = new ArrayList<>();
        for (int i = 0; i < firstMass.size(); i++) {
            resultMass.add(firstMass.get(i));
        }
        return resultMass;
    }

    /**
     * @param firstMass - исзодный массив
     * @param n         - индекс начала копирования
     * @return результирующий массив
     */
    public static List<Object> copyMass(List<Object> firstMass, int n) {
        List<Object> resultMass = new ArrayList<>();
        if (n > firstMass.size()) {
            System.out.println("неправильная размерность");
            return null;
        }
        for (int i = n; i < firstMass.size(); i++) {
            resultMass.add(firstMass.get(i));
        }
        return resultMass;
    }

    /**
     * @param firstMass - исзодный массив
     * @param n         - индекс начала копирования
     * @param k         - количество элементов копирования
     * @return результирующий массив
     */
    public static List<Object> copyMass(List<Object> firstMass, int n, int k) {
        List<Object> resultMass = new ArrayList<>();
        if (n > firstMass.size() || k > firstMass.size() || n + k > firstMass.size()) {
            System.out.println("неправильная размерность");
            return null;
        }
        for (int i = n; i < n + k; i++) {
            resultMass.add(firstMass.get(i));
        }
        return resultMass;
    }
}