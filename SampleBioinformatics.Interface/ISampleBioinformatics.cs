using System;
using System.Collections.Generic;

namespace SampleBioinformatics.Interface
{
    public class InvalidDNAException : Exception
    {
    }

    public interface ISampleBioinformatics
    {
        DecodedDNA DecodeDNA(string DNA);
    }

    // This object is immutable so that I don't have to think about the possibility of
    // something changing it when it shouldn't be changed.
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
