using System.Collections;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace FlipkartTest
{
    public class CartPage
    {
        WebDriver webDriver;
        public IList<IWebElement> cartProductsList;

        [FindsBy(How = How.XPath, Using = "//div[text()='Total Amount']//parent::div//following-sibling::div")]
        IWebElement _priceValue;
        WebDriverWait wait;

        public CartPage(WebDriver webDriver, WebDriverWait wait)
        {
            this.webDriver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }

        public void CloseTab()
        {
            Wrapper.CloseTab(webDriver);
        }

        public void SwitchToResultWindow()
        {
            webDriver.SwitchTo().Window(webDriver.WindowHandles[0]);
        }

        public string ReturnsPrice()
        {
            return _priceValue.Text;
        }

        public int StoreAllVisibleElements()
        {
            cartProductsList = webDriver.FindElements(By.XPath("//a[contains(text(),'oneplus-nord')]"));
            return cartProductsList.Count;
        }
    }
}