using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptchaLibrary

{

    public class RandomNumber
    {
        private const int MinRandomNumber = 1;
        
        private const int MaxPattern = 2;
        
        private const int MaxOperand = 9;

        private const int MaxOperater = 3;

        public int Pattern()
        {
            return Randomizer(MinRandomNumber, MaxPattern);
        }             
        public int Operand()
        {
            return Randomizer(MinRandomNumber, MaxOperand);
        }
        public int Operater()
        {
            return Randomizer(MinRandomNumber, MaxOperater);
        }
        private static int Randomizer(int Min, int Max)
        {
            Random random = new Random();
            int randomNumber = random.Next(Min, Max);
            return randomNumber;
        }

    }
}
