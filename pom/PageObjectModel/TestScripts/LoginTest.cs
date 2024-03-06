using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
            objHomePage.ClickLoginBtn();

            IAlert alert = objResultPage.SwitchToAlertWindow();
            String actualAlertText = objResultPage.GetAlertText(alert);
            alert.Accept();
            Thread.Sleep(3000);
            String expectedAlertText = "User or Password is not valid";
            

            Assert.That(expectedAlertText,Is.EqualTo(actualAlertText));
        }
    }
}