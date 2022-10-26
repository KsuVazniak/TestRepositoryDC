using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DCDCTest
{
    public class Tests
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }
        [TearDown]
        public void Quit()
        {
            driver.Quit();
        }

        [Test]
        public void OpenMainTestPage()
        {
            driver.Navigate().GoToUrl("https://www.dating.com/");
            Assert.That(driver.Title, Does.Contain("Dating"), "Неправильный title на странице dating.com");
        }
    }
}