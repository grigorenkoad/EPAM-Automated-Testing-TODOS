using System;
using TechTalk.SpecFlow;
using TODOS.Specflow.Steps;
using OpenQA.Selenium;

namespace TODOS.Specflow
{
    [Binding]
    public class D_RemoveTasksSteps
    {
        public MainPage Page = new MainPage(ControlScenario.Driver);

        [When(@"I Remove one task")]
        public void WhenIRemoveOneTask()
        {
            Page.RemoveTask();
        }
        
        [When(@"I Remove all tasks")]
        public void WhenIRemoveAllTasks()
        {
            Page.RemoveTasks();
        }
        
        [Then(@"their stays seven")]
        public void ThenTheirStaysSeven()
        {
            Page.ToDoCountAll();
        }
        
        [Then(@"their stays zero")]
        public void ThenTheirStaysZero()
        {
            Page.ToDoCountAll();
        }
    }
}
