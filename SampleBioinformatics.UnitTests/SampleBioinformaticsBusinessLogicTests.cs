using NUnit.Framework;
using SampleBioinformatics.BusinessLogic;
using System.Collections.Generic;

namespace SampleBioinformatics.UnitTests
{
    [TestFixture]
    class SampleBioinformaticsBusinessLogicTests
    {
        Logic _sbLogic = new Logic();

        [Test, Category("unit")]
        public void CanReturnSuccess()
        {
            string success = _sbLogic.ReturnSuccess();
            Assert.AreEqual("Success", success);
        }

        [Test, Category("unit")]
        public void CanDecodeEmptyString()
        {
            var result = _sbLogic.DecodeDNAString("");

            Assert.AreEqual("", result.DNA);
            Assert.AreEqual("", result.mRNA);
            Assert.AreEqual("", result.tRNA);
            Assert.AreEqual(new List<string>(), result.AminoAcids);
        }
    }
}
