using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace VamosAutomatizar.E2ETest.Tests
{
    public class ExampleTest
    {
        IWebDriver driver;
        
        [Fact]
        public void GoogleSearch()
        {
            string chromedriverPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + 
                "Documents\\vamos-automatizar-acelera\\VamosAutomatizar\\VamosAutomatizar.E2ETest\\Driver";
            driver = new ChromeDriver(dir);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com/");
            IWebElement searchInput = driver.FindElement(By.Name("q"));
            searchInput.SendKeys("Carro");
            searchInput.SendKeys(Keys.Enter);
            IWebElement searchResult = driver.FindElement(By.Id("resultStats"));
            Assert.Contains("Aproximadamente", searchResult.Text);
        }
    }
}


