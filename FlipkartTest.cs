using System.Collections.ObjectModel;
using Microsoft.VisualBasic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace FlipkartTest
{
    public class FlipkartCartTest : Base
    {
        [Test]
        public void VerifyCart()
        {
            driver.FindElement(By.Name("q")).SendKeys("search here...");
            CartOperation.AddToCart(driver,"laptop");
            CartOperation.AddToCart(driver,"mobile");
            CartOperation.AddToCart(driver,"juicer");

            ReadOnlyCollection<string> handles = driver.WindowHandles;
            Wrapper.SwitchWindow(0,driver);
            Wrapper.Refresh(driver);
            Wrapper.ClickElement(Wrapper.FindElementByXpath("//span[text()='Cart']",driver));

            int count = Wrapper.FindElementsByXpath("//*[@id='container']/div/div[2]/div/div/div[1]/div/div[2]/following-sibling::div",driver).Count();

            Assert.That(count,Is.EqualTo(3));
        }
    }
}