using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Threading.Tasks;
namespace MarsFramework
{
    internal class Profile
    {

        public Profile()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Click on Edit button
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Part Time')]//i[@class='right floated outline small write icon']")]
        private IWebElement AvailabilityTimeEdit { get; set; }

        //Click on Availability Time dropdown
        [FindsBy(How = How.Name, Using = "availabiltyType")]
        private IWebElement AvailabilityTime { get; set; }

        //Click on Availability Time option
        [FindsBy(How = How.XPath, Using = "//option[@value='0']")]
        private IWebElement AvailabilityTimeOpt { get; set; }

        //Click on Availability Hour dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[1]/div/div[3]/div")]
        private IWebElement AvailabilityHours { get; set; }

        //Click on salary
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[1]/div/div[4]/div")]
        private IWebElement Salary { get; set; }

        //Click on Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div")]
        private IWebElement Location { get; set; }

        //Choose Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div/div[2]")]
        private IWebElement LocationOpt { get; set; }

        //Click on City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div")]
        private IWebElement City { get; set; }

        //Choose City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div/div[2]")]
        private IWebElement CityOpt { get; set; }

        //Click on Add new to add new Language
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement AddNewLangBtn { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[1]/input")]
        private IWebElement AddLangText { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[2]/select")]
        private IWebElement ChooseLang { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]")]
        private IWebElement ChooseLangOpt { get; set; }

        //Add Language
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[3]/input[1]")]
        private IWebElement AddLang { get; set; }

        //Click on Add new to add new skill
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement AddNewSkillBtn { get; set; }

        //Enter the Skill on text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[1]/input")]
        private IWebElement AddSkillText { get; set; }

        //Click on skill level dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select")]
        private IWebElement ChooseSkill { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select/option[3]")]
        private IWebElement ChooseSkilllevel { get; set; }

        //Add Skill
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/span/input[1]")]
        private IWebElement AddSkill { get; set; }

        //Click on Add new to Educaiton
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/table/thead/tr/th[6]/div")]
        private IWebElement AddNewEducation { get; set; }

        //Enter university in the text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[1]/input")]
        private IWebElement EnterUniversity { get; set; }

        //Choose the country
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select")]
        private IWebElement ChooseCountry { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select/option[6]")]
        private IWebElement ChooseCountryOpt { get; set; }

        //Click on Title dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select")]
        private IWebElement ChooseTitle { get; set; }

        //Choose title
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select/option[5]")]
        private IWebElement ChooseTitleOpt { get; set; }

        //Degree
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[2]/input")]
        private IWebElement Degree { get; set; }

        //Year of graduation
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select")]
        private IWebElement DegreeYear { get; set; }

        //Choose Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select/option[4]")]
        private IWebElement DegreeYearOpt { get; set; }

        //Click on Add
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[3]/div/input[1]")]
        private IWebElement AddEdu { get; set; }

        //Add new Certificate
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/table/thead/tr/th[4]/div")]
        private IWebElement AddNewCerti { get; set; }

        //Enter Certification Name
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[1]/div/input")]
        private IWebElement EnterCerti { get; set; }

        //Certified from
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[1]/input")]
        private IWebElement CertiFrom { get; set; }

        //Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select")]
        private IWebElement CertiYear { get; set; }

        //Choose Opt from Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select/option[5]")]
        private IWebElement CertiYearOpt { get; set; }

        //Add Ceritification
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[3]/input[1]")]
        private IWebElement AddCerti { get; set; }

        //Add Desctiption
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[2]/div[1]/textarea")]
        private IWebElement Description { get; set; }

        //Click on Save Button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[4]/span/button[1]")]
        private IWebElement Save { get; set; }

        #endregion

        #region  Initialize Profile Web Elements 

        //Click on Edit name button
        [FindsBy(How = How.XPath, Using = "(//*[@class='dropdown icon'])[2]")]
        private IWebElement EditName { get; set; }

        //Click on Edit first name button
        [FindsBy(How = How.XPath, Using = "//*[@name='firstName']")]
        private IWebElement FirstName { get; set; }

        //Click on Edit last name button
        [FindsBy(How = How.XPath, Using = "//*[@name='lastName']")]
        private IWebElement LastName { get; set; }

        //Click on Save name button
        [FindsBy(How = How.XPath, Using = "(//*[@class='ui teal button'])[1]")]
        private IWebElement SaveName { get; set; }

        //Click on Edit availability button
        [FindsBy(How = How.XPath, Using = "(//*[@class='right floated outline small write icon'])[1]")]
        private IWebElement EditAvailability { get; set; }

        //Click on Availability Time dropdown
        [FindsBy(How = How.XPath, Using = "//*[@name='availabiltyType']")]
        private IWebElement Availability { get; set; }

        //Click on Edit availability hour button
        [FindsBy(How = How.XPath, Using = "(//*[@class='right floated outline small write icon'])[2]")]
        private IWebElement EditAvailableHour { get; set; }

        //Click on Hour dropdown
        [FindsBy(How = How.XPath, Using = "//*[@name='availabiltyHour']")]
        private IWebElement AvailabilityHour { get; set; }

        //Click on Edit Earn Target button
        [FindsBy(How = How.XPath, Using = "(//*[@class='right floated outline small write icon'])[3]")]
        private IWebElement EarnTargetEdit { get; set; }

        //Click enter target
        [FindsBy(How = How.XPath, Using = "//*[@name='availabiltyTarget']")]
        private IWebElement EarnTarget { get; set; }

        //Click Edit description
        [FindsBy(How = How.XPath, Using = "(//*[@class='outline write icon'])[1]")]
        private IWebElement EditDescription { get; set; }

        //Click Save description
        [FindsBy(How = How.XPath, Using = "(//*[@class='ui teal button'])[2]")]
        private IWebElement SaveDescription { get; set; }

        //Click Enter description
        [FindsBy(How = How.XPath, Using = "(//*[@name='value'])")]
        private IWebElement EnterDescription { get; set; }

        //Click Hi
        [FindsBy(How = How.XPath, Using = "(//*[@id='account-profile-section']//div[1]/div[2]/div/span)[1]")]
        private IWebElement Hi { get; set; }

        //change password button
        [FindsBy(How = How.XPath, Using = "//*[@class='item'][text()='Change Password']")]
        private IWebElement ChangePass { get; set; }

        //EnterCurrentPass field
        [FindsBy(How = How.XPath, Using = "//*[@placeholder='Current Password']")]
        private IWebElement CurrentPass { get; set; }

        //EnterNewPass field
        [FindsBy(How = How.XPath, Using = "//*[@placeholder='New Password']")]
        private IWebElement NewPass { get; set; }

        //ReEnterNewPass field
        [FindsBy(How = How.XPath, Using = "//*[@placeholder='Confirm Password']")]
        private IWebElement ConfirmPass { get; set; }

        //Save Pass Button
        [FindsBy(How = How.XPath, Using = "//*[@class='ui button ui teal button']")]
        private IWebElement SavePass { get; set; }

        //SignOut Button
        [FindsBy(How = How.XPath, Using = "//*[@class='ui green basic button']")]
        private IWebElement SignOut { get; set; }

        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
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

        #region  Initialize Language tab

        //Click Language Tab
        [FindsBy(How = How.XPath, Using = "//a[@data-tab='first']")]
        private IWebElement LanguageTab { get; set; }

        //Click on Add new to add new Language
        [FindsBy(How = How.XPath, Using = "//div[@data-tab='first']//div[contains(text(),'Add New')]")]
        private IWebElement LanguageAddNewBtn { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Language']")]
        private IWebElement LanguageName { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//div[@data-tab='first']//select[@name='level']")]
        private IWebElement LanguageDropdownBox { get; set; }

        //Add Language
        [FindsBy(How = How.XPath, Using = "//div[@data-tab='first']//input[@value='Add']")]
        private IWebElement LanguageAddBtn { get; set; }

        //Delete Language
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]//div[3]" +
            "/form/div[2]//div[2]//tbody[last()]/tr/td[3]/span[2]/i")]
        private IWebElement LanguageDeleteBtn { get; set; }

        #endregion

        #region Initialize Skills Tab
        // Click Skills Tab
        [FindsBy(How = How.XPath, Using = "//a[@data-tab='second']")]
        private IWebElement SkillTab { get; set; }

        //Click on Add new to add new skill
        [FindsBy(How = How.XPath, Using = "//div[@data-tab='second']//div[contains(text(),'Add New')]")]
        private IWebElement SkillAddNewBtn { get; set; }

        //Enter the Skill on text box
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Skill']")]
        private IWebElement SkillName { get; set; }

        //Click on skill level dropdown
        [FindsBy(How = How.XPath, Using = "//div[@data-tab='second']//select[@name='level']")]
        private IWebElement SkillDropdownBox { get; set; }

        //Add Skill
        [FindsBy(How = How.XPath, Using = "//div[@data-tab='second']//input[@value='Add']")]
        private IWebElement SkillAddBtn { get; set; }

        //Delete Skill
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]//div[3]" +
            "/form/div[3]//div[2]//tbody[last()]/tr/td[3]/span[2]/i")]
        private IWebElement SkillDeleteBtn { get; set; }

