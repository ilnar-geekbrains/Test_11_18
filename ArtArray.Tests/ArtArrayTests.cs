using FluentAssertions;
using System.Collections;

namespace ArtArray.Tests
{
    public class ArtArrayTests
    {
        public class CopyPositiveCases : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new List<int> { 1, 2, 3 } };
                yield return new object[] { new List<int> { } };
                yield return new object[] { new List<int> { 1 } };
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }

        [Theory]
        [ClassData(typeof(CopyPositiveCases))]
        public void Copy_Positive(List<int> arr)
        {
            ArtArray.Copy(arr.ToArray()).Should().BeEquivalentTo(arr);
        }

        [Fact]
        public void Copy_ShouldThrowArgumentNullException()
        {
            var func = () => ArtArray.Copy<int>(null!).Should();
            func.Should().Throw<ArgumentNullException>();
        }

        public class MultiplyPositiveCases : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { 
                    (new List<double> { -1, 1 }, new List<double> { 2, 1 }), 
                    new List<double> { -2, 1, 1 } 
                };
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }

        [Theory]
        [ClassData(typeof(MultiplyPositiveCases))]
        public void Multiply_Positive((List<double> firstArr, List<double> secondArr) input, List<double> expectedResult)
        {
            input.firstArr.ToArray().MultiplyBy(input.secondArr.ToArray())
                .Should().BeEquivalentTo(expectedResult);
        }
    }
}