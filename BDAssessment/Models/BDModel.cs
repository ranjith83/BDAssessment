using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDAssessment.Models
{
    public class BatchProcess
    {
        //public int RemainingNumbers { get; set; }
        public int MultiplyResult { get; set; }
        //public int TotalBatches { get; set; }

    }

    public class MultiplyNumbers
    {
        //public int RemainingNumbers { get; set; }
        public int MultiplyResult { get; set; }
        //public int TotalBatches { get; set; }

    }

    public class MultiplResult
    {
        public int ToMultiply { get; set; }
        public int MultipliedResult { get; set; }

    }

    public class GenerateResult
    {
        public int Id { get; set; }
        public List<int> RandomResult { get; set; }

    }
}
