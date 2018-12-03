using BDAssessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BDAssessment.BL
{
    public class GenerateManager
    {
        public async Task<List<GenerateResult>> Generate(int x, int y)
        {
            List<GenerateResult> allNumbers = new List<GenerateResult>();

            try
            {
                List<int> mulNumbers = new List<int>();
                for (int i = 1; i <= x; i++)
                {
                    var getNumber = RandomManager.GetRandomNumber(0, x);


                    //Subscribe the event - Observer Pattern
                    ProcessObservable processObservable = new ProcessObservable();
                    ProcessorObserver observer = new ProcessorObserver(processObservable);
                    observer.generateNumbers = getNumber;

                    for (int j = 1; j <= y; j++)
                    {
                        //Generate Random numbers between 1 to 100
                        var getNumbers = RandomManager.GetRandomNumber(1, 100);

                        mulNumbers.Add(getNumbers);

                        //delay 5 to 10 seconds
                        var delaySeconds = RandomManager.GetRandomNumber(5000, 10000);

                        await Task.Delay(delaySeconds); // second delay
                    }
                    //Add all the generated numbers
                    GenerateResult generateResult = new GenerateResult();
                    generateResult.Id = i;
                    generateResult.RandomResult = mulNumbers;
                    allNumbers.Add(generateResult);

                }
            }
            catch(Exception ex)
            {
                throw ex;
                //TODO: Log Exception
            }

            return allNumbers;
        }

        public static void SendNotify(object sender, ProcessorEventArgs e)
        {
            //notify 
        }

    }




}
