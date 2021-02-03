using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tricentis.Tests
{
    [TestClass]
    public class ComparisonTests
    {
        private static int number = 10;
        private IntegerComparer comparer;

        [TestInitialize]
        public void Init()
        {
            comparer = new IntegerComparer(number);
        }

        [TestMethod]
        public void When_SmallerIntegerIsGuessed_Expect_ToReturnLower()
        {
            Assert.AreEqual(comparer.CompareTheIntegers(20), "higher");
        }

        [TestMethod]
        public void When_BiggerIntegerIsGuessed_Expect_ToReturnHigher()
        {
            Assert.AreEqual(comparer.CompareTheIntegers(5), "lower");
        }

        [TestMethod]
        public void When_IntegerIsGuessedEqual_Expect_ToReturnEqual()
        {
            Assert.AreEqual(comparer.CompareTheIntegers(10), "equal");
        }
    }
}
