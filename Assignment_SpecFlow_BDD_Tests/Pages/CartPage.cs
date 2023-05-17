using OpenQA.Selenium;

namespace Assignment_SpecFlow_BDD_Tests.Pages;

public class CartPage
{
    private IWebDriver driver;
    public CartPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    By ListOfCartItems = By.XPath("//form/table/tbody/tr");
    public int VerifyAddedItemsList()
    {
        Thread.Sleep(2000);
        var elements = driver.FindElements(ListOfCartItems).Count;

        return elements-1;
    }

    private By RemoveItemButton = By.XPath("//form/table/tbody/tr[1]/td[1]/a");
    public CartPage RemoveLowestPriceItem()
    {
        driver.FindElement(RemoveItemButton).Click();
        return this;
    }

    public CartPage FindLowestPriceItem()
    {
        var list = new List<int>();
        string price = "//form/table/tbody/tr[item]/td[6]/span";
        var rowCount = driver.FindElements(By.XPath("//form/table/tbody/tr")).Count;
        for (int i = 1; i <= rowCount - 1; i++)
        {
            var priceText = driver.FindElement(By.XPath(price.Replace("item", i.ToString()))).Text;
            
            var value = priceText.Replace("$", "");
            Console.WriteLine("************"+ value);
        }
        return this;
    }
}