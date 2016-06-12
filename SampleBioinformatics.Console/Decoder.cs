using SampleBioinformatics.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBioinformatics.ConsoleApp
{
    internal class Decoder
    {
        ISampleBioinformatics _bio;

        internal Decoder(ISampleBioinformatics bio)
        {
            _bio = bio;
        }

        internal DecodedDNA Decode(string dna)
        {
            return _bio.DecodeDNA(dna);
        }
    }
}
