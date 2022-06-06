class MultiplyPolynomials {
    fun multiplyPolynomials(polynomial1: IntArray, polynomial2: IntArray): IntArray {
        val size1 = polynomial1.size
        val size2 = polynomial2.size
        val sizeProduct = size1 + size2 - 1
        val product = IntArray(sizeProduct)

        for (index1 in 0 until size1) {
            for (index2 in 0 until size2) {
                product[index1 + index2] += polynomial1[index1] * polynomial2[index2]
            } // перемножаем каждый член первого полинома
        } // с каждым членом второго полинома.
        return product
    }
}