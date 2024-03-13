using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TestProject
{
    public class TestBase
    {
        public WebDriver webDriver;
        public WebDriverWait wait;
        public HomePage homePage;

        [SetUp]
        public void SetUp()
        {
            webDriver = new ChromeDriver();
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(5));
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            homePage = new HomePage(webDriver,wait);
            homePage.LoadUrl();
            webDriver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDownWebDriver()
        {
            webDriver.Quit();
        }
    }
}