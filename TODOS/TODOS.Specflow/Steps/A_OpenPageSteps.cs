using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TODOS.Specflow.Steps;
using NUnit.Framework;

namespace TODOS.Specflow
{
    [Binding]
    public class OpenPageSteps
    {
        [When(@"I go to the page")]
        public void WhenIGoToThePage()
        {
            Assert.IsTrue(true);
        }
        
        [Then(@"the title should be ""(.*)""")]
        public void ThenTheTitleShouldBe(string title)
        {
            ControlScenario.Page.RightTitle(title);
        }
        
        [Then(@"element should be present")]
        public void ThenElementShouldBePresent()
        {
            ControlScenario.Page.InputExist();
        }
    }
}

