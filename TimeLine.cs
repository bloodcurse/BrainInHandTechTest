using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

public class TimeLine
{

    private IWebDriver _driver;

    public TimeLine(ChromeDriver driver)
    {
        _driver = driver;
        PageFactory.InitElements(_driver, this);
    }

    [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/main/div/div/div/div[2]/div/div/div[1]/div/div[2]/div/div[2]/div[1]/div")]
    public IWebElement GreenRespomse;

    [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/main/div/div/div/div[2]/div/div/div[1]/div[1]/div[2]/div[1]/div[2]/div[2]/div/input")]
    public IWebElement addComment;

    [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/main/div/div/div/div[2]/div/div/div[1]/div[1]/div[2]/div[1]/div[2]/div[2]/div[2]/div[2]")]
    public IWebElement testComment;
}
