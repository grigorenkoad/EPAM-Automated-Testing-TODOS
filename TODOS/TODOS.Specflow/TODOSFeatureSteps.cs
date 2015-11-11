using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace TODOS.Specflow
{
    [Binding]
    public class UnknownSteps
    {
        public IWebDriver Driver { get; set; }
        public MainPage Page { get; set; }

        [TestFixtureSetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
            Page = new MainPage(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Close();
        }


        [When(@"I am on the page")]
        public void WhenIAmOnThePage()
        {
            Page.ToString();
        }
        
        [When(@"I am enter ten tasks")]
        public void WhenIAmEnterTenTasks()
        {
            Page.DataEntry();
        }
        
        [Then(@"the title should be ""(.*)""")]
        public void ThenTheTitleShouldBe(string p0)
        {
            Page.RightTitle();
        }
        
        [Then(@"counter shoul be equal ten")]
        public void ThenCounterShoulBeEqualTen()
        {
            Page.ToDoCountAll();
        }
    }
}
