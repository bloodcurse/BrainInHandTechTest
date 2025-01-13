using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

public class WelcomePage
{
    private IWebDriver _driver;

    public WelcomePage(ChromeDriver driver)
    {
        _driver = driver;
        PageFactory.InitElements(_driver, this);
    }

    [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/main/div/div/div/div[1]/header/div/div[3]/div/div/div[2]/div/a[5]")]
    public IWebElement TimeLine;

}
