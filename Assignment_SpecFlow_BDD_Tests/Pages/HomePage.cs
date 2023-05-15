using OpenQA.Selenium;

namespace Assignment_SpecFlow_BDD_Tests.Pages;

public class HomePage
{
    private IWebDriver driver;
    public HomePage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public HomePage NavigateToHomePage()
    {
        driver.Url = "https://cms.demo.katalon.com/";
        return this;
    }

    public HomePage AddItemsToCart()
    {
        string elements = "//div[@class='columns-3']/ul/li[item]/div/a[2]";
        for (int i = 1; i <= 4; i++)
        {
            IWebElement element = driver.FindElement(By.XPath(elements.Replace("item", i.ToString())));
            Thread.Sleep(2000);
            element.Click();
        }
        return this;
    }

    public CartPage ClickCartMenuLink()
    {
        driver.FindElement(By.XPath("//a[contains(text(), 'Cart')]")).Click();
        return new CartPage(driver);
    }
}