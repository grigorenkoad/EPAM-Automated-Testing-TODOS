using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TODOS;

namespace UnitTestTODOS
{
    [TestFixture]
    public class UnitTest
    {
        public IWebDriver Driver { get; set; }
        public MainPage Page { get; set; }

        [TestFixtureSetUp]
        public void SetupTest()
        {
            Driver = new ChromeDriver();
            Page = new MainPage(Driver);
        }

        [TestFixtureTearDown]
        public void TeardownTest()
        {
            Driver.Quit();
        }

        [Test]
        public void A_RightPage()
        {
            string title = "AngularJS • TodoMVC";
            Page.RightTitle(title);
        }

        [Test]
        public void B_InputExist()
        {
            Page.InputExist();
        }

        [Test]
        public void C_DataEntry()
        {
            Page.DataEntry();
        }

        [Test]
        public void D_FooterElements()
        {
            Page.FooterElementsDisplayed();
        }

        [Test]
        public void E_ToDoCountAll()
        {
            Page.ToDoCountAll();
        }

        [Test]
        public void F_ToDoCountActive()
        {
            Page.ToDoCountActive();
        }

        [Test]
        public void G_ToDoCountCompleted()
        {
            Page.ToDoCountComlitedBefore();
        }

        [Test]
        public void H_MarkTasks()
        {
            Page.ToDoCountActive();
            Page.MarkTasks();
        }

        [Test]
        public void I_ToDoCountCompleted()
        {
            Page.ToDoCountComlitedAfter();
        }

        [Test]
        public void J_ClearCompletedDisplayed()
        {
            Page.ClearCompletedDisplayed();
        }

        [Test]
        public void K_ClearCompleted()
        {
            Page.ClearComplited();
        }

        [Test]
        public void L_RemoveTask()
        {
            Page.RemoveTask();
            Page.ToDoCountAll();
        }

        [Test]
        public void M_RemoveTasks()
        {
            Page.RemoveTasks();
        }
    }
}
