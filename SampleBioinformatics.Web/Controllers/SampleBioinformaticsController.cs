using System.Web.Http;
using SampleBioinformatics.BusinessLogic;
using SampleBioinformatics.Interface;

namespace SampleBioinformatics.Web.Controllers
{
    public class SampleBioinformaticsController : ApiController
    {
        ISampleBioinformatics _sBio;

        public SampleBioinformaticsController()
        {
            Constructor(new Logic());
        }

        public SampleBioinformaticsController(ISampleBioinformatics sBio)
        {
            Constructor(sBio);
        }

        private void Constructor(ISampleBioinformatics sBio)
        {
            _sBio = sBio;
        }

        public string GetSuccess()
        {
            return _sBio.ReturnSuccess();
        }
    }
}