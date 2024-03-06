using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObjectModel
{
    public class Base
    {
        public WebDriver driver; 
        public HomePage objHomePage;   
        public ResultPage objResultPage;  
              
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Url = Data.BaseUri;
            objHomePage = new HomePage(driver);
            objResultPage = new ResultPage(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}