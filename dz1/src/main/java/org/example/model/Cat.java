package org.example.model;

public class Cat {
    private String name;
    private String age;

    public Cat() {
    }

    @Override
    public String toString() {
        return "Cat{" +
                "name='" + name + '\'' +
                ", age='" + age + '\'' +
                ", weight='" + weight + '\'' +
                '}';
    }

    public Cat(String name, String age, String weight) {
        this.name = name;
        this.age = age;
        this.weight = weight;
    }

    private String weight;
}
