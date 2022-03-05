using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace MarsAutomation.Feature
{ 
  
    [Binding]
    public sealed class Seller_AddProfileDetailsStepsMarsQAAutomation
    {
        String test_url = "http://localhost:5000/Home";
        String itemName = "A description can be added by seller in my Profile";
        IWebDriver driver;

        private readonly ScenarioContext context;

        public Seller_AddProfileDetailsStepsMarsQAAutomation(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }
        [Given(@"the Mars QA website and credentials to login")]
        public void GivenTheMarsQAWebsiteAndCredentialsToLogin()
        {
            driver = new FirefoxDriver();
            driver.Url = test_url;
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(2000);
        }
        
        [When(@"I login in the website")]
        public void WhenILoginInTheWebsite()
        {
            IWebElement Sign = driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div[1]/div/a"));
            Sign.Click();

            IWebElement EmailAddress = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            EmailAddress.SendKeys("engr.antriksh21@gmail.com");

            IWebElement Password = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            Password.SendKeys("Antriksh12345");

            IWebElement Login = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            Login.Click();
        }
        
        [Then(@"Profile picture is displayed on my Profile page")]
        public void ThenProfilePictureIsDisplayedOnMyProfilePage()
        {
            IWebElement ProfilePicture = driver.FindElement(By.CssSelector(".image > img:nth-child(1)"));
            ProfilePicture.Click();
        }

        [Then(@"close the browser instance")]
        public void ThenCloseTheBrowserInstance()
        {
            driver.Quit();
        }

        [Then(@"I click on pencil icon")]
        public void ThenIClickOnPencilIcon()
        {
            IWebElement Description = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            Description.Click();
        }

        [Then(@"find the text box to enter new value")]
        public void ThenFindTheTextBoxToEnterNewValue()
        {
            IWebElement Textbox = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            Textbox.SendKeys("ABCD");
        }

        [Then(@"click Save button")]
        public void ThenClickSaveButton()
        {
            IWebElement SaveButton = driver.FindElement(By.CssSelector("button.ui:nth-child(3)"));
            SaveButton.Click();
        }

        [Then(@"I click on Add New button")]
        public void ThenIClickOnAddNewButton()
        {
            IWebElement AddNewButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewButton.Click();
        }

        [Then(@"find dropdown button to select language level")]
        public void ThenFindDropdownButtonToSelectLanguageLevel()
        {
            IWebElement LanguageLevel = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            LanguageLevel.Click();
        }

        [Then(@"click Add button")]
        public void ThenClickAddButton()
        {
            IWebElement Add = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            Add.Click();
        }
        [Then(@"close the browser instance")]
        public void ThenCloseTheBrowserInstance_()
        {
            driver.Quit();
        }
    }
}
