using System;
using TechTalk.SpecFlow;
using TODOS.Specflow.Steps;
using OpenQA.Selenium;
using NUnit.Framework;

namespace TODOS.Specflow
{
    [Binding]
    public class D_RemoveTasksSteps
    {
        [When(@"I Remove one task")]
        public void WhenIRemoveOneTask()
        {
            ControlScenario.Page.RemoveTask();
        }
        
        [When(@"I Remove all tasks")]
        public void WhenIRemoveAllTasks()
        {
            ControlScenario.Page.RemoveTasks();
        }
        
        [Then(@"their stays seven")]
        public void ThenTheirStaysSeven()
        {
            ControlScenario.Page.ToDoCountAll();
        }
        
        [Then(@"their stays zero")]
        public void ThenTheirStaysZero()
        {
            Assert.AreEqual(ControlScenario.Page.TasksActive.Count, 0);
        }
    }
}
