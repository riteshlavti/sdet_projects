using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace FlipkartTest
{
    public class Wrapper : Base
    {
        public static void ClickElement(IWebElement webElement)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(webElement)).Click();
        }

        public static void CloseTab(WebDriver webDriver)
        {
            webDriver.Close();
        }

        public static void SendInput(IWebElement webElement,string input)
        {
            webElement.SendKeys(input);
        }

        public static void SendEnterKey(IWebElement webElement)
        {
            webElement.SendKeys(Keys.Enter);
        }

        public static void RefreshTab(WebDriver webDriver)
        {
            webDriver.Navigate().Refresh();
        }

        public static IWebElement FindElement(IWebElement webElement,string input)
        {
            return webElement.FindElement(By.XPath(input));
        }
    }
}