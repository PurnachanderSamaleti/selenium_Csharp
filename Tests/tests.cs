using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Source.BaseClass;
using TestProject1.Source.Pages;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


namespace TestProject1.Tests
{
    public class tests: Base
    {
        IWebDriver driver;
      
        [Test]
        public void homepage()
        {
            HomePages HP = new HomePages(driver);
            HP.Search("Chandu11");

        }
        [Test]
        public void horizontalmenu()
        {
            HorizontalMenu HM = new HorizontalMenu(driver);
            HM.Horizontalitems("chandu");
            }

        [Test]
        public void loginamazon()
        {
            SighnIn SI = new SighnIn(driver);
            SI.credentials();
        }
        [Test]
        public void about()
        {
            AboutUs ab = new AboutUs(driver);
            ab.aboutus();
        }
        
    }
}
