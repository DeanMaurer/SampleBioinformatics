using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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

        [TearDown]
        protected void TearDown()
        {
            _driver.Quit();
        }

        [Test, Category("integration")]
        public void PageHeaderExists()
        {
            var header = _driver.FindElement(By.TagName("h2"));
            Assert.AreEqual("Sample Bioinformatics Home Page", header.Text);
        }

        [Test, Category("integration")]
        public void DecodedStringAAADisplaysAsExpected()
        {
            string expectedResponse = "{\"DNA\":\"AAA\",\"mRNA\":\"UUU\",\"tRNA\":\"AAA\",\"AminoAcids\":[\"Lysine\"]}";

            var dnaTextBox = _driver.FindElement(By.Name("DNA"));
            dnaTextBox.SendKeys("AAA");

            var decodeButton = _driver.FindElement(By.Id("decodeBtn"));
            decodeButton.Click();

            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => drv.FindElement(By.Id("decodedInfo")).Text == expectedResponse);

            var response = _driver.FindElement(By.Id("decodedInfo"));

            Assert.AreEqual(expectedResponse, response.Text);
        }
    }
}
