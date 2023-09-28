using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Source.BaseClass;

namespace TestProject1.Source.Pages
{
    public class HorizontalMenu:Base
    {
        IWebDriver _driver;

        [FindsBy(How = How.PartialLinkText, Using = "Home & Kitchen")]
        IWebElement HomeandKitchen;
        [FindsBy(How = How.PartialLinkText, Using = "Living")]
        IWebElement Livingroom;
        [FindsBy(How = How.XPath, Using = "//a[@aria-label='Coffee tables']")]
        IWebElement coffeetable;
        [FindsBy(How = How.PartialLinkText, Using = "Top Brands")]
        IWebElement TopBrands;

        public HorizontalMenu(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [Test]
        public void Horizontalitems()
        {
            HomeandKitchen.Click();
            Livingroom.Click();
            coffeetable.Click();
            TopBrands.Click();
        }
    }
}