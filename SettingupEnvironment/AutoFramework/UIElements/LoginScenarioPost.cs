﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutoFramework.UIElements
{
    class LoginScenarioPost
    {
        public LoginScenarioPost()
        {
            PageFactory.InitElements(Driver.driver, this);

        }

        [FindsBy(How = How.Name, Using = "userid")]
        public IWebElement UsernameField { get; set; }

        [FindsBy(How = How.Name, Using = "passid")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.Name, Using = "repeatpassid")]
        public IWebElement RepeatPasswordField { get; set; }

        [FindsBy(How = How.Name, Using = "submit")]
        public IWebElement LoginButton { get; set; }
    }
}
