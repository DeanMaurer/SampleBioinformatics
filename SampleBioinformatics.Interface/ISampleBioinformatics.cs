

using System.Collections.Generic;

namespace SampleBioinformatics.Interface
{
    public interface ISampleBioinformatics
    {
        string ReturnSuccess();
    }

    public class DecodedDNA
    {
        public string DNA { get; private set; }
        public string mRNA { get; private set; }
        public string tRNA { get; private set; }
        public List<string> Proteins { get; private set; }

        public DecodedDNA(string DNA, string mRNA, string tRNA, List<string> Proteins)
        {
            this.DNA = DNA;
            this.mRNA = mRNA;
            this.tRNA = tRNA;
            this.Proteins = Proteins;
        }
    }
}
