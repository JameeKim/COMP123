using Microsoft.VisualStudio.TestTools.UnitTesting;

using COMP123.Lab15.Library;

namespace COMP123.Lab15.Test
{
    [TestClass]
    public class UnitTestFraction
    {
        [TestMethod]
        public void TestConstructor_ZeroArgument()
        {
            const int expectedTop = 0;
            const int expectedBottom = 1;

            Fraction f = new Fraction();

            Assert.AreEqual(expectedTop, f.Top);
            Assert.AreEqual(expectedBottom, f.Bottom);
        }

        [TestMethod]
        public void TestConstructor_OneArgument()
        {
            const int expectedTop = 5;
            const int expectedBottom = 1;

            Fraction f = new Fraction(expectedTop);

            Assert.AreEqual(expectedTop, f.Top);
            Assert.AreEqual(expectedBottom, f.Bottom);
        }

        [TestMethod]
        public void TestConstructor_TwoArguments()
        {
            const int expectedTop = 3;
            const int expectedBottom = 4;

            Fraction f = new Fraction(expectedTop, expectedBottom);

            Assert.AreEqual(expectedTop, f.Top);
            Assert.AreEqual(expectedBottom, f.Bottom);
        }

        [TestMethod]
        public void TestToString()
        {
            const int top = 9;
            const int bottom = 2;
            string expectedString = $"{top} / {bottom}";

            Fraction f = new Fraction(top, bottom);

            Assert.AreEqual(expectedString, f.ToString());
        }

        [TestMethod]
        public void TestAddition()
        {
            Fraction lhs = new Fraction(3, 5);
            Fraction rhs = new Fraction(1, 2);
            Fraction expected = new Fraction(11, 10);

            Fraction f = lhs + rhs;

            Assert.AreEqual(expected.Top, f.Top);
            Assert.AreEqual(expected.Bottom, f.Bottom);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            Fraction lhs = new Fraction(3, 5);
            Fraction rhs = new Fraction(1, 2);
            Fraction expected = new Fraction(1, 10);

            Fraction f = lhs - rhs;

            Assert.AreEqual(expected.Top, f.Top);
            Assert.AreEqual(expected.Bottom, f.Bottom);
        }
    }
}
