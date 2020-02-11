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

            Thread.Sleep(5000);

            Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com/");

            NavigateTo.LoginFormThroughThePost();

            Thread.Sleep(5000);






        }
    }
}