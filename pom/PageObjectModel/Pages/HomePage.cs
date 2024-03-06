using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V120.Input;
using SeleniumExtras.PageObjects;

namespace PageObjectModel
{
    public class HomePage
    {
        public WebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "input[name='uid']")]
        private IWebElement _userIdBox;

        [FindsBy(How = How.Name, Using ="password")]
        private IWebElement _passwordBox;

        [FindsBy(How = How.CssSelector, Using ="input[name='btnLogin']")]
        private IWebElement _loginBtn;

        [FindsBy(How =How.CssSelector,Using ="input[name='btnReset']")]
        private IWebElement _resetBtn;
        
        public HomePage(WebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        public void SetUsername(string userName)
        {
            _userIdBox.SendKeys(userName);
        }

        public void SetPassword(string password)
        {
            _passwordBox.SendKeys(password);
        }

        public void ClickLoginBtn()
        {
            _loginBtn.Click();
        }

        public void ClickResetBtn()
        {
            _resetBtn.Click();
        }
    }
}