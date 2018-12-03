using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDAssessment.BL
{
    public class RandomManager
    {
        internal static int GetRandomNumber(int minVal, int maxVal)
        {
            Random rdNumber = new Random();
            return rdNumber.Next(minVal, maxVal);
        }
    }
}
