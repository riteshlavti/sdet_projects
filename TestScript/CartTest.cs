using AventStack.ExtentReports;
using NUnit.Framework.Internal;

namespace TestProject
{
    [TestFixture("chrome")]
    [TestFixture("firefox")]
    [Parallelizable]
    public class CartTest : TestBase
    {
        public CartTest(string browserName) : base(browserName)
        {
        }

        [Test]
        public void VerifyProductAddedToCart()
        {
            extentTest = extent.CreateTest("Add Product to cart test").Info("Test Started");
            try
            {
                NavBar navBar = homePage.ClickOnNavigationBtn();
                NavBarMenSection navBarMenSection = navBar.ClickOnMenSectionDropDown();
                NavBarMenSectionTees navBarMenSectionTees = navBarMenSection.ClickOnTeesDropDown();
                PrintedTees printedTees = navBarMenSectionTees.ClickOnPrintedTees();
                ProductPage productPage = printedTees.SelectProductWithId(330);

                string size = "M";
                productPage.SelectSize(size);

                string productName = productPage.GetProductName();
                productPage.ClickOnAddToCart();

                Assert.That(productPage.GetProductSizeFromCartPane(), Is.EqualTo($"Size: {size}"));
                Assert.That(productName, Is.EqualTo(productPage.GetProductNameFromCartPane()));

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