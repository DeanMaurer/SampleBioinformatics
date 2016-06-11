using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SampleBioinformatics.UnitTests
{
    [TestFixture]
    class SampleBioinformaticsUnitTests
    {
        [Test, Category("unit")]
        public void AlwaysPass()
        {
            Assert.IsTrue(true);
        }
    }
}
