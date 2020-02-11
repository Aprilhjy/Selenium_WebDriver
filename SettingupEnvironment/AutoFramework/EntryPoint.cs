using AutoFramework.UIElements;
using System.Threading;

namespace AutoFramework
{
    public class EntryPoint
    {
        static void Main()
        {
            Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com/");

            NavigateTo.LoginFormThroughMenu();
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password,Config.Credentials.Valid.RepeatPassword);

  
        }
    }
}