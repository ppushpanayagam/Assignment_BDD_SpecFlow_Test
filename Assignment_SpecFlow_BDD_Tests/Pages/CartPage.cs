using OpenQA.Selenium;

namespace Assignment_SpecFlow_BDD_Tests.Pages;

public class CartPage
{
    private IWebDriver driver;
    public CartPage(IWebDriver driver)
    {
        this.driver = driver;
    }
}