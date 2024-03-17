using AventStack.ExtentReports;

namespace TestProject
{
    [TestFixture("chrome")]
    [TestFixture("firefox")]
    [Parallelizable]
    public class LoginTest : TestBase
    {
        public LoginTest(string browserName): base(browserName)
        {
        }

        [Test]
        public void ValidLogin()
        {
            extentTest = extent.CreateTest("Valid Login Test").Info("Test Started");

            homePage.ClosePopUp();
            LoginPage loginPage = homePage.ClickOnAccountBtn();
            loginPage.EnterEmail(configuration.GetSection("TestData")["UserEmail"]);
            loginPage.EnterPswd(configuration.GetSection("TestData")["ValidPassword"]);
            AccountPage accountPage = loginPage.ClickOnSignIn();

            Assert.IsTrue(accountPage.IsMyAccountVisible());
            
            extentTest.Log(Status.Pass, "Test Passed!");
        }

        [Test]
        public void InvalidLogin()
        {
            extentTest = extent.CreateTest("Invalid Login Test").Info("Test Started");
            try
            {
                homePage.ClosePopUp();
                LoginPage loginPage = homePage.ClickOnAccountBtn();
                loginPage.EnterEmail(configuration.GetSection("TestData")["UserEmail"]);
                loginPage.EnterPswd(configuration.GetSection("TestData")["InvalidPassword"]);
                AccountPage accountPage = loginPage.ClickOnSignIn();

                Assert.IsTrue(loginPage.IsIncorrectCredentialsVisible());

                extentTest.Log(Status.Pass, "Test Passed!");
            }
            catch (ApplicationException error)
            {
                extentTest.Log(Status.Error, error.Message);
                extentTest.Log(Status.Fail, "Test failed");
                throw;
            }
        }
    }
}