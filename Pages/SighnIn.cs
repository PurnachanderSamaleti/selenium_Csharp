using OpenQA.Selenium;
using NUnit.Framework;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Source.BaseClass;

namespace TestProject1.Source.Pages
{
    public class SighnIn : Base
    {
        public IWebDriver driver;
        public SighnIn(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Sign in")]
        public IWebElement signinbutton { get; set; }

        [FindsBy(How = How.Id, Using = "createAccountSubmit")]
        public IWebElement CreatAmazonAcct { get; set; }

        [FindsBy(How = How.Id, Using = "ap_customer_name")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "ap_phone_number")]
        public IWebElement PhoneNmbr { get; set; }

        [FindsBy(How = How.Name, Using = "secondaryLoginClaim")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "ap_password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "continue")]
        public IWebElement Continue { get; set; }

        [Test]
        public void credentials()
        {
            signinbutton.Click();
            CreatAmazonAcct.Click();
            FirstName.SendKeys("Samaleti");
            PhoneNmbr.SendKeys("8186916653");
            Email.SendKeys("Chandu@Amazon");
            Password.SendKeys("12345678");
            Continue.Click();
        }
    }
}