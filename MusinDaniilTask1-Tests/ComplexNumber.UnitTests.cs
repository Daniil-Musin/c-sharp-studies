namespace MusinDaniilTask1.UnitTests
{
    [TestFixture]
    public class ComplexNumberTests
    {

        [Test]
        public void ConstructorTest()
        {
            var comp = new Complex(22, 44);
            Assert.That(comp.Re, Is.EqualTo(22));
            Assert.That(comp.Im, Is.EqualTo(44));
            Assert.That(comp.Abs, Is.EqualTo(Math.Sqrt(22 * 22 + 44 * 44)));
        }

        [TestCase(10, 10, "10+10i")]
        [TestCase(10, -10, "10-10i")]
        [TestCase(0, 0, "0")]
        [TestCase(-10, 10, "-10+10i")]
        [TestCase(-10, -10, "-10-10i")]
        [TestCase(-10, 0, "-10")]
        [TestCase(10, 0, "10")]
        [TestCase(0, -10, "-10i")]
        [TestCase(0, 10, "10i")]
        public void ToString_Test(double a, double b, string result)
        {
            var comp = new Complex(a, b);
            Assert.That(comp.ToString(), Is.EqualTo(result));
        }

        [TestCase(10, 10, 25, 25)]
        [TestCase(0, 0, 25, 25)]
        [TestCase(0, 0, -25, -25)]
        [TestCase(-10, -10, 25, 25)]
        [TestCase(-10, -10, -25, -25)]
        public void Equals_Test(double a, double b, double c, double d)
        {
            var comX = new Complex(a, b);
            var comY = new Complex(c, d);
            var comZ = new Complex(a, b);
            Assert.That(comX.Equals(comY), Is.False);
            Assert.That(comX.Equals(comZ), Is.True);
        }

        [TestCase(10, 10, 25, 25)]
        [TestCase(0, 0, 25, 25)]
        [TestCase(0, 0, -25, -25)]
        [TestCase(-10, -10, 25, 25)]
        [TestCase(-10, -10, -25, -25)]
        public void BoolOperators_Test(double a, double b, double c, double d)
        {
            var comX = new Complex(a, b);
            var comY = new Complex(c, d);
            var comZ = new Complex(a, b);

            Assert.That(comX == comY, Is.False);
            Assert.That(comX != comY, Is.True);
            Assert.That(comX == comZ, Is.True);
            Assert.That(comX != comZ, Is.False);
        }

        [TestCase(10, 10, 25, 25)]
        [TestCase(0, 0, 25, 25)]
        [TestCase(0, 0, -25, -25)]
        [TestCase(-10, -10, 25, 25)]
        [TestCase(-10, -10, -25, -25)]
        public void PlusAndMinusOperators_Test(double a, double b, double c, double d)
        {
            var comX = new Complex(a, b);
            var comY = new Complex(c, d);

            Assert.That(comX + comY, Is.EqualTo(new Complex(a + c, b + d)));
            Assert.That(comX - comY, Is.EqualTo(new Complex(a - c, b - d)));


        }
    }
}