using NUnit.Framework;
using System.Linq;
using SampleBioinformatics.BusinessLogic;
using SampleBioinformatics.Interface;
using System.Collections.Generic;

namespace SampleBioinformatics.UnitTests
{
    class AminoAcidEncodingTests
    {
        Logic _sbLogic = new Logic();

        [Test, Category("unit")]
        public void AlanineEncodedProperly()
        {
            var GCT = _sbLogic.DecodeDNA("GCT");
            var GCC = _sbLogic.DecodeDNA("GCC");
            var GCA = _sbLogic.DecodeDNA("GCA");
            var GCG = _sbLogic.DecodeDNA("GCG");

            Assert.AreEqual("Alanine", GCT.AminoAcids.Single());
            Assert.AreEqual("Alanine", GCC.AminoAcids.Single());
            Assert.AreEqual("Alanine", GCA.AminoAcids.Single());
            Assert.AreEqual("Alanine", GCG.AminoAcids.Single());
        }

        [Test, Category("unit")]
        public void ArginineEncodedProperly()
        {
            var CGT = _sbLogic.DecodeDNA("CGT");
            var CGC = _sbLogic.DecodeDNA("CGC");
            var CGA = _sbLogic.DecodeDNA("CGA");
            var CGG = _sbLogic.DecodeDNA("CGG");
            var AGA = _sbLogic.DecodeDNA("AGA");
            var AGG = _sbLogic.DecodeDNA("AGG");

            Assert.AreEqual("Arginine", CGT.AminoAcids.Single());
            Assert.AreEqual("Arginine", CGC.AminoAcids.Single());
            Assert.AreEqual("Arginine", CGA.AminoAcids.Single());
            Assert.AreEqual("Arginine", CGG.AminoAcids.Single());
            Assert.AreEqual("Arginine", AGA.AminoAcids.Single());
            Assert.AreEqual("Arginine", AGG.AminoAcids.Single());
        }

        [Test, Category("unit")]
        public void AsparagineEncodedProperly()
        {
            var AAT = _sbLogic.DecodeDNA("AAT");
            var AAC = _sbLogic.DecodeDNA("AAC");

            Assert.AreEqual("Asparagine", AAT.AminoAcids.Single());
            Assert.AreEqual("Asparagine", AAC.AminoAcids.Single());
        }

        [Test, Category("unit")]
        public void CysteineEncodedProperly()
        {
            var TGT = _sbLogic.DecodeDNA("TGT");
            var TGC = _sbLogic.DecodeDNA("TGC");

            Assert.AreEqual("Cysteine", TGT.AminoAcids.Single());
            Assert.AreEqual("Cysteine", TGC.AminoAcids.Single());
        }

        [Test, Category("unit")]
        public void GlutamineEncodedProperly()
        {
            var CAA = _sbLogic.DecodeDNA("CAA");
            var CAG = _sbLogic.DecodeDNA("CAG");

            Assert.AreEqual("Glutamine", CAA.AminoAcids.Single());
            Assert.AreEqual("Glutamine", CAG.AminoAcids.Single());
        }

        [Test, Category("unit")]
        public void GlycineEncodedProperly()
        {
            var GGT = _sbLogic.DecodeDNA("GGT");
            var GGC = _sbLogic.DecodeDNA("GGC");
            var GGA = _sbLogic.DecodeDNA("GGA");
            var GGG = _sbLogic.DecodeDNA("GGG");

            Assert.AreEqual("Glycine", GGT.AminoAcids.Single());
            Assert.AreEqual("Glycine", GGC.AminoAcids.Single());
            Assert.AreEqual("Glycine", GGA.AminoAcids.Single());
            Assert.AreEqual("Glycine", GGG.AminoAcids.Single());
        }

