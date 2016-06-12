using System;
using System.Collections.Generic;

namespace SampleBioinformatics.Interface
{
    public class InvalidDNAException : Exception
    {
    }

    public interface ISampleBioinformatics
    {
        string ReturnSuccess();

        DecodedDNA DecodeDNA(string DNA);
    }

    public class DecodedDNA
    {
        public string DNA { get; private set; }
        public string mRNA { get; private set; }
        public string tRNA { get; private set; }
        public List<string> AminoAcids { get; private set; }

        public DecodedDNA(string DNA, string mRNA, string tRNA, List<string> AminoAcids)
        {
            this.DNA = DNA;
            this.mRNA = mRNA;
            this.tRNA = tRNA;
            this.AminoAcids = AminoAcids;
        }
    }
}
