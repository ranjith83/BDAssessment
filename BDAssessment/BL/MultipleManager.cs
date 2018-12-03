using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BDAssessment.Models;


namespace BDAssessment.BL
{
    public class MultipleManager
    {
        public async Task<List<MultiplResult>> MultiplyNumber(List<int> mulNumbers)
        {
            List<MultiplResult> multipledNumbers = new List<MultiplResult>();

            try
            {
                //Get the Random Number between 2, 3 or 4
                var getNumber = RandomManager.GetRandomNumber(2, 4);


                foreach (var num in mulNumbers)
                {
                    MultiplResult multiplResult = new MultiplResult();
                    multiplResult.ToMultiply = num;
                    multiplResult.MultipliedResult = num * getNumber;
                    multipledNumbers.Add(multiplResult);
                }

                //Delay for 5 to 10 seconds
                var delay = RandomManager.GetRandomNumber(5000, 10000);
                await Task.Delay(delay);

                //Subscribe the event - Observer Pattern
                ProcessObservable processObservable = new ProcessObservable();
                ProcessorObserver observer = new ProcessorObserver(processObservable);
                observer.generateNumbers = getNumber;
                
            }
            catch(Exception ex)
            {
                throw ex;
                //TODO: Log exception
            }
            return multipledNumbers;
        }

        private void SendNotify(object sender, ProcessorEventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}
