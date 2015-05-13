using CaptchaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptchaLibrary
{
    public class ServiceCaptcha
    {
        public string getCaptcha()
        {
            Captcha captcha = new Captcha(1,1,1,1);
            return captcha.ToString();
        }
    }
}
