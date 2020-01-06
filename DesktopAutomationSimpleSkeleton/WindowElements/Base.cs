using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;

namespace DesktopAutomationSimpleSkeleton
{
    public class Base
    {
        protected static WindowsDriver<WindowsElement> AppDriver;

        //public Base(WindowsElement AppDriver)
        //{
        //    this.AppDriver = AppDriver;
        //}
        public void ClickOnElementByName(string element)
        {
            FindElementByName(element).Click();
        }

        public void ClickOn(By selectorType)
        {
            FindElement(selectorType).Click();
        }

        private WindowsElement FindElement(By selectorType)
        {
           // WaitForElementOnPage(selectorType);
            return AppDriver.FindElement(selectorType);
        }
        private WindowsElement FindElementByName(string element)
        {
            // WaitForElementOnPage(selectorType);
            return AppDriver.FindElementByClassName(element);
        }
    }
}
