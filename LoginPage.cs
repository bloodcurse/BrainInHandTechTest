using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

public class Loginpage
{
    private IWebDriver _driver;

    public Loginpage(ChromeDriver driver)
    {
        _driver = driver;
        PageFactory.InitElements(_driver, this);
    }

    [FindsBy(How = How.Id, Using = "loginInput")]
    public IWebElement LoginID;

    [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/main/div/div/div[2]/div/div[2]/div/form/div[2]/button")]
    public IWebElement ContinueBtn;

    [FindsBy(How = How.Name, Using = "Password")]
    public IWebElement Password;

    [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/main/div/div/div[2]/div/div[2]/div/form/div[3]/button[1]")]
    public IWebElement signInBtn;

}

