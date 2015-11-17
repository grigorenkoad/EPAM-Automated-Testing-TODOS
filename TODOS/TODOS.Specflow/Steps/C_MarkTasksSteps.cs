using System;
using TechTalk.SpecFlow;
using TODOS.Specflow.Steps;
using OpenQA.Selenium;

namespace TODOS.Specflow
{
    [Binding]
    public class C_MarkTasksSteps
    {
        [Given(@"I go to the Active tab")]
        public void GivenIGoToTheActiveTab()
        {
            ControlScenario.Page.ToDoCountActive();
        }
        
        [When(@"I marked two tasks")]
        public void WhenIMarkedTwoTasks()
        {
            ControlScenario.Page.MarkTasks();
        }
        
        [When(@"I click on button ClearCompleted")]
        public void WhenIClickOnButtonClearCompleted()
        {
            ControlScenario.Page.ClearComplited();
        }
        
        [Then(@"on the tab Completed to be displayed two tasks")]
        public void ThenOnTheTabCompletedToBeDisplayedTwoTasks()
        {
            ControlScenario.Page.ToDoCountComlitedAfter();
        }
        
        [Then(@"must appear ClearCompleted element")]
        public void ThenMustAppearClearCompletedElement()
        {
            ControlScenario.Page.ClearCompletedDisplayed();
        }
    }
}
