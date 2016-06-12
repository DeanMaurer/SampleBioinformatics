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
            var aminoAcids = new List<string>();
            if (DNA == "AAA" || DNA == "AAG")
                aminoAcids.Add("Lysine");
            else if (DNA == "TTT" || DNA == "TTC")
                aminoAcids.Add("Phenylalanine");
            else if (DNA == "TTA" || DNA == "TTG" || DNA == "CTT" || DNA == "CTC" || DNA == "CTA" || DNA == "CTG")
                aminoAcids.Add("Leucine");
            else if (DNA == "ATT" || DNA == "ATC" || DNA == "ATA")
                aminoAcids.Add("Isoleucine");
            else if (DNA == "ATG")
                aminoAcids.Add("Methionine");
            else if (DNA == "GTT" || DNA == "GTC" || DNA == "GTA" || DNA == "GTG")
                aminoAcids.Add("Valine");
            else if (DNA == "TCT" || DNA == "TCC" || DNA == "TCA" || DNA == "TCG" || DNA == "AGT" || DNA == "AGC")
                aminoAcids.Add("Serine");
            else if (DNA == "CCT" || DNA == "CCC" || DNA == "CCA" || DNA == "CCG")
                aminoAcids.Add("Proline");
            else if (DNA == "ACT" || DNA == "ACC" || DNA == "ACA" || DNA == "ACG")
                aminoAcids.Add("Threonine");
            else if (DNA == "GCT" || DNA == "GCC" || DNA == "GCA" || DNA == "GCG")
                aminoAcids.Add("Alanine");
            else if (DNA == "TAT" || DNA == "TAC")
                aminoAcids.Add("Tyrosine");
            else if (DNA == "TAA" || DNA == "TAG" || DNA == "TGA")
                aminoAcids.Add("Stop");
            else if (DNA == "CAT" || DNA == "CAC")
                aminoAcids.Add("Histidine");
            else if (DNA == "CAA" || DNA == "CAG")
                aminoAcids.Add("Glutamine");
            else if (DNA == "AAT" || DNA == "AAC")
                aminoAcids.Add("Asparagine");
            else if (DNA == "GAT" || DNA == "GAC")
                aminoAcids.Add("Aspartic acid");
            else if (DNA == "GAA" || DNA == "GAG")
                aminoAcids.Add("Glutamic acid");
            else if (DNA == "TGT" || DNA == "TGC")
                aminoAcids.Add("Cysteine");
            else if (DNA == "TGG")
                aminoAcids.Add("Tryptophan");
            else if (DNA == "CGT" || DNA == "CGC" || DNA == "CGA" || DNA == "CGG" || DNA == "AGA" || DNA == "AGG")
                aminoAcids.Add("Arginine");
            else if (DNA == "GGT" || DNA == "GGC" || DNA == "GGA" || DNA == "GGG")
                aminoAcids.Add("Glycine");

            return aminoAcids;
        }
    }
}