using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SeleniumExtras.PageObjects;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class SearchSkills
    {
        public SearchSkills()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }

        #region Initialize web elements

        //Click on Search icon
        [FindsBy(How = How.XPath, Using = "//i[@class='search link icon']")]
        private IWebElement SearchIcon { get; set; }

        // Category list
        [FindsBy(How = How.XPath, Using = "//div[@role='list']")]
        private IWebElement CategoryList { get; set; }

        // Sub-Category list
        [FindsBy(How = How.XPath, Using = "//a[@class='item subcategory']")]
        private IWebElement SubCategoryList { get; set; }

        //Click on Filter - Online
        [FindsBy(How = How.XPath, Using = "//*[@id='service-search-section']//div[5]/button[1]")]
        private IWebElement FilterOnline { get; set; }

        //Click on Filter - Onsite
        [FindsBy(How = How.XPath, Using = "//*[@id='service-search-section']//div[5]/button[2]")]
        private IWebElement FilterOnsite { get; set; }

        //Click on Filter - ShowAll
        [FindsBy(How = How.XPath, Using = "//*[@id='service-search-section']//div[5]/button[3]")]
        private IWebElement FilterShowAll { get; set; }

        // Total Pages
        [FindsBy(How = How.XPath, Using = "//*[@id='service-search-section']//div[2]/div/button[last()-1]")]
        private IWebElement Pages { get; set; }

        //Click on Next Page
        [FindsBy(How = How.XPath, Using = "//*[@id='service-search-section']//div[2]/div/button[last()]")]
        private IWebElement SkipToNextPage { get; set; }

        #endregion

        #region Search Skills By Categories
        internal void SearchSkillsByCategories(IWebDriver driver)
        {
            // Populate the excel data into system
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ShareSkillPath, "ShareSkill");

            // Wait and click on Search icon
            GlobalDefinitions.WaitForElementClickable(driver, "XPath", "//i[@class='search link icon']", 10);
            SearchIcon.Click();
            Task.WaitAll(Task.Delay(2000));

            // Wait, Click on Category and Sub-Category
            GlobalDefinitions.WaitForElementClickable(driver, "XPath", "//*[@id='service-search-section']//section/div/div[1]/div[1]/div/a[last()]", 10);
            IWebElement Category = driver.FindElement(By.XPath("//*[text()='" + GlobalDefinitions.ExcelLib.ReadData(2, "Category") + "']"));
            Category.Click();
            GlobalDefinitions.WaitForElementClickable(driver, "XPath", "//a[@class='item subcategory']", 10);
            IWebElement SubCategory = driver.FindElement(By.XPath("//*[@role='listitem'][text()='" + GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory") + "']"));
            SubCategory.Click();

            // Test extent report
            Base.test.Log(LogStatus.Pass, "Search Skills by Category sucessfully!");
        }

        internal void VerifySearchSkillsByCategories(IWebDriver driver)
        {
            Thread.Sleep(7000);
            IWebElement CategoryCheck = driver.FindElement(By.XPath(" (//*[@class='row-padded'])[2]"));
            CategoryCheck.Click();
          
             // Verify Category
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//*[@class='section'][1]"), 10);
            IWebElement Cat = GlobalDefinitions.driver.FindElement(By.XPath("(//*[@class='section'])[1]"));
            string ActualCategory = Cat.Text;
            string ExpectedCategory = GlobalDefinitions.ExcelLib.ReadData(2, "Category").ToString();
            GlobalDefinitions.wait(10);
            Assert.AreEqual(ExpectedCategory, ActualCategory);

            // Verify Sub Category
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//*[@class='section'][2]"), 10);
            IWebElement SubCat = GlobalDefinitions.driver.FindElement(By.XPath("(//*[@class='section'])[2]"));
            string ActualSubCategory = SubCat.Text;
            string ExpectedSubCategory = GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory").ToString();
            GlobalDefinitions.wait(10);
            Assert.AreEqual(ExpectedSubCategory, ActualSubCategory);

        }
        #endregion

        #region Search Skills By Filters
        int totalResults;
        int onlineResults;
        int onsiteResults;
        internal void SearchSkillsByFilters(IWebDriver driver)
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ShareSkillPath, "ShareSkill");

            // Wait and click on Search icon
            GlobalDefinitions.WaitForElementClickable(driver, "XPath", "//i[@class='search link icon']", 10);
            SearchIcon.Click();
            // Wait and click on Search icon
            GlobalDefinitions.WaitForElementClickable(driver, "XPath","//i[@class='search link icon']", 10);
            SearchIcon.Click();

            // Wait and check total results
            GlobalDefinitions.WaitElement(driver, "XPath", "(//*[@class='ui star disabled rating'])[1]", 10);
            //GlobalDefinitions.WaitForElementClickable(driver, "XPath", "//*[@id='service-search-section']//div[2]/div/button[2]", 10);
           Thread.Sleep(1000);
            totalResults = int.Parse(driver.FindElement(By.XPath("//*[@id='service-search-section']//div[1]/div[1]/div/a[1]/span")).Text);

            // Check online results
            FilterOnline.Click();
            Thread.Sleep(4000);
            onlineResults = int.Parse(driver.FindElement(By.XPath("//*[@id='service-search-section']//div[1]/div[1]/div/a[1]/span")).Text);

            // Check onsite results
            FilterOnsite.Click();
            GlobalDefinitions.WaitElement(driver, "XPath", "(//*[@class='ui star disabled rating'])[1]", 10);
           Thread.Sleep(1000);
            onsiteResults = int.Parse(driver.FindElement(By.XPath("//*[@id='service-search-section']//div[1]/div[1]/div/a[1]/span")).Text);

           // Extent report
            Base.test.Log(LogStatus.Pass, "Search skills by filter successfully!");
        }

        internal void VerifySearchSkillsByFilters(IWebDriver driver)
        {
            
            if (onlineResults + onsiteResults == totalResults)
            {
                
                Base.test.Log(LogStatus.Pass, "Verify search skills by filter successfully!");
                Assert.Pass("All results are shown");
            }
            else
            {
                
                Base.test.Log(LogStatus.Fail, "Failed to verify search skills by filter!");
                Assert.Fail("Test failed to verify search skills by filter!" + onlineResults + onsiteResults + totalResults);
            }

        }

        #endregion
    }
}
