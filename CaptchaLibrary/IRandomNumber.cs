using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptchaLibrary
{
    public interface IRandomNumber
    {
        int GetPattern();

        int GetLeftOperand();

        int GetRightOperand();

        int GetOperater();
        
    }
}
