using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestProject
{
    public class AccountPage : PageBase
    {
        By _myaccountText = By.XPath("//h1[text()='My account']");
        public AccountPage(WebDriver webDriver,WebDriverWait wait) : base(webDriver,wait)
        {      
        }   
        
        public bool IsMyAccountVisible()
        {
            return IsElementVisibleLongWait(_myaccountText);
        }
    }
}