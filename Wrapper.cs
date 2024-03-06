using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace FlipkartTest
{
    public class Wrapper
    {
        public static IWebElement FindElementByXpath(string XPath, WebDriver driver)
        {
            return driver.FindElement(By.XPath(XPath));
        }

        public static IWebElement FindElementByName(string name, WebDriver driver)
        {
            return driver.FindElement(By.Name(name));
        }

        public static void SwitchWindow(int index, WebDriver driver)
        {
            driver.SwitchTo().Window(driver.WindowHandles[index]);
        }

        public static ReadOnlyCollection<IWebElement> FindElementsByXpath(string selector, WebDriver driver)
        {
            return driver.FindElements(By.XPath(selector));
        }

        public static void ClickElement(IWebElement element)
        {
            element.Click();
        }

        public static void SendEnterKey(IWebElement element)
        {
            element.SendKeys(Keys.Enter);
        }

        public static void SendInput(string input,IWebElement element)
        {
            element.SendKeys(input);
        }

        public static void CloseDriver(WebDriver driver)
        {
            driver.Close();
        }

        public static void Refresh(WebDriver driver)
        {
            driver.Navigate().Refresh();
        }
    }
}