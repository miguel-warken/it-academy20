using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;
public class GoogleSearchTests : IDisposable
{
    private readonly IWebDriver _driver;
    private readonly GoogleSearchPage _googleSearchPage;
    public GoogleSearchTests()
    {
        // Usar o WebDriverManager para configurar o ChromeDriver	
        new WebDriverManager.DriverManager().SetUpDriver(new
        WebDriverManager.DriverConfigs.Impl.ChromeConfig());
        _driver = new ChromeDriver();
        _googleSearchPage = new GoogleSearchPage(_driver);
    }
    [Theory]
    [InlineData("Selenium WebDriver")]
    [InlineData("xUnit testing")]
    [InlineData("C# tutorials")]
    public void TestGoogleSearch(string searchTerm)
    {
        // Navegar para a página do Google	
        _googleSearchPage.NavigateTo();
        // Inserir o termo de pesquisa	
        _googleSearchPage.EnterSearchTerm(searchTerm);
        // Esperar um pouco para ver os resultados	
        System.Threading.Thread.Sleep(3000);
        // Verificar se o título da página contém o termo de pesquisa	
        Assert.Contains(searchTerm, _googleSearchPage.GetTitle(),
        StringComparison.OrdinalIgnoreCase);
    }
    public void Dispose()
    {
        // Fechar o navegador	
        _driver.Quit();
        _driver.Dispose();
    }
}
