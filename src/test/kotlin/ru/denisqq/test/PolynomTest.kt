package ru.denisqq.test


import io.kotest.core.spec.style.FunSpec
import io.kotest.data.row
import io.kotest.inspectors.forAll
import io.kotest.matchers.collections.shouldBeSameSizeAs
import io.kotest.matchers.collections.shouldContainExactly

class PolynomTest : FunSpec() {

    init {
        test("polynom multiple test") {
            listOf(
                row(
                    mutableListOf(-1, 1),
                    mutableListOf(2, 1),
                    mutableListOf(-2, 1, 1),
                ),
                row(
                    mutableListOf(7, 11, 2, 3),
                    mutableListOf(1, 1),
                    mutableListOf(7, 18, 13, 5, 3),
                ),
                row(
                    mutableListOf(-10, 9),
                    mutableListOf(25, 2),
                    mutableListOf(-250, 205, 18),
                ),
            ).forAll { (firstCoefs, secondCoefs, expectedCoef) ->
                val firstPolynom = Polynom(firstCoefs)
                val secondPolynom = Polynom(secondCoefs)

                val newPolynom = firstPolynom.multiple(secondPolynom)

                newPolynom.coefs shouldBeSameSizeAs expectedCoef
                newPolynom.coefs shouldContainExactly expectedCoef
            }
        }
    }
}
