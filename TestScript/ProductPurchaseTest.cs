using AventStack.ExtentReports;
using OpenQA.Selenium;

namespace TestProject
{
    [TestFixture("chrome")]
    [TestFixture("firefox")]
    [Parallelizable]
    public class ProductPurchaseTest : TestBase
    {
        public ProductPurchaseTest(string browserName): base(browserName)
        {
        }

        [Test]
        public void VerifyProductPurchase()
        {
            extentTest = extent.CreateTest("Verify pay now option on payment page").Info("Test Started");
            try
            {
                NavBar navBar = homePage.ClickOnNavigationBtn();
                NavBarWomenSection navBarWomenSection = navBar.ClickOnWomenSectionDropDown();
                WinterWearPage winterWearPage = navBarWomenSection.ClickOnWinterWear();
                ProductPage productPage = winterWearPage.SelectProductWithId(18);

                string size = "M";
                productPage.SelectSize(size);
                productPage.ClickOnAddToCart();

                CheckoutPage checkoutPage = productPage.ClickOnCheckout();
                checkoutPage.OptOutEmailMeCheckbox();
                checkoutPage.FillAddress(configuration.GetSection("ShippingAddress")["UserEmail"],
                                        configuration.GetSection("ShippingAddress")["FirstName"],
                                        configuration.GetSection("ShippingAddress")["LastName"],
                                        configuration.GetSection("ShippingAddress")["Address"],
                                        configuration.GetSection("ShippingAddress")["City"],
                                        configuration.GetSection("ShippingAddress")["State"],
                                        configuration.GetSection("ShippingAddress")["PostalCode"],
                                        configuration.GetSection("ShippingAddress")["ContactNumber"]);
                ShippingPage shippingPage = checkoutPage.ClickOnContinueToShipping();

                Assert.IsTrue(shippingPage.IsShippingMethodVisible());

                FinalCheckoutPage finalCheckoutPage = shippingPage.ClickOnContinueToPayment();

                Assert.IsTrue(finalCheckoutPage.IsPaymentMethodSelected());
                Assert.IsTrue(finalCheckoutPage.IsPayNowBtnVisible());
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