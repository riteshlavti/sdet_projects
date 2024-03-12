using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TestProject
{
    public class SeleniumWrapper
    {
        protected WebDriver webDriver;
        protected WebDriverWait wait;
        public SeleniumWrapper(WebDriver webDriver, WebDriverWait wait)
        {
            this.webDriver = webDriver;
            this.wait = wait;
        }

        public SeleniumWrapper(WebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public void ClickElement(IWebElement webElement)
        {
            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(webElement)).Click();
            }
            catch (StaleElementReferenceException)
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(webElement)).Click();
            }
        }

        public void CloseTab()
        {
            webDriver.Close();
        }

        public void SendInput(IWebElement webElement, string input)
        {
            webElement.SendKeys(input);
        }

        public void SendEnterKey(IWebElement webElement)
        {
            webElement.SendKeys(Keys.Enter);
        }

        public void RefreshTab()
        {
            webDriver.Navigate().Refresh();
        }

        public IWebElement FindElement(IWebElement webElement, string input)
        {
            return webElement.FindElement(By.XPath(input));
        }

        public void SwitchToWindow(int i)
        {
            webDriver.SwitchTo().Window(webDriver.WindowHandles[i]);
        }

        public IWebElement IsElementVisible(IWebElement webElement)
        {
            return wait.Until(ExpectedConditions.ElementToBeClickable(webElement));
        }

        public bool IsElementExists(IWebElement element)
        {
            try
            {
                bool value = element.Enabled;
                return value;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}