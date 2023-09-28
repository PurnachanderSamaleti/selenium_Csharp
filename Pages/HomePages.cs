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
    public class HomePages:Base
    {
        IWebDriver _driver;
        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        IWebElement searchtextbox;

        [FindsBy(How = How.Id, Using = "nav-search-submit-button")]
        IWebElement searchbutton;

        [FindsBy(How = How.ClassName, Using = "icp-nav-flag")]
        IWebElement Clickonlanguage;

        [FindsBy(How = How.XPath, Using = "(//span[@dir='ltr'])[7]")]
        IWebElement SelectTelugulanguage;

        [FindsBy(How = How.ClassName, Using = "a-button-text")]
        IWebElement Clickoncancel;


        public HomePages(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [Test]
        public void Search()
        {
            searchtextbox.SendKeys("WebDriver");
            searchbutton.Click();
            Clickonlanguage.Click();
            SelectTelugulanguage.Click();
            Clickoncancel.Click();
        }
    }
}
