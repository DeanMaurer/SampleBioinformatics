using SampleBioinformatics.Interface;
using System.Collections.Generic;
using System;

namespace SampleBioinformatics.BusinessLogic
{
    public class Logic : ISampleBioinformatics
    {
        public string ReturnSuccess()
        {
            return "Success";
        }

        public DecodedDNA DecodeDNA(string DNA)
        {
            DNA = DNA.ToUpper();
            string mRNA = GetmRNAFromDNA(DNA);
            string tRNA = GettRNAFromDNA(DNA);
            List<string> AminoAcids = GetAminoAcidsFromDNA(DNA);
            return new DecodedDNA(DNA, mRNA, tRNA, AminoAcids);
        }

        private string GetmRNAFromDNA(string DNA)
        {
            string mRNA = "";
            foreach(char b in DNA)
            {
                if (b == 'A')
                    mRNA += "U";
                else if (b == 'T')
                    mRNA += "A";
                else if (b == 'C')
                    mRNA += "G";
                else if (b == 'G')
                    mRNA += "C";
            }
            return mRNA;
        }

        private string GettRNAFromDNA(string DNA)
        {
            string tRNA = "";
            foreach (char b in DNA)
            {
                if (b == 'A')
                    tRNA += "A";
                else if (b == 'T')
                    tRNA += "U";
                else if (b == 'C')
                    tRNA += "C";
                else if (b == 'G')
                    tRNA += "G";
            }
            return tRNA;
        }

        private List<string> GetAminoAcidsFromDNA(string DNA)
        {
            return AminoAcidEncodings.GetFromDNA(DNA);
        }
    }
}