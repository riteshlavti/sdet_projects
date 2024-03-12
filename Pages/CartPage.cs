using System.Collections;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace TestProject
{
    public class CartPage : SeleniumWrapper
    {
        public IList<IWebElement> cartProductsList;

        [FindsBy(How = How.XPath, Using = "//div[text()='Total Amount']//parent::div//following-sibling::div")]
        IWebElement _totalPriceValue;
        public const string ProductPriceXpath = "//span[1][contains(text(),'₹')]";

        public CartPage(WebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        public string GetPrice()
        {
            return _totalPriceValue.Text;
        }

        public void StoreAllCartProducts()
        {
            cartProductsList = webDriver.FindElements(By.XPath("//a[contains(text(),'Apple')]"));
        }
    }
}