using NUnit.Framework;
using SampleBioinformatics.BusinessLogic;
using SampleBioinformatics.Interface;
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
        public void CanDecodeAAALysine()
        {
            var result = _sbLogic.DecodeDNA("AAA");

            var expectedAminoAcids = new List<string>();
            expectedAminoAcids.Add("Lysine");

            Assert.AreEqual("AAA", result.DNA);
            Assert.AreEqual("UUU", result.mRNA);
            Assert.AreEqual("AAA", result.tRNA);
            Assert.AreEqual(expectedAminoAcids, result.AminoAcids);
        }

        [Test, Category("unit")]
        public void CanDecodeAAGLysine()
        {
            var result = _sbLogic.DecodeDNA("AAG");

            var expectedAminoAcids = new List<string>();
            expectedAminoAcids.Add("Lysine");

            Assert.AreEqual("AAG", result.DNA);
            Assert.AreEqual("UUC", result.mRNA);
            Assert.AreEqual("AAG", result.tRNA);
            Assert.AreEqual(expectedAminoAcids, result.AminoAcids);
        }
    }
}
