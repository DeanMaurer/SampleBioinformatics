using System.Web.Http;
using SampleBioinformatics.BusinessLogic;
using SampleBioinformatics.Interface;
using Newtonsoft.Json;

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

        public string GetDNADecoded(string DNA)
        {
            try
            {
                var decodedDNA = _sBio.DecodeDNA(DNA);
                return JsonConvert.SerializeObject(decodedDNA);
            }
            catch(InvalidDNAException)
            {
                return JsonConvert.SerializeObject(new { Error = "The DNA provided is not valid." });
            }
        }
    }
}