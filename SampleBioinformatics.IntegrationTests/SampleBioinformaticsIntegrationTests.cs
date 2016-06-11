using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SampleBioinformatics.IntegrationTests
{

    public class SampleBioinformaticsIntegrationTests
    {
        private IWebDriver _driver;
        private string _url = "http://samplebioinformatics20160605063635.azurewebsites.net/";

        [SetUp]
        protected void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Url = _url;
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void PageHeaderExists()
        {
            var header = _driver.FindElement(By.TagName("h2"));
            Assert.AreEqual("Sample Bioinformatics Home Page", header.Text);
        }

        [TearDown]
        protected void TearDown()
        {
            _driver.Quit();
        }
    }
}
