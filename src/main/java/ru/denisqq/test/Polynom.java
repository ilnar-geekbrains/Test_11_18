package ru.denisqq.test;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Map.Entry;
import java.util.function.Function;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class Polynom {

    private final Map<Integer, Integer> coefsMap;

    public Polynom(List<Integer> coefs) {
        this.coefsMap = IntStream.range(0, coefs.size())
            .boxed()
            .collect(Collectors.toMap(Function.identity(), coefs::get));
    }
    private Polynom(Map<Integer, Integer> coefsMap) {
        this.coefsMap = coefsMap;
    }

    public Polynom multiple(Polynom polynom) {
        Map<Integer, Integer> result = new HashMap<>();

        coefsMap.forEach((firstPolynomKey, firstPolynomValue) -> {
            polynom.getCoefsMap().forEach((seconydPolynomKey, seconydPolynomValue) -> {
                var totalKey = firstPolynomKey + seconydPolynomKey;
                var totalValue = firstPolynomValue * seconydPolynomValue;

                if(result.containsKey(totalKey)) {
                    totalValue += result.get(totalKey);
                }

                result.put(totalKey, totalValue);
            });
        });

        return new Polynom(result);
    }

    private Map<Integer, Integer> getCoefsMap() {
        return coefsMap;
    }

    public List<Integer> getCoefs() {
        return new ArrayList<>(coefsMap.values());
    }
}
