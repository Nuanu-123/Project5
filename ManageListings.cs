using MarsFramework.Config;
using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    internal class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }

        // Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }
        

        //   View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement view { get; set; }

        // Delete the listing
        [FindsBy(How = How.XPath, Using = "//table[1]/tbody[1]")]
        private IWebElement delete { get; set; }

        //   Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement edit { get; set; }

        internal void ActiveToggleWorking()
        {
            // Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ManageListingPath, "ManageListings");
            manageListingsLink.Click();

            //  Finding the skill added recently into manage listing by EnterShareSkill function
            //   Clicking the toggle active toggle button and check if it is updated in the listing
            int rowNum = 2;
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ShareSkillPath, "ShareSkill");
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//*[@id='listing-management-section']"), 10);
            var ExpectedTitle = GlobalDefinitions.ExcelLib.ReadData(rowNum, "Title");
            var ExpectedDescription = GlobalDefinitions.ExcelLib.ReadData(rowNum, "Description");
            var ExpectedCategory = GlobalDefinitions.ExcelLib.ReadData(rowNum, "Category");
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//*[@class='ui striped table']"), 10);
            IList<IWebElement> ListingTableRow = GlobalDefinitions.driver.FindElements(By.XPath("//*[@class='ui striped table']/tbody/tr"));

            var row = ListingTableRow.Count;
            for (var i = 1; i <= row; i++)
            {
                IWebElement TitleText = GlobalDefinitions.driver.FindElement(By.XPath("(//*[@class='four wide'][1])[" + i + "]"));
                IWebElement DescriptionText = GlobalDefinitions.driver.FindElement(By.XPath("(//*[@class='four wide'][2])[" + i + "]"));
                IWebElement CategoryText = GlobalDefinitions.driver.FindElement(By.XPath("(//*[@class='one wide'][2])[" + i + "]"));
                var ActualTitle = TitleText.GetAttribute("innerText");
                var ActualDescription = DescriptionText.GetAttribute("innerText");
                var ActualCategory = CategoryText.GetAttribute("innerText");
                if ((ActualTitle == ExpectedTitle) && (ActualDescription == ExpectedDescription) && (ActualCategory == ExpectedCategory))
                {
                    Assert.AreEqual(ActualTitle, ExpectedTitle);
                    Assert.AreEqual(ActualDescription, ExpectedDescription);
                    Assert.AreEqual(ActualCategory, ExpectedCategory);
                    IWebElement ActiveToggle = GlobalDefinitions.driver.FindElement(By.XPath("(//*[@class='ui toggle checkbox'])[" + i + "]"));
                    IWebElement EditIcon = GlobalDefinitions.driver.FindElement(By.XPath("(//*[@class='outline write icon'])[" + i + "]"));
                    ActiveToggle.Click();
                    break;
                }
            }
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//div[@class='ns-box-inner']"), 10);
            string VerifyAction = "//div[@class='ns-box-inner']";
            IWebElement AlertBoxMessage = GlobalDefinitions.driver.FindElement(By.XPath(VerifyAction));
            string Message = AlertBoxMessage.Text;
            String Visibility = GlobalDefinitions.ExcelLib.ReadData(rowNum, "Active");
            if (Visibility == "Active")
            {
                Assert.That(Message, Does.Contain("Service has been deactivated"));
            }
            else if (Visibility == "Hidden")
            {
                Assert.That(Message, Does.Contain("Service has been activated"));
            }
}

        internal void DeleteListing()
        {
            //   Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ManageListingPath, "ManageListings");

            manageListingsLink.Click();
            //  Finding the skill added recently into manage listing by EnterShareSkill function and deleting
            int rowNum = 2;
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//*[@id='listing-management-section']"), 10);
            Task.WaitAll(Task.Delay(2000));
            var ExpectedTitle = GlobalDefinitions.ExcelLib.ReadData(rowNum, "Title");
            var Deleteaction = GlobalDefinitions.ExcelLib.ReadData(rowNum, "Deleteaction");

            IList<IWebElement> ListingTableRow = GlobalDefinitions.driver.FindElements(By.XPath("//*[@class='ui striped table']/tbody/tr"));

            var row = ListingTableRow.Count;
            for (var i = 1; i <= row; i++)
            {
                IWebElement TitleText = GlobalDefinitions.driver.FindElement(By.XPath("(//*[@class='four wide'][1])[" + i + "]"));
                var ActualTitle = TitleText.GetAttribute("innerText");
                if (ActualTitle == ExpectedTitle)
                {
                    Assert.AreEqual(ActualTitle, ExpectedTitle);
                    IWebElement DeleteIcon = GlobalDefinitions.driver.FindElement(By.XPath(" (//*[@class='remove icon'])[" + i + "]"));
                    DeleteIcon.Click();
                    if (Deleteaction == "Yes")
                    {
                        IWebElement YesButton = GlobalDefinitions.driver.FindElement(By.XPath("//*[@class='ui icon positive right labeled button']"));
                        YesButton.Click();
                    }
                    else
                    {
                        IWebElement NoButton = GlobalDefinitions.driver.FindElement(By.XPath("//*[@class='ui negative button'] "));
                        NoButton.Click();
                    }
                    break;
                }
            }

        }
internal void VerifyDeleteListing()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ManageListingPath, "ManageListings");
            manageListingsLink.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//*[@id='listing-management-section']"), 10);

            // Finding the skill added recently into manage listing by EnterShareSkill function and deleting
            int rowNum = 2;
           // GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//*[@class='ui striped table']"), 10);
            var ExpectedTitle = GlobalDefinitions.ExcelLib.ReadData(rowNum, "Title");
            IList<IWebElement> ListingTableRow = GlobalDefinitions.driver.FindElements(By.XPath("//*[@class='ui striped table']/tbody/tr"));
            var row = ListingTableRow.Count;
            for (var i = 1; i <= row; i++)
            {
                IWebElement TitleText = GlobalDefinitions.driver.FindElement(By.XPath("(//*[@class='four wide'][1])[" + i + "]"));
                var ActualTitle = TitleText.GetAttribute("innerText");
                if ((ActualTitle == ExpectedTitle) || (GlobalDefinitions.driver.PageSource.Contains(GlobalDefinitions.ExcelLib.ReadData(rowNum, "Title"))))
                {
                    Assert.Fail("Listing detail not deleted");
                    break;
                }
            }
        }
    }
}
