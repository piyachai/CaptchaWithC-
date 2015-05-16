using CaptchaLibrary;
using NSubstitute;
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
            var result = randomNumber.GetPattern();

            Assert.That(result, Is.InRange(1, 2));

        }

        [Test]
        public void RandomOperandIs1To9()
        {
            RandomNumber randomNumber = new RandomNumber();
            var result = randomNumber.GetLeftOperand();

            Assert.That(result, Is.InRange(1, 9));

        }

        [Test]
        public void RandomOperaterIs1To3()
        {
            RandomNumber randomNumber = new RandomNumber();
            var result = randomNumber.GetOperater();

            Assert.That(result, Is.InRange(1, 3));

        }


        [Test]
        public void RandomPattern_ShouldBeOne_WhenInPutPatternIs1()
        {
            var substitute = Substitute.For<IRandomNumber>();
            substitute.GetPattern().Returns(1);
            Assert.AreEqual(1, substitute.GetPattern());
        }


        [Test]
        public void RandomLeftOperand_ShouldBeTwo_WhenInPutOperandIs2()
        {
            var substitute = Substitute.For<IRandomNumber>();
            substitute.GetLeftOperand().Returns(2);
            Assert.AreEqual(2, substitute.GetLeftOperand());
        }


        [Test]
        public void RandomRigthOperand_ShouldBeNine_WhenInPutOperandIs9()
        {
            var substitute = Substitute.For<IRandomNumber>();
            substitute.GetRightOperand().Returns(9);
            Assert.AreEqual(9, substitute.GetRightOperand());
        }


        [Test]
        public void RandomOperator_ShouldBeThree_WhenInPutOperatorIs3()
        {
            var substitute = Substitute.For<IRandomNumber>();
            substitute.GetOperater().Returns(3);
            Assert.AreEqual(3, substitute.GetOperater());
        }

    }
}
