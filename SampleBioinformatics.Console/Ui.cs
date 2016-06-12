using System;
using SampleBioinformatics.Interface;

namespace SampleBioinformatics.ConsoleApp
{
    internal static class Ui
    {
        internal static string InputRequest(string request)
        {
            Console.Write(request + " ");
            return Console.ReadLine();
        }

        internal static void Display(string item)
        {
            Console.WriteLine(item);
        }

        internal static void Display(DecodedDNA item)
        {
            Console.WriteLine("mRNA: " + item.mRNA);
            Console.WriteLine("mtNA: " + item.tRNA);
            Console.WriteLine("Amino Acids: ");
            foreach(var acid in item.AminoAcids)
            {
                Console.WriteLine("    " + acid);
            }
        }

        internal static void WaitForInput()
        {
            Console.ReadKey();
        }
    }
}
