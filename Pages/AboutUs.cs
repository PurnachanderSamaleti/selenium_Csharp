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
    public class AboutUs:Base
    {
        IWebDriver _driver;
        [FindsBy(How = How.PartialLinkText, Using = "About Us")]
        IWebElement Aboutus;
        [FindsBy(How = How.PartialLinkText, Using = "Who We Are")]
        IWebElement whoweare;
        [FindsBy(How = How.PartialLinkText, Using = "What We Do")]
        IWebElement Whatwedo;
        public AboutUs(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [Test]
        public void aboutus()
        {
            Aboutus.Click();
            whoweare.Click();
            Whatwedo.Click();
        }
    }
}
