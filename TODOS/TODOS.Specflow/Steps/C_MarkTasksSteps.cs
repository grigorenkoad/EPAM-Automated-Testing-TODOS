using System;
using TechTalk.SpecFlow;
using TODOS.Specflow.Steps;
using OpenQA.Selenium;

namespace TODOS.Specflow
{
    [Binding]
    public class C_MarkTasksSteps
    {
        public MainPage Page = new MainPage(ControlScenario.Driver);

        [Given(@"I go to the Active tab")]
        public void GivenIGoToTheActiveTab()
        {
            Page.ToDoCountActive();
        }
        
        [When(@"I marked two tasks")]
        public void WhenIMarkedTwoTasks()
        {
            Page.MarkTasks();
        }
        
        [When(@"I click on button ClearCompleted")]
        public void WhenIClickOnButtonClearCompleted()
        {
            Page.ClearComplited();
        }
        
        [Then(@"on the tab Completed to be displayed two tasks")]
        public void ThenOnTheTabCompletedToBeDisplayedTwoTasks()
        {
            Page.ToDoCountComlitedAfter();
        }
        
        [Then(@"must appear ClearCompleted element")]
        public void ThenMustAppearClearCompletedElement()
        {
            Page.ClearCompletedDisplayed();
        }
    }
}
