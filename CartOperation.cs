using System.Runtime.Serialization;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V120.Input;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
namespace FlipkartTest
{
    public class CartOperation : Base
    {
        public static void AddToCart(WebDriver driver, string query)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            Wrapper.SwitchWindow(0, driver);
            IWebElement searchBar = Wrapper.FindElementByName("q",driver);
            Wrapper.ClickElement(searchBar);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript($"arguments[0].value = '{query}';", searchBar);

            Wrapper.SendEnterKey(searchBar);

            IWebElement product = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//div[contains(text(),'{query}')]")));
            Wrapper.ClickElement(product);

            Wrapper.SwitchWindow(1, driver);

            IWebElement cartButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[text()='Add to cart']")));
            Wrapper.ClickElement(cartButton);

            Wrapper.CloseDriver(driver);
        }
    }
}