using Microsoft.VisualBasic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace FlipkartTest2

{
    public class Tests
    {
        
        WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = DataClass.BASE_URI;
        }

        [Test]
        public void Test1()
        {
            Method.AddToCart(driver,"laptop");
            Method.AddToCart(driver,"mobile");
            Method.AddToCart(driver,"juicer");
            Method.AddToCart(driver,"samsung");

            var handles = driver.WindowHandles;
            driver.SwitchTo().Window(handles[0]);
            driver.Navigate().Refresh();
            driver.FindElement(By.XPath("//*[@id='container']/div/div[1]/div[1]/div[2]/div[6]/div/div/a"));
            int count = driver.FindElements(By.XPath("//*[@id='container']/div/div[2]/div/div/div[1]/div/div[2]/following-sibling::div")).Count();

            Assert.That(4,Is.EqualTo(count-1));
        }
        private void AddToCart(string query)
        {
            var handles = driver.WindowHandles;
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            driver.SwitchTo().Window(handles[0]);

            driver.FindElement(By.Name("q")).Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript($"arguments[0].value = 'laptop';", driver.FindElement(By.Name("q")));
            driver.FindElement(By.Name("q")).SendKeys(Keys.Return);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.FindElement(By.XPath("//*[@id='container']/div/div[3]/div[1]/div[2]/div[2]")).Click();

            handles = driver.WindowHandles;
            driver.SwitchTo().Window(handles[1]);

            driver.FindElement(By.XPath("//*[@id='container']/div/div[3]/div[1]/div[1]/div[2]/div/ul/li[1]/button")).Click();
            driver.Close();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}