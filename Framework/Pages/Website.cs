using Framework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;

namespace Framework
{
    public class Website
    {
        [Test]
        public void TestWebsite()
        {
            IWebDriver driver= new ChromeDriver();
            driver.Url = "https://www.eoltas.lt/lt-lt";

            IWebElement buttonDeclineCookies = driver.FindElement(By.XPath("//*[@id=\'omnisend-form-651bc69d6aaa52e6ef78c5c4-form-close-icon\']/path"));
            buttonDeclineCookies.Click();
        }
       

    }
}
