using PolynomMult.Lib;

namespace PolynomMult.Tests
{
    public class ArrayHelperShould
    {
        [Fact]
        public void Throws_exc_v1()
        {
            double[] p1 = null;
            double[] p2 = null;

            Assert.Throws<NullReferenceException>(() => ArrayHelper.PolynomMult(p1, p2));
        }

        [Fact]
        public void Throws_exc_v2()
        {
            double[] p1 = null;            
            var p2 = new[] { -3.0 };                       

            Assert.Throws<NullReferenceException>(()=>ArrayHelper.PolynomMult(p1, p2));
        }

        [Fact]
        public void Throws_exc_v3()
        {            
            var p1 = new[] { -3.0 };
            double[] p2 = null;

            Assert.Throws<NullReferenceException>(() => ArrayHelper.PolynomMult(p1, p2));
        }        

        [Fact]
        public void Return_m6()
        {
            var p1 = new[] { 2.0 };
            var p2 = new[] { -3.0 };
            
            var actual = ArrayHelper.PolynomMult(p1, p2);
            var expected = new[] { -6.0 };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Return_m2m1_v1()
        {            
            var p1 = new[] { 2.0, 1.0 };
            var p2 = new[] { -1.0 };

            var actual = ArrayHelper.PolynomMult(p1, p2);
            var expected = new[] { -2.0, -1, };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Return_m2m1_v2()
        {
            var p1 = new[] { -1.0 };
            var p2 = new[] { 2.0, 1.0 };

            var actual = ArrayHelper.PolynomMult(p1, p2);
            var expected = new[] { -2.0, -1, };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Return_m2p1p1()
        {
            var p1 = new[] { -1.0, 1.0 };
            var p2 = new[] { 2.0, 1.0 };

            var actual = ArrayHelper.PolynomMult(p1, p2);
            var expected = new[] { -2.0, 1, 1 };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Return_m2p1p1___()
        {
            var p1 = new[] { -1.0, 1.0 };
            var p2 = new[] { 2.0, 1.0, 3 };

            var actual = ArrayHelper.PolynomMult(p1, p2);
            var expected = new[] { -2.0, 1, -2, 3 };

            Assert.Equal(expected, actual);
        }
    }
}