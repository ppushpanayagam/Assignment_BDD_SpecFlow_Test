using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Assignment_SpecFlow_BDD_Tests.Steps;

[Binding]
public class ShoppingCartStepDefinitions
{
    private IWebDriver Driver;
    
    [Given(@"I add four random items to my cart")]
    public void GivenIAddFourRandomItemsToMyCart()
    {
        Driver = new ChromeDriver();
        Driver.Manage().Window.Maximize();
        Driver.Url = "https://cms.demo.katalon.com/";
    }

    [Given(@"I view my cart")]
    public void GivenIViewMyCart()
    {
        
    }

    [Then(@"I find total four items listed in my cart")]
    public void ThenIFindTotalFourItemsListedInMyCart()
    {
        
    }

    [When(@"I search for lowest price item")]
    public void WhenISearchForLowestPriceItem()
    {
        
    }

    [When(@"I am able to remove the lowest price item from my cart")]
    public void WhenIAmAbleToRemoveTheLowestPriceItemFromMyCart()
    {
        
    }

    [Then(@"I am able to verify three items in my cart")]
    public void ThenIAmAbleToVerifyThreeItemsInMyCart()
    {
        
    }
}