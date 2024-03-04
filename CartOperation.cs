using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FlipkartTest
{
    public class CartOperation
    {
        public static void AddToCart(WebDriver driver, string query)
        {
            var handles = driver.WindowHandles;

            driver.SwitchTo().Window(handles[0]);

            driver.FindElement(By.Name("q")).Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript($"arguments[0].value = {query};", driver.FindElement(By.Name("q")));
            driver.FindElement(By.Name("q")).SendKeys(Keys.Return);

            driver.FindElement(By.XPath("//*[@id='container']/div/div[3]/div[1]/div[2]/div[2]")).Click();

            driver.SwitchTo().Window(handles[1]);
            driver.FindElement(By.XPath("//*[@id='container']/div/div[3]/div[1]/div[1]/div[2]/div/ul/li[1]/button")).Click();

            driver.Close();
        }
    }
}