using System;
using System.Collections.Generic;
using System.Text;

namespace FunExtensionMethod.Extensions
{
    public static class SumOfDigitsUntilOneDigit
    {
        public static int DigitSum(int result)
        {
            int totalresult = 0;
            while (result > 0)
            {
                totalresult += result % 10;
                result /= 10;
            }
            if (totalresult > 9)
            {
                totalresult = DigitSum(totalresult);
            }
            return totalresult;
        }
    }
}
