package org.example;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        List<Integer> massOne = new ArrayList<>(Arrays.asList(-1, 1));
        List<Integer> massTwo = new ArrayList<>(Arrays.asList(2, 1));
        List<Integer> resultMass = multiplicationMass(massOne, massTwo);
        System.out.println("результирующий массив: ");
        for (int i = 0; i < resultMass.size(); i++) {
            System.out.print(resultMass.get(i) + "  ");
        }
    }

    /**
     * @param massOne первый массив
     * @param massTwo второй массив
     * @return результирующий массив сформированный на основе степеней(индексов)
     */
    public static List<Integer> multiplicationMass(List<Integer> massOne, List<Integer> massTwo) {
        List<Integer> indexMass = new ArrayList<>(Collections.nCopies(massOne.size() + massTwo.size() - 1, 0));

        for (int i = 0; i < massOne.size(); i++) {
            for (int j = 0; j < massTwo.size(); j++) {
                indexMass.set(i + j, indexMass.get(i + j) + massOne.get(i) * massTwo.get(j));
            }
        }
        return indexMass;
    }
}