using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V129.Network;
using System.Text;

namespace BrainInHandTechTest
{
    public class Tests
    {


        private IWebDriver _driver;
        
        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();

        }

        [Test]
        public void ScenarioOne()
        {


            Loginpage lp = new Loginpage((ChromeDriver)_driver);
            WelcomePage wp = new WelcomePage((ChromeDriver)_driver);
            TimeLine tl = new TimeLine((ChromeDriver)_driver);

            _driver.Navigate().GoToUrl("https://stage.braininhand.co.uk");
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //dismiss cookie script
            _driver.FindElement(By.Id("cookiescript_close")).Click();

            lp.LoginID.SendKeys("bihtest+ux2x8m3jb9@fastmail.co.uk");
            lp.ContinueBtn.Click();
            lp.Password.SendKeys("Password1234");
            lp.signInBtn.Click();

            wp.TimeLine.Click();

            tl.GreenRespomse.Click();
            Boolean Display = tl.GreenRespomse.Displayed;

            Assert.That(Display, Is.True);  

            


            Thread.Sleep(20000);


            _driver.Dispose();

        }

        [Test]
        public void GreenTimelineEntry()
        {

            Guid id = Guid.NewGuid();
            var x = id.ToString();
            var y = DateTime.Now;
            var z = y.ToString();



            var postData = new PostData
            {

                level = "Green",
                sentTimestamp = z,
                id = x

            };

            //Sorry cannot get auth to work.

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://stage.braininhand.co.uk/services/mood-tracking");
            var json = System.Text.Json.JsonSerializer.Serialize(postData);

            var content = new StringContent(json, Encoding.UTF8, "application/json");


            var response = client.PostAsync("posts", content).Result;



            Loginpage lp = new Loginpage((ChromeDriver)_driver);
            WelcomePage wp = new WelcomePage((ChromeDriver)_driver);
            TimeLine tl = new TimeLine((ChromeDriver)_driver);

            _driver.Navigate().GoToUrl("https://stage.braininhand.co.uk");
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //dismiss cookie script
            _driver.FindElement(By.Id("cookiescript_close")).Click();

            lp.LoginID.SendKeys("bihtest+ux2x8m3jb9@fastmail.co.uk");
            lp.ContinueBtn.Click();
            lp.Password.SendKeys("Password1234");
            lp.signInBtn.Click();

            wp.TimeLine.Click();

            tl.GreenRespomse.Click();

            Boolean Display = tl.GreenRespomse.Displayed;
            Assert.That(Display, Is.True);


            tl.addComment.Click();
            tl.addComment.SendKeys("test string data");

            tl.addComment.SendKeys(Keys.Return);

            Boolean comment = tl.testComment.Displayed;
            Assert.That(comment, Is.True);


            //used for tesdting purposes
            //Thread.Sleep(20000);


            _driver.Dispose();


        }
    }

}