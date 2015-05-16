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


        private Captcha captcha;

        public string getCaptcha()
        {
            
            return captcha.ToString();
        }

        public void setRandomNumber(int pattern, int leftOperand, int operatorSymbol, int rightOperand)
        {
            captcha = new Captcha(pattern, leftOperand, operatorSymbol, rightOperand);
            
        }
    }
}
