using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class SeleniumHelpers
    {
        public IWebDriver _driver;
        public SeleniumHelpers(IWebDriver driver)
        {
            _driver = driver;
        }

        public void SelectTextFromDropdown(IWebElement element, string dropdownText)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByText(dropdownText);
        }

        public void SelectValueFromDropdown(IWebElement element, string dropdownValue)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByValue(dropdownValue);
        }

        public void SelectIndexFromDropdown(IWebElement element, int dropdownIndex)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByIndex(dropdownIndex);
        }

        public void clickButton(IWebElement element)
        {
            Actions a = new Actions(_driver);
            a.ScrollToElement(element).Click(element).Perform();
        }
    }
}
