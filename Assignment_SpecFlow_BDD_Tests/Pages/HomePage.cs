using OpenQA.Selenium;

namespace Assignment_SpecFlow_BDD_Tests.Pages;

public class HomePage
{
    private IWebDriver driver;
    public HomePage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public HomePage AddItemsToCart()
    {
        return this;
    }

    public CartPage ClickCartMenuLink()
    {
        return new CartPage(driver);
    }
}