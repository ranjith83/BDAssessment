using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDAssessment.BL
{
    public delegate void ProcessEventHandler(object sender, ProcessorEventArgs e); // Delegate Definition
    public class ProcessObservable
    {
        public event ProcessEventHandler ProcessMade; // Event Definition

        protected virtual void OnProcessMade(ProcessorEventArgs e)
        {
            if (ProcessMade != null)
                ProcessMade(this, e); // Raise the event 

        }
    }
    class ProcessorObserver
    {
        public int generateNumbers;
        public ProcessorObserver(ProcessObservable observable)
        {
            observable.ProcessMade += IdentifyBatchNumber;

        }

        public void IdentifyBatchNumber(Object sender, EventArgs e)
        {
            //Dont know the logic
        }

    }

    public class ProcessorEventArgs : EventArgs
    {
        public int iNumbers;
        public ProcessorEventArgs(int amt)
        {
            iNumbers = amt;
        }
    }

  
}
