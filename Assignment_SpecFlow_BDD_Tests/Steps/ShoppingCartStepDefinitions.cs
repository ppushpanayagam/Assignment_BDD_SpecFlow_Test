using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Assignment_SpecFlow_BDD_Tests.Steps;

[Binding]
public class ShoppingCartStepDefinitions
{
    private IWebDriver Driver;

    public ShoppingCartStepDefinitions(IWebDriver driver)
    {
        this.Driver = driver;
    }

    [Given(@"I add four random items to my cart")]
    public void GivenIAddFourRandomItemsToMyCart()
    {
        Driver.Url = "https://cms.demo.katalon.com/";
        string elements = "//div[@class='columns-3']/ul/li[item]/div/a[2]";
        
        for (int i = 1; i <= 4; i++)
        {
            IWebElement element = Driver.FindElement(By.XPath(elements.Replace("item", i.ToString())));
            element.Click();
        }
        Driver.FindElement(By.XPath("//a[contains(text(), 'Cart')]")).Click();
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