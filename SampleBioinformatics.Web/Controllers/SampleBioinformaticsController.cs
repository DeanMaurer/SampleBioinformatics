using System.Web.Http;
using SampleBioinformatics.BusinessLogic;
using SampleBioinformatics.Interface;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

        public JObject GetDNADecoded(string DNA)
        {
            try
            {
                var decodedDNA = _sBio.DecodeDNA(DNA);
                return JObject.Parse(JsonConvert.SerializeObject(decodedDNA));
            }
            catch(InvalidDNAException)
            {
                return JObject.Parse(JsonConvert.SerializeObject(new { Error = "The DNA provided is not valid." }));
            }
        }
    }
}