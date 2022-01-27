using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class Chat
    {
        public Chat()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }

        //Click on Search icon
        [FindsBy(How = How.XPath, Using = "//i[@class='search link icon']")]
        private IWebElement SearchIcon { get; set; }

        // Search User input field
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search user']")]
        private IWebElement SearchUserInput { get; set; }

        // Dropdown 1st Option
        [FindsBy(How = How.XPath, Using = "(//*[@class='result'])[1]")]
        private IWebElement DropdownFirstOpt { get; set; }

        // Result 1st Option
        [FindsBy(How = How.XPath, Using = "//*[@id='service-search-section']//div[2]/div/div[2]/div/div/div[1]/a")]
        private IWebElement ResultFirstOpt { get; set; }

        // Chat button on profile page
        [FindsBy(How = How.XPath, Using = "(//*[@class='ui teal button'])[1]")]
        private IWebElement ChatBtnOnProfile { get; set; }

        // Chat dialog input area
        [FindsBy(How = How.Id, Using = "chatTextBox")]
        private IWebElement ChatInputArea { get; set; }

        // Send button
        [FindsBy(How = How.Id, Using = "btnSend")]
        private IWebElement SendBtn { get; set; }

        // Chat Icon on Main Page
        [FindsBy(How = How.XPath, Using = "//a[@href='/Home/Message']")]
        private IWebElement ChatIcon { get; set; }

        internal void ChatWithOtherUser(IWebDriver driver)
        {
            // Populate the excel data into system
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignIn");

            // Wait and click on Search icon
            GlobalDefinitions.WaitForElementClickable(driver, "XPath","//i[@class='search link icon']", 10);
            SearchIcon.Click();

            // Wait and Enter name in Search user part
            GlobalDefinitions.WaitElement(driver, "XPath", "//p[@class='row-padded']", 10);
            
           SearchUserInput.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Name"));

            // Wait and Choosse the first one option
            GlobalDefinitions.WaitElement(driver, "XPath", "(//*[@class='result'])[1]", 10);
            DropdownFirstOpt.Click();

            // Wait and Choose the first one result
            GlobalDefinitions.WaitElement(driver, "XPath","//*[@id='service-search-section']//div[2]/div/div/div[1]/a/img", 10);
            ResultFirstOpt.Click();

            // Wait and click on Chat button
            GlobalDefinitions.WaitElement(driver, "XPath", "//img[@class='defaultImage']", 10);
            Task.WaitAll(Task.Delay(3000));
            ChatBtnOnProfile.Click();
           
            // Wait and input message in input area
           ChatInputArea.SendKeys("Hi! Test!");
           
            // Click on send button
            SendBtn.Click();

            // Extent report
            Base.test.Log(LogStatus.Pass, "Chat with other users successfully!");
        }

        internal void VerifyChatWithOtherUser(IWebDriver driver)
        {
            Task.WaitAll(Task.Delay(2000));
            bool present;
            try
            {
                driver.FindElement(By.XPath("//span[contains(text(),'Hi! Test!')]"));
                present = true;
                if (present)
                {
                    Base.test.Log(LogStatus.Pass, "Verify Chat with other users sucessfully!");
                }

            }
            catch (NoSuchElementException)
            {
                present = false;
                Base.test.Log(LogStatus.Fail, "Test failed to verify Chat with other users!");
                Assert.Fail("Test failed to verify Chat with other users!");
            }
        }


        internal void ViewChatHistory(IWebDriver driver)
        {
            // Wait and click on Chat icon.
            GlobalDefinitions.WaitForElementClickable(driver, "XPath", "//a[@href='/Home/Message']", 10);
            ChatIcon.Click();
        }

        internal void VerifyViewChatHistory(IWebDriver driver)
        {
            // Populate the excel data into system
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignIn");

            // Wait
            GlobalDefinitions.WaitElement(driver, "XPath", "//div[@class='lastest-chat-row']", 10);

            // Record the first name of the chat obj
            string firstNameChatObj = GlobalDefinitions.ExcelLib.ReadData(3, "Name");

            // Judge if the chat obj is in chat history list
            try
            {
                driver.FindElement(By.XPath("//div[@class='header' and contains(text(),'" + firstNameChatObj + "')]"));
                Base.test.Log(LogStatus.Pass, "Verify Chat history sucessfully!");
                driver.FindElement(By.XPath("//div[@class='header' and contains(text(),'"+firstNameChatObj+"')]"));
            }
            catch (NoSuchElementException)
            {
                Base.test.Log(LogStatus.Fail, "Test failed to verify Chat History!");
                Assert.Fail("Test failed to verify Chat History!");
            }
        }


    }
}
