﻿using NUnit.Framework;
using SampleBioinformatics.Web.Controllers;

namespace SampleBioinformatics.UnitTests
{
    class SampleBioinformaticsControllerTests
    {
        [Test, Category("unit")]
        public void GetSuccessReturnsSuccess()
        {
            var controller = new SampleBioinformaticsController(new MockSampleBioinformaticsLogic());

            var result = controller.GetSuccess();

            Assert.AreEqual("Success", result);
        }
    }
}
