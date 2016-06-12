using SampleBioinformatics.BusinessLogic;
using SampleBioinformatics.Interface;
using System;

namespace SampleBioinformatics.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var decoder = new Decoder(new Logic());

            Ui.Display(decoder.Decode(Ui.InputRequest("Enter a DNA string:")));

            Ui.Display("Press enter to end");
            Ui.WaitForInput();

            
        }
    }
}
