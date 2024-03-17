using AventStack.ExtentReports;

namespace TestProject
{
    [TestFixture("chrome")]
    [TestFixture("firefox")]
    [Parallelizable]
    public class PaginationVerificatoin : TestBase
    {
        public PaginationVerificatoin(string browserName): base(browserName)
        {
        }

        [Test]
        public void CheckNumberOfProducts()
        {
            extentTest = extent.CreateTest("Verify number of products on a page").Info("Test Started");
            try
            {
                NavBar navBar = homePage.ClickOnNavigationBtn();
                NavBarMenSection navBarMenSection = navBar.ClickOnMenSectionDropDown();
                MensTeesPage mensTeesPage = navBarMenSection.ClickOnMensTees();
                int listedProductsCountOnPage = mensTeesPage.GetListedProductsCountOnPage();
                
                Assert.That(listedProductsCountOnPage, Is.LessThan(24));
                extentTest.Log(Status.Pass, "Test Passed!");
            }
            catch (ApplicationException error)
            {
                extentTest.Log(Status.Error, error.Message);
                extentTest.Log(Status.Fail, "Test failed");
                throw;
            }
        }

        [Test]
        public void CheckPreviousBtnVisibility()
        {
            extentTest = extent.CreateTest("Verify previous button is dynamic").Info("Test Started");
            try
            {
                NavBar navBar = homePage.ClickOnNavigationBtn();
                NavBarMenSection navBarMenSection = navBar.ClickOnMenSectionDropDown();
                MensTeesPage mensTeesPage = navBarMenSection.ClickOnMensTees();

                Assert.IsFalse(mensTeesPage.IsPreviousBtnVisible());
                extentTest.Log(Status.Pass, "Test Passed!");
            }
            catch (ApplicationException error)
            {
                extentTest.Log(Status.Error, error.Message);
                extentTest.Log(Status.Fail, "Test failed");
                throw;
            }
        }

        [Test]
        public void CheckNextBtnVisibility()
        {
            extentTest = extent.CreateTest("Verify next button is dynamic").Info("Test Started");
            try
            {
                NavBar navBar = homePage.ClickOnNavigationBtn();
                NavBarMenSection navBarMenSection = navBar.ClickOnMenSectionDropDown();
                MensTeesPage mensTeesPage = navBarMenSection.ClickOnMensTees();
                mensTeesPage.GoToPage(8);

                Assert.IsFalse(mensTeesPage.IsNextBtnVisible());
                extentTest.Log(Status.Pass, "Test Passed!");
            }
            catch (ApplicationException error)
            {
                extentTest.Log(Status.Error, error.Message);
                extentTest.Log(Status.Fail, "Test failed");
                throw;
            }
        }

        [Test]
        public void CheckUrlConatinsPageNumber()
        {
            extentTest = extent.CreateTest("Verify url contains page number").Info("Test Started");
            try
            {
                NavBar navBar = homePage.ClickOnNavigationBtn();
                NavBarMenSection navBarMenSection = navBar.ClickOnMenSectionDropDown();
                MensTeesPage mensTeesPage = navBarMenSection.ClickOnMensTees();
                int pageNumber = 3;
                mensTeesPage.GoToPage(pageNumber);

                Assert.IsTrue(mensTeesPage.GetCurrentUrl().Contains($"page={pageNumber}"));
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