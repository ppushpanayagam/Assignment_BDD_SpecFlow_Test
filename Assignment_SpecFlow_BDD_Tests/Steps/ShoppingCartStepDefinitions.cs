using System.Collections;
using NUnit.Framework;
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
            Thread.Sleep(2000);
            element.Click();
        }
    }

    [Given(@"I view my cart")]
    public void GivenIViewMyCart()
    {
        Driver.FindElement(By.XPath("//a[contains(text(), 'Cart')]")).Click();
    }

    [Then(@"I find total four items listed in my cart")]
    public void ThenIFindTotalFourItemsListedInMyCart()
    {
        var elements = Driver.FindElements(By.XPath("//form/table/tbody/tr")).Count;
        Assert.AreEqual(5, elements);
    }

    [When(@"I search for lowest price item")]
    public void WhenISearchForLowestPriceItem()
    {
        var list = new List<int>();
        string price = "//form/table/tbody/tr[item]/td[6]/span";
        var rowCount = Driver.FindElements(By.XPath("//form/table/tbody/tr")).Count;
        for (int i = 1; i <= rowCount - 1; i++)
        {
            var priceText = Driver.FindElement(By.XPath(price.Replace("item", i.ToString()))).Text;
            
            var value = priceText.Replace("$", "");
            Console.WriteLine("************"+ value);
            //list.Add(value);
        }
        //Console.Write("*****************"+list);
    }

    [When(@"I am able to remove the lowest price item from my cart")]
    public void WhenIAmAbleToRemoveTheLowestPriceItemFromMyCart()
    {
        string element = "//form/table/tbody/tr[1]/td[1]/a";
        Driver.FindElement(By.XPath(element)).Click();
    }

    [Then(@"I am able to verify three items in my cart")]
    public void ThenIAmAbleToVerifyThreeItemsInMyCart()
    {
        Thread.Sleep(2000);
        var elements = Driver.FindElements(By.XPath("//form/table/tbody/tr")).Count;
        Assert.AreEqual(4, elements);
    }
}