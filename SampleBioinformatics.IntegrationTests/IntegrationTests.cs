using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace SampleBioinformatics.IntegrationTests
{

    public class IntegrationTests
    {
        private IWebDriver _driver;
        private string _url = "http://samplebioinformatics20160605063635.azurewebsites.net/";

        [SetUp]
        protected void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Url = _url;
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            _driver.Manage().Window.Maximize();
        }

        [TearDown]
        protected void TearDown()
        {
            _driver.Quit();
        }

        [Test, Category("integration")]
        public void PageHeaderExists()
        {
            var header = _driver.FindElement(By.Id("title"));
            Assert.AreEqual("DNA Decoder", header.Text);
        }

        [Test, Category("integration")]
        public void DecodedStringAAADisplaysAsExpected()
        {
            string mRNAExpected = "mRNA: UUU";
            string tRNAExpected = "tRNA: AAA";
            string aminoAcidExpected = "Amino Acid 1: Lysine";

            // Enter a DNA string
            var dnaTextBox = _driver.FindElement(By.Name("DNA"));
            dnaTextBox.SendKeys("AAA");

            // Submit the query
            var decodeButton = _driver.FindElement(By.Id("decodeBtn"));
            decodeButton.Click();

            // Wait for a response
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            wait.Until(drv => drv.FindElement(By.Id("mRNA")).Text != "");

            // Parse the response
            var mRNAResponse = _driver.FindElement(By.Id("mRNA"));
            var tRNAResponse = _driver.FindElement(By.Id("tRNA"));
            var aminoAcidResponse = _driver.FindElement(By.Id("acid"));

            Assert.AreEqual(mRNAExpected, mRNAResponse.Text);
            Assert.AreEqual(tRNAExpected, tRNAResponse.Text);
            Assert.AreEqual(aminoAcidExpected, aminoAcidResponse.Text);
        }
    }
}
