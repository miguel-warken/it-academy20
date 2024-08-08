using OpenQA.Selenium;
public class GoogleSearchPage
{
    private readonly IWebDriver _driver;
    private readonly By _searchBox = By.Name("q");
    public GoogleSearchPage(IWebDriver driver)
    {
        _driver = driver;
    }
    public void NavigateTo()
    {
        _driver.Navigate().GoToUrl("https://www.google.com");
    }
    public void EnterSearchTerm(string term)
    {
        _driver.FindElement(_searchBox).SendKeys(term);
        _driver.FindElement(_searchBox).SendKeys(Keys.Enter);
    }
    public string GetTitle()
    {
        return _driver.Title;
    }
}