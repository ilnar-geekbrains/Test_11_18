import org.junit.jupiter.api.Test

import org.junit.jupiter.api.Assertions.*

internal class MultiplyPolynomialsTest {
    private val test: MultiplyPolynomials = MultiplyPolynomials()

    @Test
    fun testMultiply() {
        val polynomial1 = intArrayOf(-1, 1) // (x-1)
        val polynomial2 = intArrayOf(2, 1) // (x+2)
        val expected = intArrayOf(-2,1,1)
        assertArrayEquals(expected, test.multiplyPolynomials(polynomial1, polynomial2))
    }
}