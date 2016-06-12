using SampleBioinformatics.Interface;
using System.Collections.Generic;

namespace SampleBioinformatics.UnitTests
{
    public class MockSampleBioinformaticsLogic : ISampleBioinformatics
    {
        public string ReturnSuccess()
        {
            return "Success";
        }

        public DecodedDNA DecodeDNA(string DNA)
        {
            var aminoAcids = new List<string>();
            aminoAcids.Add("Lysine");
            return new DecodedDNA("AAA", "UUU", "AAA", aminoAcids);
        }
    }
}
