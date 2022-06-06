import org.junit.jupiter.api.Test

import org.junit.jupiter.api.Assertions.*

internal class CopyArrayTest {
    private val test: CopyArray = CopyArray()

    @Test
    fun testCopy() {
        val array = arrayOf(1,2,3)
        val expected = arrayOf(1,2,3)
        assertArrayEquals(expected, test.copyArray(array))
    }
}