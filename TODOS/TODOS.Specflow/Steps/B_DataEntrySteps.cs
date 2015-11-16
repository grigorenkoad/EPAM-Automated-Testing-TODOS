using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using TODOS.Specflow.Steps;

namespace TODOS.Specflow
{
    [Binding]
    public class B_DataEntrySteps
    {
        public MainPage Page = new MainPage(ControlScenario.Driver);

        [When(@"I add ten tasks")]
        public void WhenIAddTenTasks()
        {
            Page.DataEntry();
        }

        [Then(@"must appear footer elements")]
        public void ThenMustAppearFooterElements()
        {
            Page.FooterElementsDisplayed();
        }
        
        [Then(@"on the tab All to be displayed ten tasks")]
        public void ThenOnTheTabAllToBeDisplayedTenTasks()
        {
            Page.ToDoCountAll();
        }
        
        [Then(@"on the tab Active to be displayed ten tasks")]
        public void ThenOnTheTabActiveToBeDisplayedTenTasks()
        {
            Page.ToDoCountActive();
        }
        
        [Then(@"on the tab Completed to be displayed zero tasks")]
        public void ThenOnTheTabCompletedToBeDisplayedZeroTasks()
        {
            Page.ToDoCountComlitedBefore();
        }
    }
}
