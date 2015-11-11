using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace TODOS.Specflow
{
    [Binding]
    public class TODOSFeature2Steps
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

        [When(@"I press all")]
        public void WhenIPressAll()
        {
            
        }
        
        [When(@"I press active")]
        public void WhenIPressActive()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press complrtrd")]
        public void WhenIPressComplrtrd()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"counter shoul be equal zero")]
        public void ThenCounterShoulBeEqualZero()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