        #endregion

        #region Initialize Education Tab
        //Click Education Tab
        [FindsBy(How = How.XPath, Using = "//a[@data-tab='third']")]
        private IWebElement EducationTab { get; set; }

        //Click on Add new to Educaiton
        [FindsBy(How = How.XPath, Using = "//div[@data-tab='third']//div[contains(text(),'Add New')]")]
        private IWebElement EducationAddNewBtn { get; set; }

        //Enter university in the text box
        [FindsBy(How = How.XPath, Using = "//input[@name='instituteName']")]
        private IWebElement EducationName { get; set; }

        //Choose the country dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='country']")]
        private IWebElement EducationCountryDropdownBox { get; set; }

        //Click on Title dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='title']")]
        private IWebElement EducationTitleDropdownBox { get; set; }

        //Degree
        [FindsBy(How = How.XPath, Using = "//input[@name='degree']")]
        private IWebElement EducationDegree { get; set; }

        //Year of graduation dropdown box
        [FindsBy(How = How.XPath, Using = "//select[@name='yearOfGraduation']")]
        private IWebElement EducationGraduationYearDropdownBox { get; set; }

        // Click Add button
        [FindsBy(How = How.XPath, Using = "//div[@data-tab='third']//input[@value='Add']")]
        private IWebElement EducationAddBtn { get; set; }

