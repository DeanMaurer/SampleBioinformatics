using SampleBioinformatics.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBioinformatics.BusinessLogic
{
    public class Logic : ISampleBioinformatics
    {
        public string ReturnSuccess()
        {
            return "Success";
        }
    }
}
