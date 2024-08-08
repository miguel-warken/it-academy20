namespace _26._07_ProjetoTemperaturas;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using Xunit;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

public class TempConversionTests : IDisposable
{
    private readonly IWebDriver _driver;
    private readonly ExtentReports _extent;
    private readonly ExtentTest _test;
    public TempConversionTests()
    {
        // Usar o WebDriverManager para configurar o ChromeDriver	
        new DriverManager().SetUpDriver(new ChromeConfig());
        _driver = new ChromeDriver();
        // Configurar o ExtentReports	
        var htmlReporter = new ExtentSparkReporter("extent_report.html");
        _extent = new ExtentReports();
        _extent.AttachReporter(htmlReporter);
        // Criar um teste no relatório	
        _test = _extent.CreateTest("GoogleSearchTests");
        _test = _extent.CreateTest("TestTempConversionCelsiusToFahrenheit");

    }
    [Fact]
    public void GoogleSearchTests()
    {
        try
        {
            // Navegar para a página do Google	
            _driver.Navigate().GoToUrl("https://www.google.com");
            _test.Log(Status.Pass, "Navegou para Google.com");
            // Encontrar a caixa de pesquisa pelo atributo name	
            IWebElement searchBox = _driver.FindElement(By.Name("q"));
            _test.Log(Status.Pass, "Encontrou a caixa de pesquisa");
            // Realizar a pesquisa	
            var searchTerm = "Selenium Webdriver";
            searchBox.SendKeys(searchTerm);
            searchBox.SendKeys(Keys.Enter);
            _test.Log(Status.Pass, $"Realizou a pesquisa por {searchTerm}");
            // Esperar um pouco para ver os resultados	
            System.Threading.Thread.Sleep(3000);
            // Verificar se o título da página contém o termo de pesquisa	
            Assert.Contains(searchTerm, _driver.Title, StringComparison.OrdinalIgnoreCase);
            _test.Log(Status.Pass, $"O título da página contém o termo de pesquisa {searchTerm}");
        }
        catch (Exception e)
        {
            _test.Log(Status.Fail, e.ToString());
            throw;
        }
    }

    [Theory]
    [InlineData("0", "32")]
    [InlineData("10", "50")]
    [InlineData("20", "68")]
    [InlineData("30", "86")]

    public void TestTempConversionCelsiusToFahrenheit(string entered, string expected)
    {
        try
        {
            _driver.Navigate().GoToUrl("https://www.metric-conversions.org/temperature/celsius-to-fahrenheit.htm");
            _test.Log(Status.Pass, "Navegou para www.metric-conversions.org");
            _driver.FindElement(By.Id("arg")).Click();
            _driver.FindElement(By.Id("arg")).SendKeys(entered);
            _test.Log(Status.Pass, $"Inseriu e enviou {entered} graus Celsius");
            string answer = _driver.FindElement(By.Id("answerDisplay")).Text;
            Assert.Contains(expected, answer, StringComparison.OrdinalIgnoreCase);
            _test.Log(Status.Pass, $"A resposta da pesquisa contém {answer}");
        }
        catch (Exception e)
        {
            _test.Log(Status.Fail, e.ToString());
            throw;
        }

    }

    public void Dispose()
    {
        // Fechar o navegador	
        _driver.Quit();
        _driver.Dispose();
        // Escrever o relatório	
        _extent.Flush();
    }
}
