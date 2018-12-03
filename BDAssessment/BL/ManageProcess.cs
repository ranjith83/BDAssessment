using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDAssessment.BL
{
    public class ManageProcess
    {

        public List<int> GeneratorManager(int x, int y)
        {
            List<int> allNumbers = new List<int>();
            for (int i = 1; i <= x; i++)
            {
                allNumbers.Add(MultiplierManager(y));
            }

            return allNumbers;
        }

        public int MultiplierManager(int y)
        {
            List<int> mulNumbers = new List<int>();
            for(int j =1;j<=y;j++)
            {
                Random rdNumbers = new Random();
                int totalCount = rdNumbers.Next(1, 10);

                mulNumbers.Add(totalCount);
            }
           return MultiplyNumber(mulNumbers);
        }

        public int MultiplyNumber(List<int> mulNumbers)
        {
            int total = 1;
            foreach(var num in mulNumbers)
            {
                total *= num;
            }
            return total;
        }
    }


}
