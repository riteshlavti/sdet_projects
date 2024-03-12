using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace TestProject
{
    public class ProductPage : SeleniumWrapper
    {
        WebDriver webDriver;
        WebDriverWait wait;

        [FindsBy(How = How.XPath, Using = "//button[text()='Add to cart']")]
        IWebElement _cartBtn;

        public ProductPage(WebDriver webDriver, WebDriverWait wait) : base(webDriver,wait)
        {
            this.webDriver = webDriver;
            this.wait = wait;
            PageFactory.InitElements(webDriver, this);
        }

        public bool ClickOnAddToCart()
        {
            if (IsElementExists(_cartBtn))
            {
                ClickElement(_cartBtn);
                return true;
            }
            else return false;
        }

        public void SwitchToResultWindow()
        {
            SwitchToWindow(0);
        }
    }
}