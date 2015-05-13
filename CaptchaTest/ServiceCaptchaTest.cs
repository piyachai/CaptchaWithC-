using CaptchaLibrary;
using NUnit.Framework;

namespace CaptchaTest
{
    [TestFixture]
    public class ServiceCaptchaTest
    {
        [Test]
        public void GetCaptchaObject()
        {
            ServiceCaptcha serviceCaptcha = new ServiceCaptcha();
            Assert.AreEqual("ONE+1", serviceCaptcha.getCaptcha());
        }
    }
}
