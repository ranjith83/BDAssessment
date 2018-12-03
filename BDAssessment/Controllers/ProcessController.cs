using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BDAssessment.BL;
using BDAssessment.Models;

namespace BDAssessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessController : Controller
    {
        [HttpGet("[action]")]
        public async Task<List<GenerateResult>> GenerateNumbers([FromQuery] int batch, int processNumbers)
        {
            List<BatchProcess> batchProcessList = new List<BatchProcess>();
            //GeneratorManager will request the number 
            GenerateManager generateManager = new GenerateManager();
            var nResult = await Task.Run(()=> generateManager.Generate(2, 3));

            //foreach (var item in nResult)
            //{
            //    BatchProcess batchProcess = new BatchProcess();
            //    batchProcess.MultiplyResult = item;
            //    batchProcessList.Add(batchProcess);
            //}
            return nResult;
        }

        [HttpGet("[action]")]
        public async Task<MultiplResult[]> MultipliedNumbers([FromQuery] string multiplyNos)
        {
            //TODO: Need to handle in WepAPI using Promise or Observable.
            var mul = multiplyNos.Replace("[", "").Replace("]", "").Split(",").ToList();
            var mulArray = mul.Select(int.Parse).ToList();

            List<int> toMultiply = new List<int>();
            List<BatchProcess> batchProcessList = new List<BatchProcess>();

            //MultipleManager will multiple the number 
            MultipleManager multipleManager = new MultipleManager();
            var nResult = await Task.Run(() => multipleManager.MultiplyNumber(mulArray));

            //foreach (var item in nResult)
            //{
            //    MultiplResult batchProcess = new BatchProcess();
            //    batchProcess.MultiplyResult = item;
            //    batchProcessList.Add(batchProcess);
            //}
            return nResult.ToArray();
        }
        

    }
}
