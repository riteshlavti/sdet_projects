using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace FlipkartTest
{
    [TestFixture]
    public class Base
    {
        public WebDriver driver;

        [SetUp]
        public void SetupWebDriver()
        {
            driver = new ChromeDriver();
            driver.Url = Data.BaseUrl;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void TearDownWebDriver()
        {
            driver.Quit();
        }
    }
}