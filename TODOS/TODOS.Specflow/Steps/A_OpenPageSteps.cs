using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TODOS.Specflow.Steps;

namespace TODOS.Specflow
{
    [Binding]
    public class OpenPageSteps
    {
        public MainPage Page { get; set; }
        

        [When(@"I go to the page")]
        public void WhenIGoToThePage()
        {
            Page = new MainPage(ControlScenario.Driver);
        }
        
        [Then(@"the title should be ""(.*)""")]
        public void ThenTheTitleShouldBe(string title)
        {
            Page.RightTitle(title);
        }
        
        [Then(@"element should be present")]
        public void ThenElementShouldBePresent()
        {
            Page.InputExist();
        }
    }
}

