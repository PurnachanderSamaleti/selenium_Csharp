using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProject1.Source.BaseClass
{
    public class Base
    {
               
       IWebDriver driver;
        [OneTimeSetUp]
        public void InitScript()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(10));

        }
        [OneTimeTearDown]
        public void cleanup()
        {
            driver.Quit();
        }
    }
}
