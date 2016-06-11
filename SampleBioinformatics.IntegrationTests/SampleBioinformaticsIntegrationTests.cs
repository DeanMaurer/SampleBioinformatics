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
        public void SuccessButtonDisplaysSuccess()
        {
            string expectedResponse = "Success";
            var successButton = _driver.FindElement(By.Id("success"));
            successButton.Click();

            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => drv.FindElement(By.Id("response")).Text == expectedResponse);

            var response = _driver.FindElement(By.Id("response"));

            Assert.AreEqual(expectedResponse, response.Text);
        }
    }
}
