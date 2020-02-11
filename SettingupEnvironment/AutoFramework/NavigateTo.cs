using AutoFramework.UIElements;
using System.Threading;

namespace AutoFramework
{
    public static class NavigateTo
    {
        public static void LoginFormThroughMenu()
        {
            Menu menu = new Menu();
            TestScenariosPage tsPage = new TestScenariosPage();

            menu.TestScenarios.Click();
            Thread.Sleep(5000);
            tsPage.LoginForm.Click();
            Thread.Sleep(5000);
        }

        public static void LoginFormThroughThePost()
        {
            Menu menu = new Menu();
            TestCasesPage tcPage = new TestCasesPage();
            UsernameFieldPost ufPost = new UsernameFieldPost();

            menu.TestCases.Click();
            Thread.Sleep(5000);
            tcPage.UsernameFieldPost.Click();
            Thread.Sleep(5000);
            ufPost.LoginFormLink.Click();
            Thread.Sleep(5000);

            Driver.driver.Quit();
        }
    }
}
