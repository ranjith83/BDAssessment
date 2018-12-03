using Microsoft.VisualStudio.TestTools.UnitTesting;
using BDAssessment.BL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BDMedicalUnitTest
{
    [TestClass]
    public class ManageProcessUnitTest
    {
        [TestMethod]
        public async Task GernerateManagerTest()
        {
            GenerateManager generateManager = new GenerateManager();
            var result = await Task.Run(() => generateManager.Generate(2, 3));

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task  MultiplyManagerTest()
        {
            List<int> listNum = new List<int>() { 1, 2};
            MultipleManager multipleManager = new MultipleManager();
            var result = await Task.Run(()=> multipleManager.MultiplyNumber(listNum));

            Assert.IsNotNull(result);
        }
    }
}
