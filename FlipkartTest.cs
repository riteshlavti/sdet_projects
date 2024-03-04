using Microsoft.VisualBasic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace FlipkartTest
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
            CartOperation.AddToCart(driver,"laptop");
            CartOperation.AddToCart(driver,"mobile");
            CartOperation.AddToCart(driver,"juicer");
            CartOperation.AddToCart(driver,"samsung");

            var handles = driver.WindowHandles;
            driver.SwitchTo().Window(handles[0]);
            driver.Navigate().Refresh();
            driver.FindElement(By.XPath("//*[@id='container']/div/div[1]/div[1]/div[2]/div[6]/div/div/a"));
            int count = driver.FindElements(By.XPath("//*[@id='container']/div/div[2]/div/div/div[1]/div/div[2]/following-sibling::div")).Count();

            Assert.That(4,Is.EqualTo(count-1));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}