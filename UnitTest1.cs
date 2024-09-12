using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

namespace UnitTestProject1
{

    [TestClass]
    public class UnitTest1
    {
        public IWebDriver _webDriver;
        public ApplyPage _applyPage;
        public SeleniumHelpers _seleniumHelpers;

        [TestInitialize]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
            _applyPage = new ApplyPage(_webDriver);
            _seleniumHelpers = new SeleniumHelpers(_webDriver);
        }
        [TestMethod]
        public void TestMethod1()
        {
            _webDriver.Navigate().GoToUrl(_applyPage.applyPageUrl);
            _applyPage.emailTextBoxXPath2.SendKeys("email@test.com");
            _applyPage.firstNameTextBox.SendKeys("TestFirst");
            _applyPage.lastNameTextBox.SendKeys("TestLast");
            _applyPage.preferredNameTextBox.SendKeys("TestPreferred");
            _applyPage.phoneNumberTextBox.SendKeys("5026896946");
            _applyPage.birthDateTextBox.SendKeys("03171989");
            _applyPage.streetNameTextBox.SendKeys("2749 Cleveland Blvd");
            _applyPage.cityTextBox.SendKeys("Louisville");
            _seleniumHelpers.SelectTextFromDropdown(_applyPage.stateDropdown, "KY");
            _applyPage.zipCodeTextBox.SendKeys("40206");
            _seleniumHelpers.SelectValueFromDropdown(_applyPage.countyDropdown, "tfa_1242");
            _seleniumHelpers.SelectIndexFromDropdown(_applyPage.genderDropdown, 3);
            _seleniumHelpers.clickButton(_applyPage.submitButton);

        }

        [TestCleanup]
        public void Cleanup()
        {
            _webDriver.Quit();
            _webDriver.Dispose();
        }
    }
}
