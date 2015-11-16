using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;


namespace TODOS
{
    public class MainPage : Page
    {
        private const How how = How.XPath;
        private const string url = "http://todomvc.com/examples/angularjs/#/";
        private const int countTask = 10;
        private const int activeTask = 8;
        private const int completedTask = 2;
 
        [FindsBy(How = how, Using = how == How.XPath ? ".//input[@id='new-todo']" : "input#new-todo")]
        public IWebElement MainInput { get; set; }

        [FindsBy(How = how, Using = how == How.XPath ? ".//strong[@class='ng-binding']" : "strong.ng-binding")]
        public IWebElement ToDoCounter { get; set; }

        [FindsBy(How = how, Using = how == How.XPath ? ".//a[text()='All']" : "a[href='#/']")]
        public IWebElement All { get; set; }

        [FindsBy(How = how, Using = how == How.XPath ? ".//a[text()='Active']" : "a[href='#/active']")]
        public IWebElement Active { get; set; }

        [FindsBy(How = how, Using = how == How.XPath ? ".//a[text()='Completed']" : "a[href='#/completed']")]
        public IWebElement Completed { get; set; }

        [FindsBy(How = how, Using = how == How.XPath ? ".//button[text()='Clear completed']" : "button#clear-completed")]
        public IWebElement ClearComleted { get; set; }

        [FindsBy(How = how, Using = how == How.XPath ? ".//li[@class='ng-scope']" : "li.ng-scope")]
        public IList<IWebElement> TasksActive { get; set; }

        [FindsBy(How = how, Using = how == How.XPath ? ".//li[@class='ng-scope completed']" : "li.ng-scope.completed")]
        public IList<IWebElement> TasksCompleted { get; set; }

        [FindsBy(How = how, Using = how == How.XPath ? ".//input[@id='toggle-all']" : "input#toggle-all")]
        public IWebElement ToggleAll { get; set; }

        private By markCompleted = how == How.XPath ? By.XPath(".//input[@class='toggle ng-pristine ng-untouched ng-valid']")
                                        : By.CssSelector("input.toggle.ng-pristine.ng-untouched.ng-valid");
        
        private By destroy = how == How.XPath ? By.XPath(".//button[@class='destroy']")
                                        : By.CssSelector("button.destroy");
        
        public MainPage(IWebDriver driver)
            : base(driver)
        {
            Navigate();
        }

        public void Navigate()
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void InputExist()
        {
            Assert.IsTrue(MainInput.Displayed);
        }

        public void RightTitle(string title)
        {
            Assert.AreEqual(title, Driver.Title);
        }


        public void DataEntry()
        {
            for (int i = 1; i <= countTask; i++)
            {
                MainInput.SendKeys(String.Format("{0}_task", i));
                MainInput.Submit();
            }
        }

        public void FooterElementsDisplayed()
        {
            Assert.IsTrue(All.Displayed);
            Assert.IsTrue(Active.Displayed);
            Assert.IsTrue(Completed.Displayed);
        }

        public void ToDoCountAll()
        {
            Assert.AreEqual(Convert.ToInt32(ToDoCounter.Text), TasksActive.Count());
        }

        public void ToDoCountActive()
        {
            Active.Click();
            Assert.AreEqual(Convert.ToInt32(ToDoCounter.Text), TasksActive.Count());
        }

        public void ToDoCountComlitedBefore()
        {
            Completed.Click();
            Assert.AreEqual(TasksCompleted.Count(), 0);

        }
        public void MarkTasks()
        {
            IWebElement mark;
            for (int i = 0; i < completedTask; i++)
            {
                mark = TasksActive[i].FindElement(markCompleted);
                mark.Click();
            }
            
        }

        public void ToDoCountComlitedAfter()
        {
            Completed.Click();
            Assert.AreEqual(TasksCompleted.Count(), completedTask);

        }

        public void ClearCompletedDisplayed()
        {
            Assert.IsTrue(ClearComleted.Displayed);
        }

        public void ClearComplited()
        {
            ClearComleted.Click();
            Assert.AreEqual(TasksCompleted.Count(), 0);
        }

        public void RemoveTask()
        {
            All.Click();
            IWebElement remove = TasksActive.First().FindElement(destroy);
            remove.Click();
            Assert.AreEqual(TasksActive.Count(),(activeTask - 1));
        }
        public void RemoveTasks()
        {
            All.Click();
            ToggleAll.Click();
            ClearComleted.Click();
            Assert.AreEqual(TasksActive.Count(), 0);
        }
        
    }
}
