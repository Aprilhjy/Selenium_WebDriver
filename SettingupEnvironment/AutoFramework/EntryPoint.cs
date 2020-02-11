using AutoFramework.UIElements;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace AutoFramework
{
    public class EntryPoint
    {
        IAlert alert;
        static void Main()
        {       
  
        }
        [SetUp]
        public void Initialize()
        {
            Actions.InitializerDriver();
        }

        [Test]
        public void VaildLogin()
        {
            NavigateTo.LoginFormThroughMenu();
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.SuccessfulLogin, alert.Text);

            alert.Accept();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}