using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V120.SystemInfo;

namespace PageObjectModel
{
    [TestFixture]
    public class LoginTest : Base
    {
        [Test]
        public void InvalidLogin()
        {
            objHomePage.SetUsername("admin");
            objHomePage.SetPassword("admin");
            objResultPage.TakeScreenshotAndSave1("image1.png");
            objHomePage.ClickLoginBtn();

            IAlert alert = objResultPage.SwitchToAlertWindow();
            String actualAlertText = objResultPage.GetAlertText(alert);
            alert.Accept();
            
            objResultPage.TakeScreenshotAndSave1("image2.png");

            String expectedAlertText = "User or Password is not valid";
            
            
            Assert.That(expectedAlertText,Is.EqualTo(actualAlertText));
        }
    }
}