using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
//using OpenQA.Selenium.Interactions.

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            
            string url = "http://192.168.33.10/n/Login/#/";

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(url);

            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("txtUsername")).SendKeys("netadmin");

            driver.FindElement(By.Id("txtPassword")).SendKeys("N3tch3x@n3tch3x");

            driver.FindElement(By.Id("btnLogin")).Click();

            driver.FindElement(By.XPath(".//*[@id="nc-main-nav-primary"]/li[3]/a"));

            //driver.FindElement(By.Id("Process Payroll")).Click();

            //boolean staus = driver.FindElement(By.Id("lnkSkip")).Displayed()

            //driver.sSeleniumHelper.WaitUntil(01);

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //ImplicitWait(10, timeUnit.ImplicitlyWait(10, TimeUnits.SECONDS);

            //Thread.sleep(5000);

            //driver.FindElement(By.Id("lnkSkip")).Click();


            
                


            
        }
    }
}
