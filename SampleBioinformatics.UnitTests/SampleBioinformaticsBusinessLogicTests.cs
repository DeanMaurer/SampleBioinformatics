using NUnit.Framework;
using SampleBioinformatics.BusinessLogic;

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
    }
}
