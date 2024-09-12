using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace UnitTestProject1
{ 
    public class ApplyPage
    {
        public IWebDriver _driver;

        public ApplyPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public string applyPageUrl = "https://code-you.org/apply/";
        public IWebElement emailTextBox => _driver.FindElement(By.Id("tfa_215"));
        public IWebElement emailTextBoxXPath => _driver.FindElement(By.XPath("//input[@id='tfa_215']"));
        public IWebElement emailTextBoxXPath2 => _driver.FindElement(By.XPath("//div[@id='tfa_515']//following::input"));
        public IWebElement firstNameTextBox => _driver.FindElement(By.XPath("//input[@id='tfa_2']"));
        public IWebElement lastNameTextBox => _driver.FindElement(By.XPath("//input[@id='tfa_3']"));
        public IWebElement preferredNameTextBox => _driver.FindElement(By.XPath("//input[@title='Preferred Name ']"));
        public IWebElement phoneNumberTextBox => _driver.FindElement(By.Id("tfa_216"));
        public IWebElement birthDateTextBox => _driver.FindElement(By.Id("tfa_5"));
        public IWebElement streetNameTextBox => _driver.FindElement(By.Id("tfa_6"));
        public IWebElement cityTextBox => _driver.FindElement(By.Id("tfa_7"));
        public IWebElement stateDropdown => _driver.FindElement(By.Id("tfa_220"));
        public IWebElement zipCodeTextBox => _driver.FindElement(By.Id("tfa_9"));
        public IWebElement countyDropdown => _driver.FindElement(By.Id("tfa_59"));
        public IWebElement genderDropdown => _driver.FindElement(By.Id("tfa_30"));
        public IWebElement submitButton => _driver.FindElement(By.Id("submit_button"));

    }
}