        [Test, Category("unit")]
        public void HistidineEncodedProperly()
        {
            var CAT = _sbLogic.DecodeDNA("CAT");
            var CAC = _sbLogic.DecodeDNA("CAC");

            Assert.AreEqual("Histidine", CAT.AminoAcids.Single());
            Assert.AreEqual("Histidine", CAC.AminoAcids.Single());
        }

        [Test, Category("unit")]
        public void IsoleucineEncodedProperly()
        {
            var ATT = _sbLogic.DecodeDNA("ATT");
            var ATC = _sbLogic.DecodeDNA("ATC");
            var ATA = _sbLogic.DecodeDNA("ATA");

            Assert.AreEqual("Isoleucine", ATT.AminoAcids.Single());
            Assert.AreEqual("Isoleucine", ATC.AminoAcids.Single());
            Assert.AreEqual("Isoleucine", ATA.AminoAcids.Single());
        }

        [Test, Category("unit")]
        public void LeucineEncodedProperly()
        {
            var TTA = _sbLogic.DecodeDNA("TTA");
            var TTG = _sbLogic.DecodeDNA("TTG");
            var CTT = _sbLogic.DecodeDNA("CTT");
            var CTC = _sbLogic.DecodeDNA("CTC");
            var CTA = _sbLogic.DecodeDNA("CTA");
            var CTG = _sbLogic.DecodeDNA("CTG");

            Assert.AreEqual("Leucine", TTA.AminoAcids.Single());
            Assert.AreEqual("Leucine", TTG.AminoAcids.Single());
            Assert.AreEqual("Leucine", CTT.AminoAcids.Single());
            Assert.AreEqual("Leucine", CTC.AminoAcids.Single());
            Assert.AreEqual("Leucine", CTA.AminoAcids.Single());
            Assert.AreEqual("Leucine", CTG.AminoAcids.Single());
        }

        [Test, Category("unit")]
        public void LysineEncodedProperly()
        {
            var AAA = _sbLogic.DecodeDNA("AAA");
            var AAG = _sbLogic.DecodeDNA("AAG");

            Assert.AreEqual("Lysine", AAA.AminoAcids.Single());
            Assert.AreEqual("Lysine", AAG.AminoAcids.Single());
        }

        [Test, Category("unit")]
        public void PhenylalanineEncodedProperly()
        {
            var TTT = _sbLogic.DecodeDNA("TTT");
            var TTC = _sbLogic.DecodeDNA("TTC");

            Assert.AreEqual("Phenylalanine", TTT.AminoAcids.Single());
            Assert.AreEqual("Phenylalanine", TTC.AminoAcids.Single());
        }

        [Test, Category("unit")]
        public void ProlineEncodedProperly()
        {
            var CCT = _sbLogic.DecodeDNA("CCT");
            var CCC = _sbLogic.DecodeDNA("CCC");
            var CCA = _sbLogic.DecodeDNA("CCA");
            var CCG = _sbLogic.DecodeDNA("CCG");

            Assert.AreEqual("Proline", CCT.AminoAcids.Single());
            Assert.AreEqual("Proline", CCC.AminoAcids.Single());
            Assert.AreEqual("Proline", CCA.AminoAcids.Single());
            Assert.AreEqual("Proline", CCG.AminoAcids.Single());
        }

        [Test, Category("unit")]
        public void SerineEncodedProperly()
        {
            var TCT = _sbLogic.DecodeDNA("TCT");
            var TCC = _sbLogic.DecodeDNA("TCC");
            var TCA = _sbLogic.DecodeDNA("TCA");
            var TCG = _sbLogic.DecodeDNA("TCG");
            var AGT = _sbLogic.DecodeDNA("AGT");
            var AGC = _sbLogic.DecodeDNA("AGC");

            Assert.AreEqual("Serine", TCT.AminoAcids.Single());
            Assert.AreEqual("Serine", TCC.AminoAcids.Single());
            Assert.AreEqual("Serine", TCA.AminoAcids.Single());
            Assert.AreEqual("Serine", TCG.AminoAcids.Single());
            Assert.AreEqual("Serine", AGT.AminoAcids.Single());
            Assert.AreEqual("Serine", AGC.AminoAcids.Single());
        }

