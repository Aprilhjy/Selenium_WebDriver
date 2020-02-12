using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AutoFramework
{
    public class EntryPoint
    {
        static void Main()
        {
            IWebDriver driver = new ChromeDriver();
            string url = "http://testing.todvachev.com/";

            driver.Navigate().GoToUrl(url);

            IWebElement image = driver.FindElement(By.CssSelector("#page-17 > div > p:nth-child(1) > a > img"));

            driver.Manage().Window.Maximize();

            System.Console.WriteLine(image.Location.X);
            System.Console.WriteLine(image.Location.Y);
            System.Console.WriteLine(image.Size.Width);
            System.Console.WriteLine(image.Size.Height);
        }
    }
}