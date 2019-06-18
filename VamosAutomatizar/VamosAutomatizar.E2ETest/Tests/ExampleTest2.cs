using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace VamosAutomatizar.E2ETest.Tests
{
    public class ExampleTest2
    {
        [Fact]
        public void LoginWithSuccess()
        {
            string chromedriverPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + 
                "\\Documents\\vamos-automatizar-acelera\\VamosAutomatizar\\VamosAutomatizar.E2ETest\\Driver";
            IWebDriver driver = new ChromeDriver(chromedriverPath);
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://seubarriga.wcaquino.me");

            IWebElement emailInput = driver.FindElement(By.Id("email"));
            emailInput.SendKeys("thiago.grespi90@gmail.com");

            IWebElement passInput = driver.FindElement(By.Id("senha"));
            passInput.SendKeys("123456");

            IWebElement btnEntrar = driver.FindElement(By.XPath("/html/body/div[2]/form/button"));
			
			btnEntrar.Click();

            Assert.Equal("http://seubarriga.wcaquino.me/logar", driver.Url);

            IWebElement welcomeMessage = driver.FindElement(By.ClassName("alert-success"));

            Assert.True(welcomeMessage.Displayed);
            Assert.Equal("Bem vindo, Thiago!", welcomeMessage.Text);
        }
    }
}