using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace TestProject
{
    public class FinalCheckoutPage : PageBase
    {
        [FindsBy(How = How.XPath, Using = "//span[text()='Pay now']//parent::button")]
        IWebElement _payNowBtn;
        By _payNowBtnLocator = By.XPath("//span[text()='Pay now']//parent::button");

        public FinalCheckoutPage(WebDriver webDriver, WebDriverWait wait) : base(webDriver, wait)
        {
            PageFactory.InitElements(webDriver, this);
        }

        public bool IsPayNowBtnVisible()
        {
            return IsElementVisible(_payNowBtnLocator);
        }

        public PaymentPage ClickOnPayNow()
        {   
            ClickElement(_payNowBtn);
            return new PaymentPage(webDriver,wait);
        }
    }
}