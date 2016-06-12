using SampleBioinformatics.Interface;
using System.Collections.Generic;

namespace SampleBioinformatics.BusinessLogic
{

    internal static class AminoAcidEncodings
    {
        internal static List<string> GetFromDNA(string DNA)
        {
            return ParseDNA(DNA, true);
        }

        private static List<string> ParseDNA(string DNA, bool isStart)
        {
            var aminoAcids = new List<string>();

            string codon = TryToMakeCodon(DNA);
            aminoAcids.Add(GetFromCodon(codon, isStart));

            if (DNA.Length > 3)
            {
                var remainingDNA = DNA.Substring(3);
                aminoAcids.AddRange(ParseDNA(remainingDNA, false));
            }

            return aminoAcids;
        }

        private static string TryToMakeCodon(string DNA)
        {
            if (DNA.Length < 3)
                throw new InvalidDNAException();
            else
                return DNA.Substring(0, 3);
        }

        private static string GetFromCodon(string codon, bool isStart)
        {
            if (codon == "AAA" || codon == "AAG")
                return "Lysine";
            else if (codon == "TTT" || codon == "TTC")
                return "Phenylalanine";
            else if (codon == "TTA" || codon == "TTG" || codon == "CTT" || codon == "CTC" || codon == "CTA" || codon == "CTG")
                return "Leucine";
            else if (codon == "ATT" || codon == "ATC" || codon == "ATA")
                return "Isoleucine";
            else if (codon == "ATG")
            {
                if (isStart)
                    return "Start";
                else
                    return "Methionine";
            }
            else if (codon == "GTT" || codon == "GTC" || codon == "GTA" || codon == "GTG")
                return "Valine";
            else if (codon == "TCT" || codon == "TCC" || codon == "TCA" || codon == "TCG" || codon == "AGT" || codon == "AGC")
                return "Serine";
            else if (codon == "CCT" || codon == "CCC" || codon == "CCA" || codon == "CCG")
                return "Proline";
            else if (codon == "ACT" || codon == "ACC" || codon == "ACA" || codon == "ACG")
                return "Threonine";
            else if (codon == "GCT" || codon == "GCC" || codon == "GCA" || codon == "GCG")
                return "Alanine";
            else if (codon == "TAT" || codon == "TAC")
                return "Tyrosine";
            else if (codon == "TAA" || codon == "TAG" || codon == "TGA")
                return "Stop";
            else if (codon == "CAT" || codon == "CAC")
                return "Histidine";
            else if (codon == "CAA" || codon == "CAG")
                return "Glutamine";
            else if (codon == "AAT" || codon == "AAC")
                return "Asparagine";
            else if (codon == "GAT" || codon == "GAC")
                return "Aspartic acid";
            else if (codon == "GAA" || codon == "GAG")
                return "Glutamic acid";
            else if (codon == "TGT" || codon == "TGC")
                return "Cysteine";
            else if (codon == "TGG")
                return "Tryptophan";
            else if (codon == "CGT" || codon == "CGC" || codon == "CGA" || codon == "CGG" || codon == "AGA" || codon == "AGG")
                return "Arginine";
            else if (codon == "GGT" || codon == "GGC" || codon == "GGA" || codon == "GGG")
                return "Glycine";
            else
                throw new InvalidDNAException();
        }
    }
}
