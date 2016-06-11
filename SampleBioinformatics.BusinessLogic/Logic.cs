using SampleBioinformatics.Interface;
using System.Collections.Generic;

namespace SampleBioinformatics.BusinessLogic
{
    public class Logic : ISampleBioinformatics
    {
        public string ReturnSuccess()
        {
            return "Success";
        }

        public DecodedDNA DecodeDNAString(string DNA)
        {
            string mRNA = "";
            string tRNA = "";
            List<string> Proteins = new List<string>();
            return new DecodedDNA(DNA, mRNA, tRNA, Proteins);
        }
    }
}