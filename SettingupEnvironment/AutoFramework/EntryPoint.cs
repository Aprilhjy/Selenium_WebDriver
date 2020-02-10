using AutoFramework.UIElements;

namespace AutoFramework
{
    public class EntryPoint
    {
        [System.Obsolete]
        public static void Main()
        {
            Menu menu = new Menu();
            Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com/");
            menu.Selectors.Click();
        }
    }
}