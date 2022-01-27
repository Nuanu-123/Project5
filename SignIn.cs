using MarsFramework.Global;
using OpenQA.Selenium;
using System;
using SeleniumExtras.PageObjects;
using System.Threading;
using System.Diagnostics;

namespace MarsFramework.Pages
{
    class SignIn
    {
        public SignIn()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
       // public static IWebElement SignIntab { get; set; }
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginBtn { get; set; }

        #endregion
        internal void LoginSteps()
        {
            // extent reports
            Base.test = Base.extent.StartTest("Login steps test");

            //Populate excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignIn");

            // Click signin tab to signin page
            SignIntab.Click();

            // Input username
            Email.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Username"));

            // Input password
            Password.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

            // Click Login button
            LoginBtn.Click();

            Thread.Sleep(3000);
            var greeting = GlobalDefinitions.driver.FindElement(By.XPath("(//*[@id='account-profile-section']//div[1]/div[2]/div/span)[1]")).Text;
            if (greeting.Contains("Hi Anusree"))
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Login Successful");
            }
            else
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Login failed");
            }


        }
    }
}