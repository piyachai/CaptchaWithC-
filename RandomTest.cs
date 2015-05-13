using CaptchaLibrary;
using NUnit.Framework;


namespace CaptchaTest
{
    [TestFixture]
    public class RandomTest
    {
        [Test]
        public void RandomPatternIs1Or2()
        {
            RandomNumber randomNumber = new RandomNumber();
            var result = randomNumber.Pattern();

            Assert.That(result, Is.InRange(1, 2));

        }
        [Test]
        public void RandomOperandIs1To9()
        {
            RandomNumber randomNumber = new RandomNumber();
            var result = randomNumber.Operand();

            Assert.That(result, Is.InRange(1, 9));

        }
        [Test]
        public void RandomOperaterIs1To3()
        {
            RandomNumber randomNumber = new RandomNumber();
            var result = randomNumber.Operater();

            Assert.That(result, Is.InRange(1, 3));

        }
    }
}