        [Test, Category("unit")]
        public void ThreonineEncodedProperly()
        {
            var ACT = _sbLogic.DecodeDNA("ACT");
            var ACC = _sbLogic.DecodeDNA("ACC");
            var ACA = _sbLogic.DecodeDNA("ACA");
            var ACG = _sbLogic.DecodeDNA("ACG");

            Assert.AreEqual("Threonine", ACT.AminoAcids.Single());
            Assert.AreEqual("Threonine", ACC.AminoAcids.Single());
            Assert.AreEqual("Threonine", ACA.AminoAcids.Single());
            Assert.AreEqual("Threonine", ACG.AminoAcids.Single());
        }

        [Test, Category("unit")]
        public void TryptophanEncodedProperly()
        {
            var TGG = _sbLogic.DecodeDNA("TGG");

            Assert.AreEqual("Tryptophan", TGG.AminoAcids.Single());
        }

        [Test, Category("unit")]
        public void TyrosineEncodedProperly()
        {
            var TAT = _sbLogic.DecodeDNA("TAT");
            var TAC = _sbLogic.DecodeDNA("TAC");

            Assert.AreEqual("Tyrosine", TAT.AminoAcids.Single());
            Assert.AreEqual("Tyrosine", TAC.AminoAcids.Single());
        }

        [Test, Category("unit")]
        public void ValineEncodedProperly()
        {
            var GTT = _sbLogic.DecodeDNA("GTT");
            var GTC = _sbLogic.DecodeDNA("GTC");
            var GTA = _sbLogic.DecodeDNA("GTA");
            var GTG = _sbLogic.DecodeDNA("GTG");

            Assert.AreEqual("Valine", GTT.AminoAcids.Single());
            Assert.AreEqual("Valine", GTC.AminoAcids.Single());
            Assert.AreEqual("Valine", GTA.AminoAcids.Single());
            Assert.AreEqual("Valine", GTG.AminoAcids.Single());
        }

        [Test, Category("unit")]
        public void AsparticAcidEncodedProperly()
        {
            var GAT = _sbLogic.DecodeDNA("GAT");
            var GAC = _sbLogic.DecodeDNA("GAC");

            Assert.AreEqual("Aspartic acid", GAT.AminoAcids.Single());
            Assert.AreEqual("Aspartic acid", GAC.AminoAcids.Single());
        }

        [Test, Category("unit")]
        public void GlutamicAcidEncodedProperly()
        {
            var GAA = _sbLogic.DecodeDNA("GAA");
            var GAG = _sbLogic.DecodeDNA("GAG");

            Assert.AreEqual("Glutamic acid", GAA.AminoAcids.Single());
            Assert.AreEqual("Glutamic acid", GAG.AminoAcids.Single());
        }

        [Test, Category("unit")]
        public void StopEncodedProperly()
        {
            var TAA = _sbLogic.DecodeDNA("TAA");
            var TGA = _sbLogic.DecodeDNA("TGA");
            var TAG = _sbLogic.DecodeDNA("TAG");

            Assert.AreEqual("Stop", TAA.AminoAcids.Single());
            Assert.AreEqual("Stop", TGA.AminoAcids.Single());
            Assert.AreEqual("Stop", TAG.AminoAcids.Single());
        }

        [Test, Category("unit")]
        public void ATGEncodesStartIfFirst()
        {
            var ATG = _sbLogic.DecodeDNA("ATG");

            Assert.AreEqual("Start", ATG.AminoAcids.Single());
        }

        [Test, Category("unit")]
        public void MethionineEncodedProperly()
        {
            var ATG = _sbLogic.DecodeDNA("ATGATG");

            Assert.AreEqual("Methionine", ATG.AminoAcids.ElementAt(1));
        }
    }
}
