using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace FlipkartTest
{
    public class ProductPage
    {
        WebDriver webDriver;

        [FindsBy(How = How.XPath, Using = "//button[text()='Add to cart']")]
        IWebElement _cartBtn;

        WebDriverWait wait;

        public ProductPage(WebDriver webDriver, WebDriverWait wait)
        {
            this.webDriver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }

        public bool ClickOnAddToCart()
        {
            if (ElementExists(_cartBtn))
            {
                Wrapper.ClickElement(_cartBtn);
                return true;
            }
            else return false;
        }

        static bool ElementExists(IWebElement element)
        {
            try
            {
                bool value =  element.Enabled;

                return value;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}