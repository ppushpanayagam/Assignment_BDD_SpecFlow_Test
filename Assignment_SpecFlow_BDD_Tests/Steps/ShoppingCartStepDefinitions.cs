using System.Collections;
using Assignment_SpecFlow_BDD_Tests.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Assignment_SpecFlow_BDD_Tests.Steps;

[Binding]
public class ShoppingCartStepDefinitions
{
    private IWebDriver Driver;
    private HomePage _homePage;
    private CartPage _cartPage;

    public ShoppingCartStepDefinitions(IWebDriver driver)
    {
        this.Driver = driver;
        _homePage = new HomePage(Driver);
        _cartPage = new CartPage(Driver);
    }

    [Given(@"I add four random items to my cart")]
    public void GivenIAddFourRandomItemsToMyCart()
    {
        _homePage.NavigateToHomePage();
        _homePage.AddItemsToCart();
    }

    [Given(@"I view my cart")]
    public void GivenIViewMyCart()
    {
        _cartPage = _homePage.ClickCartMenuLink();
    }

    [Then(@"I find total four items listed in my cart")]
    public void ThenIFindTotalFourItemsListedInMyCart()
    {
        Assert.AreEqual(4, _cartPage.VerifyAddedItemsList());
    }

    [When(@"I search for lowest price item")]
    public void WhenISearchForLowestPriceItem()
    {
        _cartPage.FindLowestPriceItem();
    }

    [When(@"I am able to remove the lowest price item from my cart")]
    public void WhenIAmAbleToRemoveTheLowestPriceItemFromMyCart()
    {
        _cartPage.RemoveLowestPriceItem();
    }

    [Then(@"I am able to verify three items in my cart")]
    public void ThenIAmAbleToVerifyThreeItemsInMyCart()
    {
        Assert.AreEqual(3, _cartPage.VerifyAddedItemsList());
    }
}