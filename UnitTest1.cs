using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UnitTestProject1
{

    [TestClass]
    public class UnitTest1
    {
        public IWebDriver _webDriver;
        public ApplyPage _applyPage;

        [TestInitialize]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
            _applyPage = new ApplyPage(_webDriver);
        }
        [TestMethod]
        public void TestMethod1()
        {
            _webDriver.Navigate().GoToUrl(_applyPage.applyPageUrl);
            _applyPage.emailTextBoxXPath2.SendKeys("email@test.com");
            _applyPage.firstNameTextBox.SendKeys("TestFirst");
            _applyPage.lastNameTextBox.SendKeys("TestLast");
            _applyPage.preferredNameTextBox.SendKeys("TestPreferred");
        }

        [TestCleanup]
        public void Cleanup()
        {
            _webDriver.Quit();
            _webDriver.Dispose();
        }
    }
}