        //Delete Education
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]//div[3]" +
            "/form/div[4]//div[2]//tbody[last()]/tr/td[6]/span[2]/i")]
        private IWebElement EducationDeleteBtn { get; set; }
        #endregion

        #region Initialize Certifications Tab
        //Click Certification Tab
        [FindsBy(How = How.XPath, Using = "//a[@data-tab='fourth']")]
        private IWebElement CertificationTab { get; set; }

        //Click on Add New Button
        [FindsBy(How = How.XPath, Using = "//div[@data-tab='fourth']//div[contains(text(),'Add New')]")]
        private IWebElement CertificationAddNewBtn { get; set; }

        //Enter Certification Name
        [FindsBy(How = How.XPath, Using = "//input[@name='certificationName']")]
        private IWebElement CertificationName { get; set; }

        //Enter Certified from
        [FindsBy(How = How.XPath, Using = "//input[@name='certificationFrom']")]
        private IWebElement CertificationFrom { get; set; }

        //Click Year dropdown box
        [FindsBy(How = How.XPath, Using = "//select[@name='certificationYear']")]
        private IWebElement CertificationYearDropdownBox { get; set; }

        //Click Add Ceritification
        [FindsBy(How = How.XPath, Using = "//div[@data-tab='fourth']//input[@value='Add']")]
        private IWebElement CertificationAddBtn { get; set; }

        //Delete Certificate
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]//div[3]" +
            "/form/div[5]//div[2]//tbody[last()]/tr/td[4]/span[2]/i")]
        private IWebElement CertificateDeleteBtn { get; set; }
        #endregion

        #region Edit Profile
        internal void EditProfile()
        {
            // Populate the data saved in Excel to Collection
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//*[@id='account-profile-section']"), 10);
            int rowNum = 2;

            // Enter User Name
            Task.WaitAll(Task.Delay(2000));
            EditName.Click();
            FirstName.Clear();
            LastName.Clear();
            FirstName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(rowNum, "FirstName"));
            LastName.Clear();
            LastName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(rowNum, "LastName"));
            SaveName.Click();

            //Enter availability
            Task.WaitAll(Task.Delay(1000));
            EditAvailability.Click();
            new SelectElement(Availability).SelectByText(GlobalDefinitions.ExcelLib.ReadData(rowNum, "AvailabilityType"));

            ////Enter availabile hours
            Task.WaitAll(Task.Delay(1000));
            EditAvailableHour.Click();
            new SelectElement(AvailabilityHour).SelectByText(GlobalDefinitions.ExcelLib.ReadData(rowNum, "AvailabilityHours"));

            ////Enter Earn target
            Task.WaitAll(Task.Delay(1000));
            EarnTargetEdit.Click();
            new SelectElement(EarnTarget).SelectByText(GlobalDefinitions.ExcelLib.ReadData(rowNum, "EarnTarget"));
            // GlobalDefinitions.driver.Navigate().Refresh();

            // Enter Description
            Task.WaitAll(Task.Delay(3000));
            EditDescription.Click();
            EnterDescription.Clear();
            EnterDescription.SendKeys(GlobalDefinitions.ExcelLib.ReadData(rowNum, "Description"));
            SaveDescription.Click();


        }
        #endregion

        #region Verify Edit Profile
        internal void VerifyEditProfile()
        {
            // Populate the data saved in Excel to Collection
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            int rowNum = 2;
            Thread.Sleep(4000);
            //Verify Name
            Task.WaitAll(Task.Delay(1000));
            string ExpectedFirstName = GlobalDefinitions.ExcelLib.ReadData(rowNum, "FirstName").ToString();
            string ExpectedLastName = GlobalDefinitions.ExcelLib.ReadData(rowNum, "LastName").ToString();
            string ExpectedName = ExpectedFirstName + " " + ExpectedLastName;
            IWebElement Name = GlobalDefinitions.driver.FindElement(By.XPath("   //*[text()='" + ExpectedName + "']"));
            string ActualName = Name.GetAttribute("innerText");
            GlobalDefinitions.wait(10);
            Assert.AreEqual(ActualName, ExpectedName);
            bool result = true;
            // Verify Availability type hours and target
            if (GlobalDefinitions.driver.PageSource.Contains(GlobalDefinitions.ExcelLib.ReadData(rowNum, "AvailabilityType")) &&
                (GlobalDefinitions.driver.PageSource.Contains(GlobalDefinitions.ExcelLib.ReadData(rowNum, "AvailabilityHours")) &&
                (GlobalDefinitions.driver.PageSource.Contains(GlobalDefinitions.ExcelLib.ReadData(rowNum, "EarnTarget")))))
            {
                Assert.IsTrue(result);

            }
            else
            {
                Assert.Fail("Data is incorrect");

            }

            // Verify Desciption
            if (GlobalDefinitions.driver.PageSource.Contains(GlobalDefinitions.ExcelLib.ReadData(rowNum, "Description")))
            {
                Assert.IsTrue(result);
            }
            else
            {
                Assert.Fail("Description not present");

            }
        }
        #endregion

        #region Change Password
        internal void ChangePassword()
        {
            //Change Password
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            int rowNum = 2;
            Task.WaitAll(Task.Delay(3000));
            Hi.Click();
            Thread.Sleep(2000);
            ChangePass.Click();
            CurrentPass.SendKeys(GlobalDefinitions.ExcelLib.ReadData(rowNum, "Password"));
            NewPass.SendKeys(GlobalDefinitions.ExcelLib.ReadData(rowNum, "UpdatedPassword"));
            ConfirmPass.SendKeys(GlobalDefinitions.ExcelLib.ReadData(rowNum, "UpdatedPassword"));
            SavePass.Click();
        }
        #endregion

        #region VerifyChangePassword
        internal void VerifyChangePassword()
        {
            //Populate excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            Task.WaitAll(Task.Delay(2000));
            SignOut.Click();
            // Click signin tab to signin page
            SignIntab.Click();
            // Input username
            Email.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Username"));
            // Input password
            Password.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "UpdatedPassword"));
            // Click Login button
            LoginBtn.Click();
            Task.WaitAll(Task.Delay(1000));
            var greeting = GlobalDefinitions.driver.FindElement(By.XPath("(//*[@id='account-profile-section']//div[1]/div[2]/div/span)[1]")).Text;
            if (greeting.Contains("Hi"))
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Password Updated Login Successful");
            }
            else
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Password Not Updated Login failed");
            }
        }
        #endregion

        #region Enter Profile
        // Enter Profile
        internal void EnterProfile()
        {
            // Populate the data saved in Excel to Collection
            try
            {
                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");

            }
            catch (Exception e)
            {
                Assert.Fail("Test failed to populate in collection at entering profile step", e.Message);
            }


            #region Enter Language
            try
            {
                // Click Language tab
                GlobalDefinitions.WaitElement(GlobalDefinitions.driver, "XPath", "//a[@data-tab='first']", 5);
                LanguageTab.Click();

                // Click Add New
                GlobalDefinitions.WaitElement(GlobalDefinitions.driver, "XPath", "//div[@data-tab='first']//div[contains(text(),'Add New')]", 5);
                LanguageAddNewBtn.Click();

                // Enter Language
                GlobalDefinitions.WaitElement(GlobalDefinitions.driver, "XPath", "//input[@placeholder='Add Language']", 5);
                LanguageName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Language"));

                // Choose Language level 0-basic; 1-conversational; 2-fluent; 3-native
                LanguageDropdownBox.Click();
                new SelectElement(LanguageDropdownBox).SelectByText
                (GlobalDefinitions.ExcelLib.ReadData(2, "LanguageLevel")); // Need using OpenQA.Selenium.Support.UI;

                // Click Add
                LanguageAddBtn.Click();
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Enter language successfully");

            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to enter/add Language", ex.Message);
            }
            #endregion

            #region Enter Skills
            try
            {
                // Click Skills tab
                GlobalDefinitions.WaitElement(GlobalDefinitions.driver, "XPath", "//a[@data-tab='second']", 5);
                SkillTab.Click();

                // Click Add New
                GlobalDefinitions.WaitElement(GlobalDefinitions.driver, "XPath", "//div[@data-tab='second']//div[contains(text(),'Add New')]", 5);
                SkillAddNewBtn.Click();

                // Enter Skill
                GlobalDefinitions.WaitElement(GlobalDefinitions.driver, "XPath", "//input[@placeholder='Add Skill']", 5);
                SkillName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill"));

                // Choose Skill level 0-beginer; 1-intermediate; 2-expert
                SkillDropdownBox.Click();
                new SelectElement(SkillDropdownBox).SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "SkillLevel"));

                // Click Add
                SkillAddBtn.Click();
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Enter skills successfully");

            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to enter/add Skills", ex.Message);
            }
            #endregion

            #region Enter Education
            try
            {
                // Click Education tab
                GlobalDefinitions.WaitElement(GlobalDefinitions.driver, "XPath", "//a[@data-tab='third']", 5);
                EducationTab.Click();

                // Click Add New
                GlobalDefinitions.WaitElement(GlobalDefinitions.driver, "XPath", "//div[@data-tab='third']//div[contains(text(),'Add New')]", 5);
                EducationAddNewBtn.Click();

                // Enter University Name
                GlobalDefinitions.WaitElement(GlobalDefinitions.driver, "XPath", "//input[@name='instituteName']", 5);
                EducationName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "University"));

                // Enter Degree
                EducationDegree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Degree"));

                // Choose Country
                EducationCountryDropdownBox.Click();
                new SelectElement(EducationCountryDropdownBox).SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Country"));

                // Choose  Title 0-Associate; 1-B.A; 2-BArch; 3-BFA; 4-B.Sc...
                EducationTitleDropdownBox.Click();
                new SelectElement(EducationTitleDropdownBox).SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));

                // Choose Year
                EducationGraduationYearDropdownBox.Click();
                new SelectElement(EducationGraduationYearDropdownBox).SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "GraduationYear"));

                // Click Add
                EducationAddBtn.Click();
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Enter education successfully");

            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to enter/add Education", ex.Message);
            }
            #endregion

            #region Enter Certifications
            try
            {
                // Click Certifications tab
                GlobalDefinitions.WaitElement(GlobalDefinitions.driver, "XPath", "//a[@data-tab='fourth']", 5);
                CertificationTab.Click();

                // Click Add New
                GlobalDefinitions.WaitElement(GlobalDefinitions.driver, "XPath", "//div[@data-tab='fourth']//div[contains(text(),'Add New')]", 5);
                CertificationAddNewBtn.Click();

                // Enter Certificate name
                GlobalDefinitions.WaitElement(GlobalDefinitions.driver, "XPath", "//input[@name='certificationName']", 5);
                CertificationName.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Certificate"));

                // Enter Issuing place
                CertificationFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "CertifiedFrom"));

                // Choose Year
                CertificationYearDropdownBox.Click();
                new SelectElement(CertificationYearDropdownBox).SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "CertifiedYear"));

                // Click Add
                CertificationAddBtn.Click();
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Enter certificate successfully");

            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to enter/add Certificate", ex.Message);
            }
            #endregion
 }
        #endregion

        #region Verify Enter-Profile
        // Verify Enter-Profile
        internal void VerifyEnterProfile()
        {
            try
            {
                // Populate data saved in Excel
                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");

                // Refresh the page
                GlobalDefinitions.driver.Navigate().Refresh();

                // Wait for all text present in Element
                // GlobalDefinitions.WaitForTextPresentInElement(driver, profileName, GlobalDefinitions.ExcelLib.ReadData(2, "Name"), 10);

            }
            catch (Exception e)
            {
                Assert.Fail("Test failed to at preparation steps of verifying enter-profile", e.Message);
            }

            #region Verify Enter Language
            try
            {
                //Verify Language Name
                var lastRowLanguageName = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']" +
                    "/div/section[2]//div[3]/form/div[2]//div[2]//tbody[last()]/tr/td[1]")).Text;
                Assert.That(lastRowLanguageName, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "Language")));

                //Verify Language Level
                var lastRowLanguageLevel = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']" +
                    "/div/section[2]//div[3]/form/div[2]//div[2]//tbody[last()]/tr/td[2]")).Text;
                Assert.That(lastRowLanguageLevel, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "LanguageLevel")));

            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to verify Entering Language", ex.Message);
            }
            #endregion

            #region Verify Skills
            try
            {
                //Jump to Skill tab
                SkillTab.Click();

                //Verify Skill Name
                var lastRowSkillName = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']" +
                    "/div/section[2]//div[3]/form/div[3]//div[2]//tbody[last()]/tr/td[1]")).Text;
                Assert.That(lastRowSkillName, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "Skill")));

                //Verify Skill Level
                var lastRowSkillLevel = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']" +
                    "/div/section[2]//div[3]/form/div[3]//div[2]//tbody[last()]/tr/td[2]")).Text;
                Assert.That(lastRowSkillLevel, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "SkillLevel")));

            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to verify Entering Skills", ex.Message);
            }
            #endregion

            #region Verify Education
            try
            {
                //Jump to Education tab
                EducationTab.Click();

                //Verify Education Country
                var lastRowEducationCountry = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']" +
                    "/div/section[2]//div[3]/form/div[4]//div[2]//tbody[last()]/tr/td[1]")).Text;
                Assert.That(lastRowEducationCountry, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "Country")));

                //Verify Education Name
                var lastRowEducationName = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']" +
                    "/div/section[2]//div[3]/form/div[4]//div[2]//tbody[last()]/tr/td[2]")).Text;
                Assert.That(lastRowEducationName, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "University")));

                //Verify Education Title
                var lastRowEducationTitle = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']" +
                    "/div/section[2]//div[3]/form/div[4]//div[2]//tbody[last()]/tr/td[3]")).Text;
                Assert.That(lastRowEducationTitle, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "Title")));

                //Verify Education Degree
                var lastRowEducationDegree = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']" +
                    "/div/section[2]//div[3]/form/div[4]//div[2]//tbody[last()]/tr/td[4]")).Text;
                Assert.That(lastRowEducationDegree, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "Degree")));

                //Verify Education Graduation Year
                var lastRowEducationGraduationYear = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']" +
                    "/div/section[2]//div[3]/form/div[4]//div[2]//tbody[last()]/tr/td[5]")).Text;
                Assert.That(lastRowEducationGraduationYear, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "GraduationYear")));

            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to verify Entering Description", ex.Message);
            }

            #endregion

            #region Verify Certifications
            try
            {
                //Jump to Certification tab
                CertificationTab.Click();

                //Verify Certificate Name
                var lastRowCertificateName = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']" +
                    "/div/section[2]//div[3]/form/div[5]//div[2]//tbody[last()]/tr/td[1]")).Text;
                Assert.That(lastRowCertificateName, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "Certificate")));

                //Verify Certificate Issuing Place
                var lastRowCertificateFrom = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']" +
                    "/div/section[2]//div[3]/form/div[5]//div[2]//tbody[last()]/tr/td[2]")).Text;
                Assert.That(lastRowCertificateFrom, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "CertifiedFrom")));

                //Verify Certificate Year
                var lastRowCertificateYear = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']" +
                    "/div/section[2]//div[3]/form/div[5]//div[2]//tbody[last()]/tr/td[3]")).Text;
                Assert.That(lastRowCertificateYear, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "CertifiedYear")));

            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed to verify Entering Certificate", ex.Message);
            }
            #endregion


        }
        #endregion
    }
}