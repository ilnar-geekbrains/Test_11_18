package org.example.model;

public class Dog {
    private String name;
    private String age;

    public Dog() {
    }

    @Override
    public String toString() {
        return "Dog{" +
                "name='" + name + '\'' +
                ", age='" + age + '\'' +
                '}';
    }

    public Dog(String name, String age) {
        this.name = name;
        this.age = age;
    }
}
