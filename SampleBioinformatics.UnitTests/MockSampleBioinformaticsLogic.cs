using SampleBioinformatics.Interface;

namespace SampleBioinformatics.UnitTests
{
    public class MockSampleBioinformaticsLogic : ISampleBioinformatics
    {
        public string ReturnSuccess()
        {
            return "Success";
        }
    }
}
