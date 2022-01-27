using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User :Base
        {
            
            //Share Skill Page - Enter a skill and verify
            [Test]
            public void EnterShareSkillTest()
            {
                test = extent.StartTest("Enter Share Skill");
                ShareSkill shareSkillPage = new ShareSkill();
                shareSkillPage.EnterShareSkill();
                shareSkillPage.VerifyEnterShareSkill();
                shareSkillPage.EditShareSkill();
                shareSkillPage.VerifyEditShareSkill();
            }


            //Share Skill Page - Enter a skill and verify
            [Test]
            public void ManageRequestsTest()

            {
                test = extent.StartTest("ManageRequests");
                ManageRequests manageRequests = new ManageRequests();
                manageRequests.SendRequest();
                manageRequests.VerifySendRequest();
                manageRequests.ReceivedRequest();
                manageRequests.VerifyReceivedRequest();
            }

            //Checking the working of active toggle button
            [Test]
            public void Managelistingpage()

            {
                test = extent.StartTest("View Listing");
                ManageListings manageListings = new ManageListings();
                manageListings.ActiveToggleWorking();
                
            }

            //Search skills using category and filters
            [Test]
            public void SearchSkills()

            {
                test = extent.StartTest("Search skills");
                SearchSkills searchSkills = new SearchSkills();
                searchSkills.SearchSkillsByCategories(GlobalDefinitions.driver);
                searchSkills.VerifySearchSkillsByCategories(GlobalDefinitions.driver);
                searchSkills.SearchSkillsByFilters(GlobalDefinitions.driver);
               searchSkills.VerifySearchSkillsByFilters(GlobalDefinitions.driver);

            }

            //Adding the profile details
            [Test]
            public void AddProfileDetails()
            {
                test = extent.StartTest("Add Profile");
                Profile profile = new Profile();
                profile.EnterProfile();
                profile.EditProfile();
                profile.VerifyEditProfile();
                profile.VerifyEnterProfile();
                //profile.ChangePassword();
                //profile.VerifyChangePassword();
            }

            //Delete the listing added in EnterShareSkill test
            [Test]
            public void DeleteListingTest()
            {
                test = extent.StartTest("Delete Listing");
                ManageListings deletelisting = new ManageListings();
                deletelisting.DeleteListing();
                deletelisting.VerifyDeleteListing();
            }

            //Verify Notification
            [Test]
            public void Notifications()
            {
                test = extent.StartTest("Notifications");
                Notifications notifications = new Notifications();
                notifications.ShowLessAndMoreNotification(GlobalDefinitions.driver);
                notifications.VerifyShowLessAndMoreNotification(GlobalDefinitions.driver);
                notifications.SelectNotification(GlobalDefinitions.driver);
                notifications.VerifySelectNotification(GlobalDefinitions.driver);
                notifications.MarkAsReadNotification(GlobalDefinitions.driver);
                notifications.VerifyMarkAsReadNotification(GlobalDefinitions.driver);
                 notifications.UnselectNotification(GlobalDefinitions.driver);
                 notifications.VerifyUnselectNotification(GlobalDefinitions.driver);
                notifications.DeleteNotification(GlobalDefinitions.driver);
                 notifications.VerifyDeleteNotification(GlobalDefinitions.driver);
            }


            //Chat
            [Test]
            public void ChatTest()
            {
                test = extent.StartTest("Verify Chat");
                Chat chat = new Chat();
                chat.ChatWithOtherUser(GlobalDefinitions.driver);
                chat.VerifyChatWithOtherUser(GlobalDefinitions.driver);
                chat.ViewChatHistory(GlobalDefinitions.driver);
                chat.VerifyViewChatHistory(GlobalDefinitions.driver);
                
            }

        }

    }
}