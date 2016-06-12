using Newtonsoft.Json;
using NUnit.Framework;
using SampleBioinformatics.Web.Controllers;
using System.Collections.Generic;

namespace SampleBioinformatics.UnitTests
{
    class SampleBioinformaticsWebAPIControllerTests
    {
        SampleBioinformaticsController _controller = new SampleBioinformaticsController(new MockSampleBioinformaticsLogic());

        [Test, Category("unit")]
        public void GetSuccessReturnsSuccess()
        {
            var result = _controller.GetSuccess();

            Assert.AreEqual("Success", result);
        }

        [Test, Category("unit")]
        public void GetDNADecodedReturnsJson()
        {
            var result = _controller.GetDNADecoded("AAA");

            var aminoAcids = new List<string>();
            aminoAcids.Add("Lysine");
            var expectedJson = JsonConvert.SerializeObject(new { DNA = "AAA", mRNA = "UUU", tRNA = "AAA", AminoAcids = aminoAcids });

            Assert.AreEqual(expectedJson, result);
        }
    }
}
