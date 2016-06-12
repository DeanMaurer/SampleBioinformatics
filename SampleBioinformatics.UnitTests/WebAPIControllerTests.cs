using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using SampleBioinformatics.Web.Controllers;
using System.Collections.Generic;

namespace SampleBioinformatics.UnitTests
{
    class WebAPIControllerTests
    {
        SampleBioinformaticsController _controller = new SampleBioinformaticsController(new MockBusinessLogic());

        [Test, Category("unit")]
        public void GetDNADecodedReturnsJson()
        {
            var result = _controller.GetDNADecoded("AAA");

            var aminoAcids = new List<string>();
            aminoAcids.Add("Lysine");
            var expectedJson = JObject.Parse(JsonConvert.SerializeObject(new { DNA = "AAA", mRNA = "UUU", tRNA = "AAA", AminoAcids = aminoAcids }));

            Assert.AreEqual(expectedJson, result);
        }

        [Test, Category("unit")]
        public void PresentsUsefulMessageWhenDNAIsInvalid()
        {
            var exceptionController = new SampleBioinformaticsController(new MockSampleBioinformaticsLogicThrowsInvalidDNAException());

            var result = exceptionController.GetDNADecoded("AAA");

            var expectedJson = JObject.Parse(JsonConvert.SerializeObject(new { Error = "The DNA provided is not valid." }));

            Assert.AreEqual(expectedJson, result);
        }
    }
}
