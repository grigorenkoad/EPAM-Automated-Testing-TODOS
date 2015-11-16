using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TODOS.Specflow.Steps
{
    [Binding]
    public class ControlScenario
    {
        public static IWebDriver Driver { get; set; }

        [BeforeScenario("Setup")]
        public void SetupDriver()
        {
            Driver = new ChromeDriver();
        }

        [AfterScenario("Teardown")]
        public void TeardownDriver()
        {
            Driver.Quit();
        }
    }
}
