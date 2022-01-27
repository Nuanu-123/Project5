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
    internal class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }

        #region Initialize Web Element
        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        private IWebElement ServiceTypeOptions { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@type='radio'][@name='serviceType'][@value=0]")]
        private IWebElement HourlyBasisService { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@type='radio'][@name='serviceType'][@value=1]")]
        private IWebElement OnOffService { get; set; }

        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement LocationTypeOption { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@type='radio'][@name='locationType'][@value=0]")]
        private IWebElement OnSite { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='radio'][@name='locationType'][@value=1]")]
        private IWebElement Online { get; set; }

        //Enter Start Date 
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateInputArea { get; set; }

        //Enter End Date 
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateInputArea { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }

        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTime { get; set; }

        //Click on StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }

        //Click on EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }

        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement SkillTradeOption { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@type='radio'][@name='skillTrades'][@value='true']")]
        private IWebElement SkillExchangeOption { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@type='radio'][@name='skillTrades'][@value='false']")]
        private IWebElement CreditOption { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@type='radio'][@name='skillTrades'][@value='false']")]
        private IWebElement CreditCharge { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@type='radio'][@name='isActive'][@value='true']")]
        private IWebElement Active { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@type='radio'][@name='isActive'][@value='false']")]
        private IWebElement Hidden { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        //Click on Cancel button
        [FindsBy(How = How.XPath, Using = "//input[@value='Cancel']")]
        private IWebElement Cancel { get; set; }

        //Click on Remove File button
        [FindsBy(How = How.XPath, Using = "//*[@class='remove sign icon floatRight']")]
        private IWebElement RemoveFile { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "(//*[@class='ReactTags__remove'])")]
        private IWebElement TagsCross { get; set; }

        //   Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement edit { get; set; }

        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }

        #endregion 

        #region EnterShareSkill
        internal void EnterShareSkill()
        {
            int rowNum = 2;

            // Populate data saved in excel to collection
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ShareSkillPath, "ShareSkill");

            // Click ShareSkill Button 
            ShareSkillButton.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//*[@name='categoryId']"), 10);

            // Enter Title from excel
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(rowNum, "Title"));

            // Enter Description from excel
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(rowNum, "Description"));

            // Select Category from Excel
            new SelectElement(CategoryDropDown).SelectByText(GlobalDefinitions.ExcelLib.ReadData(rowNum, "Category"));
            new SelectElement(SubCategoryDropDown).SelectByText(GlobalDefinitions.ExcelLib.ReadData(rowNum, "SubCategory"));

            // Enter tags from excel
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(rowNum, "Tags"));
            Tags.SendKeys(Keys.Enter);

            //Select Service type
            String ServiceType = GlobalDefinitions.ExcelLib.ReadData(rowNum, "ServiceType");
            if (ServiceType.Equals("Hourly basis service"))
            {
                HourlyBasisService.Click();
            }
            else if (ServiceType.Equals("One-off service"))
            {
                OnOffService.Click();
            }

            //Select Location type
            String LocationType = GlobalDefinitions.ExcelLib.ReadData(rowNum, "LocationType");
            if (LocationType.Equals("On-site"))
            {
                OnSite.Click();
            }
            else if (LocationType.Equals("Online"))
            {
                Online.Click();

            }

            // Enter Available days from excel
            //Enter start date and end date
            StartDateInputArea.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Startdate"));
            EndDateInputArea.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Enddate"));
            for (int rows = 2; rows < 9; rows++)
            {
                var num = GlobalDefinitions.ExcelLib.ReadData(rows, "Selectday");
                if (num != null && num != "")
                {
                    // Select checkbox
                    IWebElement DaysCheckbox = GlobalDefinitions.driver.FindElement(By.XPath("//input[@name='Available'][@index='" + GlobalDefinitions.ExcelLib.ReadData(rows, "Selectday") + "']"));
                    DaysCheckbox.Click();

                    // Enter start time
                    IWebElement StartTimeInput = GlobalDefinitions.driver.FindElement(By.XPath(" //input[@name='StartTime'][@index='" + GlobalDefinitions.ExcelLib.ReadData(rows, "Selectday") + "']"));
                    StartTimeInput.SendKeys(GlobalDefinitions.ExcelLib.ReadData(rows, "Starttime"));

                    // Enter end time
                    IWebElement EndTimeInput = GlobalDefinitions.driver.FindElement(By.XPath("//input[@name='EndTime'][@index='" + GlobalDefinitions.ExcelLib.ReadData(rows, "Selectday") + "']"));
                    EndTimeInput.SendKeys(GlobalDefinitions.ExcelLib.ReadData(rows, "Endtime"));

                }
                else
                {
                    break;
                }
            }
            // Choose Skill Trade radio button 
            String SkillTradeOption = GlobalDefinitions.ExcelLib.ReadData(rowNum, "SkillTrade");
            if (SkillTradeOption.Equals("Skill-exchange"))
            {
                SkillExchangeOption.Click();
            }
            else if (SkillTradeOption.Equals("Credit"))
            {
                CreditOption.Click();
                CreditAmount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(rowNum, "Credit"));
            }

            // Upload sample work document
            Thread.Sleep(4000);
            GlobalDefinitions.driver.FindElement(By.XPath("//input[@id='selectFile']")).SendKeys(MarsResource.WorkSamplePath);
            Thread.Sleep(4000);
           

            // Choose Active radio button
            String Visibility = GlobalDefinitions.ExcelLib.ReadData(rowNum, "Active");
            if (Visibility.Equals("Active"))
            {
                Active.Click();
            }
            else if (Visibility.Equals("Hidden"))
            {
                Hidden.Click();

            }

            // Save data
            Save.Click();
        }
        #endregion

        #region VerifyEnterShareSkill
        internal void VerifyEnterShareSkill()
        {
            GlobalDefinitions.wait(20);
            int rowNum = 2;
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ShareSkillPath, "ShareSkill");
            manageListingsLink.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//*[@id='listing-management-section']"), 10);
            string ActualTitle = "";
            string ActualDescription = "";
            string ActualCategory = "";
            var ExpectedTitle = GlobalDefinitions.ExcelLib.ReadData(rowNum, "Title");
            var ExpectedDescription = GlobalDefinitions.ExcelLib.ReadData(rowNum, "Description");
            var ExpectedCategory = GlobalDefinitions.ExcelLib.ReadData(rowNum, "Category");
            IList<IWebElement> ListingTableRow = GlobalDefinitions.driver.FindElements(By.XPath("//*[@class='ui striped table']/tbody/tr"));
            var row = ListingTableRow.Count;
            for (var i = 1; i <= row; i++)
            {
                IWebElement TitleText = GlobalDefinitions.driver.FindElement(By.XPath("(//*[@class='four wide'][1])[" + i + "]"));
                IWebElement DescriptionText = GlobalDefinitions.driver.FindElement(By.XPath("(//*[@class='four wide'][2])[" + i + "]"));
                IWebElement CategoryText = GlobalDefinitions.driver.FindElement(By.XPath("(//*[@class='one wide'][2])[" + i + "]"));
                ActualTitle = TitleText.GetAttribute("innerText");
                ActualDescription = DescriptionText.GetAttribute("innerText");
                ActualCategory = CategoryText.GetAttribute("innerText");
                if ((ActualTitle == ExpectedTitle) && (ActualDescription == ExpectedDescription) && (ActualCategory == ExpectedCategory))
                {
                    Assert.AreEqual(ActualTitle, ExpectedTitle);
                    Assert.AreEqual(ActualDescription, ExpectedDescription);
                    Assert.AreEqual(ActualCategory, ExpectedCategory);
                    IWebElement EyeIcon = GlobalDefinitions.driver.FindElement(By.XPath("(//i[@class='eye icon'])[" + i + "]"));
                    EyeIcon.Click();
                   break;
                }
               }
         if ((ActualTitle != ExpectedTitle) || (ActualDescription != ExpectedDescription) || (ActualCategory != ExpectedCategory))
            {
                Assert.Fail("No matchin record found");
                return;
            }

            // Verify Sub Category
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//*[@class='section'][2]"), 10);
            IWebElement SubCat = GlobalDefinitions.driver.FindElement(By.XPath("(//*[@class='section'])[2]"));
            string ActualSubCategory = SubCat.Text;
            string ExpectedSubCategory = GlobalDefinitions.ExcelLib.ReadData(rowNum, "SubCategory").ToString();
            GlobalDefinitions.wait(10);
            Assert.AreEqual(ExpectedSubCategory, ActualSubCategory);

            //Verify ServiceType 
          string ExpectedServiceType = GlobalDefinitions.ExcelLib.ReadData(rowNum, "ServiceType");
            string ActualServiceType = GlobalDefinitions.driver.FindElement(By.XPath("(//div[@class='description'])[4]")).Text;
            Assert.That(ExpectedServiceType, Does.Contain(ActualServiceType.ToString()));

            // Verify StartDate
            var ExpectedStartDate = GlobalDefinitions.ExcelLib.ReadData(rowNum, "Startdate");
            var ActualStartDate = GlobalDefinitions.driver.FindElement(By.XPath("(//div[@class='description'])[5]")).Text;
            DateTime StartDt = DateTime.Parse(ExpectedStartDate);
            var StartDateFormat = StartDt.ToString("yyyy-MM-dd");
            Assert.AreEqual(StartDateFormat, ActualStartDate);

            //Verify EndDate
             var ExpectedEndDate = GlobalDefinitions.ExcelLib.ReadData(rowNum, "Enddate");
            var ActualEndDate = GlobalDefinitions.driver.FindElement(By.XPath("(//div[@class='description'])[6]")).Text;
            DateTime EndDt = DateTime.Parse(ExpectedEndDate);
            var EndDateFormat = EndDt.ToString("yyyy-MM-dd");
            Assert.AreEqual(EndDateFormat, ActualEndDate);

            // Verify LocationType
            string ExpectedLocationType = GlobalDefinitions.ExcelLib.ReadData(rowNum, "LocationType");
            string ActualLocationType = GlobalDefinitions.driver.FindElement(By.XPath("(//div[@class='description'])[7]")).Text;
            ExpectedLocationType = ExpectedLocationType.ToUpper();
            ActualLocationType = ActualLocationType.ToUpper();
            Assert.AreEqual(ExpectedLocationType, ActualLocationType);
        }
        #endregion

        #region EditShareSkill 
        internal void EditShareSkill()
        {
            int rowNum = 3;

           // Populate data saved in excel to collection
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ShareSkillPath, "ShareSkill");
           
            manageListingsLink.Click();
           
            edit.Click();
            
            // Enter Title from excel
            Title.Clear();
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(rowNum, "Title"));

            // Enter Description from excel
            Description.Clear();
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(rowNum, "Description"));

            // Select Category from Excel
     
            new SelectElement(CategoryDropDown).SelectByText(GlobalDefinitions.ExcelLib.ReadData(rowNum, "Category"));
            new SelectElement(SubCategoryDropDown).SelectByText(GlobalDefinitions.ExcelLib.ReadData(rowNum, "SubCategory"));

            // Enter tags from excel
            TagsCross.Click();
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(rowNum, "Tags"));
            Tags.SendKeys(Keys.Enter);
            
 
            //Select Service type
            String ServiceType = GlobalDefinitions.ExcelLib.ReadData(rowNum, "ServiceType");
            if (ServiceType.Equals("Hourly basis service"))
            {
                HourlyBasisService.Click();
            }
            else if (ServiceType.Equals("One-off service"))
            {
                OnOffService.Click();

            }

            //Select Location type
            String LocationType = GlobalDefinitions.ExcelLib.ReadData(rowNum, "LocationType");
            if (LocationType.Equals("On-site"))
            {
                OnSite.Click();
            }
            else if (LocationType.Equals("Online"))
            {
                Online.Click();

            }

            // Enter Available days from excel
            //Enter start date and end date
            StartDateInputArea.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Startdate"));
            EndDateInputArea.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "Enddate"));
            for (int rows = 3; rows < 9; rows++)
            {
                var num = GlobalDefinitions.ExcelLib.ReadData(rows, "Selectday");
                if (num != null && num != "")
                {
                    // Select checkbox
                    IWebElement DaysCheckbox = GlobalDefinitions.driver.FindElement(By.XPath("//input[@name='Available'][@index='" + GlobalDefinitions.ExcelLib.ReadData(2, "Selectday") + "']"));
                    DaysCheckbox.Click();
                    IWebElement DaysCheckboxNew = GlobalDefinitions.driver.FindElement(By.XPath("//input[@name='Available'][@index='" + GlobalDefinitions.ExcelLib.ReadData(rows, "Selectday") + "']"));
                    DaysCheckboxNew.Click();

                    // Enter start time
                    IWebElement StartTimeInput = GlobalDefinitions.driver.FindElement(By.XPath(" //input[@name='StartTime'][@index='" + GlobalDefinitions.ExcelLib.ReadData(rows, "Selectday") + "']"));
                    StartTimeInput.SendKeys(GlobalDefinitions.ExcelLib.ReadData(rows, "Starttime"));

                    // Enter end time
                    IWebElement EndTimeInput = GlobalDefinitions.driver.FindElement(By.XPath("//input[@name='EndTime'][@index='" + GlobalDefinitions.ExcelLib.ReadData(rows, "Selectday") + "']"));
                    EndTimeInput.SendKeys(GlobalDefinitions.ExcelLib.ReadData(rows, "Endtime"));

                }
                else
                {
                    break;
                }
            }
            // Choose Skill Trade radio button 
            String SkillTradeOption = Global.GlobalDefinitions.ExcelLib.ReadData(rowNum, "SkillTrade");
            if (SkillTradeOption.Equals("Skill-exchange"))
            {
                SkillExchangeOption.Click();
                SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(3, "SkillTag"));
                SkillExchange.SendKeys(Keys.Enter);
            }
            else if (SkillTradeOption.Equals("Credit"))
            {
                CreditOption.Click();
                CreditAmount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(rowNum, "Credit"));
            }
          
            RemoveFile.Click();
            // Upload sample work document
            GlobalDefinitions.driver.FindElement(By.XPath("//input[@id='selectFile']")).SendKeys(MarsResource.WorkSamplePath);
            GlobalDefinitions.wait(10);

            // Choose Active radio button
            String Visibility = GlobalDefinitions.ExcelLib.ReadData(rowNum, "Active");
            if (Visibility.Equals("Active"))
            {
                Active.Click();
            }
            else if (Visibility.Equals("Hidden"))
            {
                Hidden.Click();

            }

            // Save data
            Save.Click();
        }
        #endregion

        #region VerifyEditShareSkill
        internal void VerifyEditShareSkill()
        {
            GlobalDefinitions.wait(20);
            int rowNum = 3;
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ShareSkillPath, "ShareSkill");
            manageListingsLink.Click();
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//*[@id='listing-management-section']"), 10);
            string ActualTitle = "";
            string ActualDescription = "";
            string ActualCategory = "";
            var ExpectedTitle = GlobalDefinitions.ExcelLib.ReadData(rowNum, "Title");
            var ExpectedDescription = GlobalDefinitions.ExcelLib.ReadData(rowNum, "Description");
            var ExpectedCategory = GlobalDefinitions.ExcelLib.ReadData(rowNum, "Category");
            IList<IWebElement> ListingTableRow = GlobalDefinitions.driver.FindElements(By.XPath("//*[@class='ui striped table']/tbody/tr"));
            var row = ListingTableRow.Count;
            for (var i = 1; i <= row; i++)
            {
                IWebElement TitleText = GlobalDefinitions.driver.FindElement(By.XPath("(//*[@class='four wide'][1])[" + i + "]"));
                IWebElement DescriptionText = GlobalDefinitions.driver.FindElement(By.XPath("(//*[@class='four wide'][2])[" + i + "]"));
                IWebElement CategoryText = GlobalDefinitions.driver.FindElement(By.XPath("(//*[@class='one wide'][2])[" + i + "]"));
                ActualTitle = TitleText.GetAttribute("innerText");
                ActualDescription = DescriptionText.GetAttribute("innerText");
                ActualCategory = CategoryText.GetAttribute("innerText");
                if ((ActualTitle == ExpectedTitle) && (ActualDescription == ExpectedDescription) && (ActualCategory == ExpectedCategory))
                {
                    Assert.AreEqual(ActualTitle, ExpectedTitle);
                    Assert.AreEqual(ActualDescription, ExpectedDescription);
                    Assert.AreEqual(ActualCategory, ExpectedCategory);
                    IWebElement EyeIcon = GlobalDefinitions.driver.FindElement(By.XPath("(//i[@class='eye icon'])[" + i + "]"));
                    EyeIcon.Click();
                    break;
                }
            }
            if ((ActualTitle != ExpectedTitle) || (ActualDescription != ExpectedDescription) || (ActualCategory != ExpectedCategory))
            {
                Assert.Fail("No matchin record found");
                return;
            }

            // Verify Sub Category
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//*[@class='section'][2]"), 10);
            IWebElement SubCat = GlobalDefinitions.driver.FindElement(By.XPath("(//*[@class='section'])[2]"));
            string ActualSubCategory = SubCat.Text;
            string ExpectedSubCategory = GlobalDefinitions.ExcelLib.ReadData(rowNum, "SubCategory").ToString();
            GlobalDefinitions.wait(10);
            Assert.AreEqual(ExpectedSubCategory, ActualSubCategory);

            //Verify ServiceType 
            string ExpectedServiceType = GlobalDefinitions.ExcelLib.ReadData(rowNum, "ServiceType");
            string ActualServiceType = GlobalDefinitions.driver.FindElement(By.XPath("(//div[@class='description'])[4]")).Text;
            Assert.That(ExpectedServiceType, Does.Contain(ActualServiceType.ToString()));

            // Verify StartDate
            var ExpectedStartDate = GlobalDefinitions.ExcelLib.ReadData(rowNum, "Startdate");
            var ActualStartDate = GlobalDefinitions.driver.FindElement(By.XPath("(//div[@class='description'])[5]")).Text;
            DateTime StartDt = DateTime.Parse(ExpectedStartDate);
            var StartDateFormat = StartDt.ToString("yyyy-MM-dd");
            Assert.AreEqual(StartDateFormat, ActualStartDate);

            //Verify EndDate
            var ExpectedEndDate = GlobalDefinitions.ExcelLib.ReadData(rowNum, "Enddate");
            var ActualEndDate = GlobalDefinitions.driver.FindElement(By.XPath("(//div[@class='description'])[6]")).Text;
            DateTime EndDt = DateTime.Parse(ExpectedEndDate);
            var EndDateFormat = EndDt.ToString("yyyy-MM-dd");
            Assert.AreEqual(EndDateFormat, ActualEndDate);

            // Verify LocationType
            string ExpectedLocationType = GlobalDefinitions.ExcelLib.ReadData(rowNum, "LocationType");
            string ActualLocationType = GlobalDefinitions.driver.FindElement(By.XPath("(//div[@class='description'])[7]")).Text;
            ExpectedLocationType = ExpectedLocationType.ToUpper();
            ActualLocationType = ActualLocationType.ToUpper();
            Assert.AreEqual(ExpectedLocationType, ActualLocationType);
        }
        #endregion

}
}
