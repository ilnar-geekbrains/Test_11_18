package ru.denisqq.test


import io.kotest.core.spec.style.FunSpec
import io.kotest.data.row
import io.kotest.inspectors.forAll
import io.kotest.matchers.collections.shouldBeSameSizeAs
import io.kotest.matchers.collections.shouldContainExactly

class ArrayCopyTest : FunSpec() {

    init {
        test("array system based copy") {
            listOf(
                row(
                    arrayOf(1, 2, 3, 4, 5),
                    arrayOf(1, 2, 3, 4, 5)
                ),
                row(
                    arrayOf(1, 5),
                    arrayOf(1, 5)
                ),
                row(
                    arrayOf(1, 2, 3, 4, 5, 6, 7, 8, 9),
                    arrayOf(1, 2, 3, 4, 5, 6, 7, 8, 9)
                )
            ).forAll { (source, target) ->
                val arrayCopy = ArrayCopy<Int>()
                val newArray = arrayCopy.arraySystemBasedCopy(source)

                newArray shouldBeSameSizeAs target
                newArray shouldContainExactly target
            }
        }

        test("element based copy") {
            listOf(
                row(
                    arrayOf(1, 2, 3, 4, 5),
                    arrayOf(1, 2, 3, 4, 5)
                ),
                row(
                    arrayOf(1, 5),
                    arrayOf(1, 5)
                ),
                row(
                    arrayOf(1, 2, 3, 4, 5, 6, 7, 8, 9),
                    arrayOf(1, 2, 3, 4, 5, 6, 7, 8, 9)
                )
            ).forAll { (source, target) ->
                val arrayCopy = ArrayCopy<Int>()
                val newArray = arrayCopy.elementBasedCopy(source)

                newArray shouldBeSameSizeAs target
                newArray shouldContainExactly target
            }
        }
    }
}
