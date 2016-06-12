using NUnit.Framework;
using SampleBioinformatics.BusinessLogic;
using SampleBioinformatics.Interface;
using System.Collections.Generic;

namespace SampleBioinformatics.UnitTests
{
    [TestFixture]
    class BusinessLogicTests
    {
        Logic _sbLogic = new Logic();

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

        [Test, Category("unit")]
        public void CanDecodeaagLysine()
        {
            var result = _sbLogic.DecodeDNA("aag");

            var expectedAminoAcids = new List<string>();
            expectedAminoAcids.Add("Lysine");

            Assert.AreEqual("AAG", result.DNA);
            Assert.AreEqual("UUC", result.mRNA);
            Assert.AreEqual("AAG", result.tRNA);
            Assert.AreEqual(expectedAminoAcids, result.AminoAcids);
        }

        [Test, Category("unit")]
        public void CanDecodeAACAsparagine()
        {
            var result = _sbLogic.DecodeDNA("AAC");

            var expectedAminoAcids = new List<string>();
            expectedAminoAcids.Add("Asparagine");

            Assert.AreEqual("AAC", result.DNA);
            Assert.AreEqual("UUG", result.mRNA);
            Assert.AreEqual("AAC", result.tRNA);
            Assert.AreEqual(expectedAminoAcids, result.AminoAcids);
        }

        [Test, Category("unit")]
        public void DnaMustBeModThree()
        {
            bool caughtInvalidDNAException = false;
            try
            {
                var result = _sbLogic.DecodeDNA("ATCG");
            }
            catch(InvalidDNAException)
            {
                caughtInvalidDNAException = true;
            }

            Assert.IsTrue(caughtInvalidDNAException, "String length needs to be mod 3");
        }

        [Test, Category("unit")]
        public void DnaMustConsistOfValidBases()
        {
            bool caughtInvalidDNAException = false;
            try
            {
                var result = _sbLogic.DecodeDNA("NOTDNA");
            }
            catch (InvalidDNAException)
            {
                caughtInvalidDNAException = true;
            }

            Assert.IsTrue(caughtInvalidDNAException, "Only A T C G are valid bases");
        }
    }
}
