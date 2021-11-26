using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace QAAcademy.Steps
{    

    [Binding]
    public class CalculatorStepDefinition
    {
        private ChromeDriver driver;

        [Given(@"I Navigate to Google")]
        public void GivenINavigateToGoogle()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Url = "https://google.com";
        }
        
        [When(@"When I type (.*)")]
        public void WhenWhenITypeAKeyword(string keyword)
        {
            
            driver.FindElement(By.Name("q")).SendKeys(keyword);
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        }
        
        [Then(@"At least one result should contain (.*)")]
        public void ThenAtLeastOneResultShouldContainTheKeyword(string keyword)
        {
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[contains(translate(text(), 'ABCDEFGHIJKLMNOPQRSTUVWXYZÄÖÜÉÈÊÀÁÂÒÓÔÙÚÛÇÅÏÕÑŒ', 'abcdefghijklmnopqrstuvwxyzäöüéèêàáâòóôùúûçåïõñœ'),'keyword')]"));
            var num2 = 2;
            driver.Close();
            driver.Dispose();
        }
    }
}
