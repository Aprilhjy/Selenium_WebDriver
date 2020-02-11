using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFramework.UIElements
{
    public class UsernameFieldPost
    {
        public UsernameFieldPost()
        {
            PageFactory.InitElements(Driver.driver, this);

        }
        [FindsBy(How = How.CssSelector, Using = "#post-74 > div > p > a")]
        public IWebElement LoginFormLink { get; set; }
    }
}
