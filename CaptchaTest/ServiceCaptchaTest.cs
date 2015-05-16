using CaptchaLibrary;
using NUnit.Framework;
using NSubstitute;


namespace CaptchaTest
{
    [TestFixture]
    public class ServiceCaptchaTest
    {
        [Test]
        public void GetCaptchaObject_ShouldBeOnePlus1_WhenInputPatternIs1()
        {
            ServiceCaptcha serviceCaptcha = new ServiceCaptcha();
            var substitute = Substitute.For<IRandomNumber>();

            substitute.GetPattern().Returns(1);
            substitute.GetLeftOperand().Returns(1);
            substitute.GetRightOperand().Returns(1);
            substitute.GetOperater().Returns(1);

            serviceCaptcha.setRandomNumber(substitute.GetPattern(), substitute.GetLeftOperand(), substitute.GetOperater(), substitute.GetRightOperand());

            Assert.AreEqual("ONE+1", serviceCaptcha.getCaptcha());

        }


        [Test]
        public void GetCaptchaObject_ShouldBe1PlusOne_WhenInputPatternIs2()
        {
            ServiceCaptcha serviceCaptcha = new ServiceCaptcha();
            var substitute = Substitute.For<IRandomNumber>();

            substitute.GetPattern().Returns(2);
            substitute.GetLeftOperand().Returns(1);
            substitute.GetRightOperand().Returns(1);
            substitute.GetOperater().Returns(1);

            serviceCaptcha.setRandomNumber(substitute.GetPattern(), substitute.GetLeftOperand(), substitute.GetOperater(), substitute.GetRightOperand());

            Assert.AreEqual("1+ONE", serviceCaptcha.getCaptcha());

        }



        [Test]
        public void GetCaptchaObject_ShouldBe1PlusNine_WhenInputRightOperandIs9()
        {
            ServiceCaptcha serviceCaptcha = new ServiceCaptcha();
            var substitute = Substitute.For<IRandomNumber>();

            substitute.GetPattern().Returns(2);
            substitute.GetLeftOperand().Returns(1);
            substitute.GetRightOperand().Returns(9);
            substitute.GetOperater().Returns(1);

            serviceCaptcha.setRandomNumber(substitute.GetPattern(), substitute.GetLeftOperand(), substitute.GetOperater(), substitute.GetRightOperand());

            Assert.AreEqual("1+NINE", serviceCaptcha.getCaptcha());

        }


        [Test]
        public void GetCaptchaObject_ShouldBe1PlusFive_WhenInputRightOperandIs5()
        {
            ServiceCaptcha serviceCaptcha = new ServiceCaptcha();
            var substitute = Substitute.For<IRandomNumber>();

            substitute.GetPattern().Returns(2);
            substitute.GetLeftOperand().Returns(1);
            substitute.GetRightOperand().Returns(5);
            substitute.GetOperater().Returns(1);

            serviceCaptcha.setRandomNumber(substitute.GetPattern(), substitute.GetLeftOperand(), substitute.GetOperater(), substitute.GetRightOperand());

            Assert.AreEqual("1+FIVE", serviceCaptcha.getCaptcha());

        }


        [Test]
        public void GetCaptchaObject_ShouldBeTHREEPlus1_WhenInputLeftOperandIs3()
        {
            ServiceCaptcha serviceCaptcha = new ServiceCaptcha();
            var substitute = Substitute.For<IRandomNumber>();

            substitute.GetPattern().Returns(1);
            substitute.GetLeftOperand().Returns(3);
            substitute.GetRightOperand().Returns(1);
            substitute.GetOperater().Returns(1);

            serviceCaptcha.setRandomNumber(substitute.GetPattern(), substitute.GetLeftOperand(), substitute.GetOperater(), substitute.GetRightOperand());

            Assert.AreEqual("THREE+1", serviceCaptcha.getCaptcha());

        }


        [Test]
        public void GetCaptchaObject_ShouldBeThrowException_WhenInputInvalidRangeMinLeftOperand()
        {
            ServiceCaptcha serviceCaptcha = new ServiceCaptcha();
            var substitute = Substitute.For<IRandomNumber>();

            substitute.GetPattern().Returns(1);
            substitute.GetLeftOperand().Returns(0);
            substitute.GetRightOperand().Returns(1);
            substitute.GetOperater().Returns(1);

            serviceCaptcha.setRandomNumber(substitute.GetPattern(), substitute.GetLeftOperand(), substitute.GetOperater(), substitute.GetRightOperand());

            Assert.Throws(typeof(InvalidRangeException),
                delegate { serviceCaptcha.getCaptcha(); });


        }


        [Test]
        public void GetCaptchaObject_ShouldBeThrowException_WhenInputInvalidRangeMaxLeftOperand()
        {
            ServiceCaptcha serviceCaptcha = new ServiceCaptcha();
            var substitute = Substitute.For<IRandomNumber>();

            substitute.GetPattern().Returns(1);
            substitute.GetLeftOperand().Returns(5);
            substitute.GetRightOperand().Returns(10);
            substitute.GetOperater().Returns(1);

            serviceCaptcha.setRandomNumber(substitute.GetPattern(), substitute.GetLeftOperand(), substitute.GetOperater(), substitute.GetRightOperand());

            Assert.Throws(typeof(InvalidRangeException),
                delegate { serviceCaptcha.getCaptcha(); });


        }


        [Test]
        public void GetCaptchaObject_ShouldBeThrowException_WhenInputInvalidRangeMinRightOperand()
        {
            ServiceCaptcha serviceCaptcha = new ServiceCaptcha();
            var substitute = Substitute.For<IRandomNumber>();

            substitute.GetPattern().Returns(1);
            substitute.GetLeftOperand().Returns(1);
            substitute.GetRightOperand().Returns(-5);
            substitute.GetOperater().Returns(1);

            serviceCaptcha.setRandomNumber(substitute.GetPattern(), substitute.GetLeftOperand(), substitute.GetOperater(), substitute.GetRightOperand());

            Assert.Throws(typeof(InvalidRangeException),
                delegate { serviceCaptcha.getCaptcha(); });


        }

        [Test]
        public void GetCaptchaObject_ShouldBeThrowException_WhenInputInvalidRangeMaxRightOperand()
        {
            ServiceCaptcha serviceCaptcha = new ServiceCaptcha();
            var substitute = Substitute.For<IRandomNumber>();

            substitute.GetPattern().Returns(1);
            substitute.GetLeftOperand().Returns(1);
            substitute.GetRightOperand().Returns(20);
            substitute.GetOperater().Returns(1);

            serviceCaptcha.setRandomNumber(substitute.GetPattern(), substitute.GetLeftOperand(), substitute.GetOperater(), substitute.GetRightOperand());

            Assert.Throws(typeof(InvalidRangeException),
                delegate { serviceCaptcha.getCaptcha(); });


        }



        [Test]
        public void GetCaptchaObject_ShouldBeThrowException_WhenInputInvalidFormatOperator()
        {
            ServiceCaptcha serviceCaptcha = new ServiceCaptcha();
            var substitute = Substitute.For<IRandomNumber>();

            substitute.GetPattern().Returns(1);
            substitute.GetLeftOperand().Returns(1);
            substitute.GetRightOperand().Returns(5);
            substitute.GetOperater().Returns(9);

            serviceCaptcha.setRandomNumber(substitute.GetPattern(), substitute.GetLeftOperand(), substitute.GetOperater(), substitute.GetRightOperand());

            Assert.Throws(typeof(InvalidFormatOperatorException),
                delegate { serviceCaptcha.getCaptcha(); });


        }
        


       
        

    }
}
