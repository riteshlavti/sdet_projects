using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace TestProject
{
    public class NavBarMenSectionTees : PageBase
    {
        [FindsBy(How=How.XPath,Using ="//a[contains(text(),'Active Wear')]//parent::div/button")]
        IWebElement _activeWearDropDown;

        [FindsBy(How=How.XPath,Using ="//a[contains(text(),'Printed Tees')]")]
        IWebElement _printedTeesMenu;        

        By _printedTeesBtn = By.XPath("//a[contains(text(),'Printed Tees')]");
        By _poloTeesBtn = By.XPath("//a[contains(text(),'Polo Tees')]");
        By _raglanTeesBtn = By.XPath("//a[contains(text(),'Raglan Tees')]");
        By _pocketTeesBtn = By.XPath("//a[contains(text(),'Pocket Tees')]");
        By _basicOversizeTeesBtn = By.XPath("//a[contains(text(),'Basic Oversize Tees')]");
        By _athleticoActiveTeesBtn = By.XPath("//a[contains(text(),'Athletico - Active Wear Tees')]");
        
        public NavBarMenSectionTees(WebDriver webDriver, WebDriverWait wait) : base(webDriver, wait)
        {
            PageFactory.InitElements(webDriver, this);
        }

        public void ClickOnActiveWearDropDown()
        {
            ClickElement(_activeWearDropDown);
        }

        public bool IsVisible(By locator)
        {
            return IsElementVisible(locator);
        }

        public PrintedTees ClickOnPrintedTees()
        {
            ClickElement(_printedTeesMenu);
            return new PrintedTees(webDriver,wait);
        }
    }
}